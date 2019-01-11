using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using GEV.Benchmark.API;

namespace GEV.Benchmark
{
    public partial class BenchmarkControl : UserControl
    {
        public BindingList<IBenchmark> AvailableBenchmarks { get; private set; }
        private IBenchmark SelectedBenchmark;
        private Stopwatch BenchmarkStopwatch;

        private CancellationTokenSource ThreadRunnerCancelNotifier;

        #region Konstruktorok
        public BenchmarkControl() : this(true)
        {
            
        }

        public BenchmarkControl(bool loadBuiltinBenchmarks)
        {
            InitializeComponent();

            this.AvailableBenchmarks = new BindingList<IBenchmark>();

            this.BenchmarkStopwatch = new Stopwatch();

            this.lbxSelectedBenchmark.DataSource = this.AvailableBenchmarks;
            this.lbxSelectedBenchmark.DisplayMember = "Name";
            this.lbxSelectedBenchmark.SelectedIndexChanged += LbxSelectedBenchmark_SelectedIndexChanged;

            this.lblPostRunStats.Text = "";
            this.lblSelectedBenchmarkName.Text = "";

            this.clbShownChartSeries.DisplayMember = "Name";

            if(loadBuiltinBenchmarks && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                var classes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(t => t.GetTypes());
                var benchmarks = classes.Where(t => t.GetInterfaces().Contains(typeof(IBenchmark)) && !t.IsAbstract);
                foreach (Type t in benchmarks)
                {
                    this.AvailableBenchmarks.Add((IBenchmark)Activator.CreateInstance(t));
                }
            }
        }
        #endregion

        #region UI eventek
        private void LbxSelectedBenchmark_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedBenchmark = (IBenchmark)this.lbxSelectedBenchmark.SelectedItem;
            this.prgSelectedBenchmarkProperties.SelectedObject = this.SelectedBenchmark;

            this.lblSelectedBenchmarkName.Text = this.SelectedBenchmark.Name;
        }

        private void btnStartBenchmark_Click(object sender, EventArgs e)
        {
            if(this.SelectedBenchmark != null)
            {
                this.SetUI(true);
                this.lblPostRunStats.Text = "";

                this.ThreadRunnerCancelNotifier = new CancellationTokenSource();

                Task.Run(new Action(BenchmarkThreadRunner), this.ThreadRunnerCancelNotifier.Token);
            }
            else
            {
                MessageBox.Show("No benchmark selected!");
            }
        }

        private void btnAbortBenchmark_Click(object sender, EventArgs e)
        {
            this.ThreadRunnerCancelNotifier.Cancel();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.AddExtension = true;
            sfd.Filter = "PNG Files (*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.chtBenchmarkResults.SaveImage(Path.GetFullPath(sfd.FileName), ChartImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Image could not be saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void clbShownChartSeries_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ((Series)((CheckedListBox)sender).Items[e.Index]).Enabled = e.NewValue == CheckState.Checked ? true : false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.AddExtension = true;
            sfd.Filter = "FBD Files (*.fbd)|*.fbd";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.chtBenchmarkResults.Serializer.Save(Path.GetFullPath(sfd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Benchmark data could not be saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnImportOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckPathExists = true;
            ofd.AddExtension = true;
            ofd.Filter = "FBD Files (*.fbd)|*.fbd";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.chtBenchmarkResults.Serializer.Load(Path.GetFullPath(ofd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Benchmark data could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnImportCompare_Click(object sender, EventArgs e)
        {
            Chart temp1 = new Chart();
            Chart temp2 = new Chart();
            bool error = false;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckPathExists = true;
            ofd.AddExtension = true;
            ofd.Filter = "FBD Files (*.fbd)|*.fbd";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    temp1.Serializer.Load(Path.GetFullPath(ofd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Benchmark data could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }

            if (!error)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        temp2.Serializer.Load(Path.GetFullPath(ofd.FileName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Benchmark data could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                }
            }

            if (!error)
            {
                this.chtBenchmarkResults.Series.Clear();
                this.clbShownChartSeries.Items.Clear();

                foreach (Series s in temp1.Series)
                {
                    s.Name = s.Name.Substring(0, s.Name.Length - 1) + ", S1)";
                    this.chtBenchmarkResults.Series.Add(s);

                    this.clbShownChartSeries.Items.Add(s);
                    this.clbShownChartSeries.SetItemChecked(this.clbShownChartSeries.Items.Count - 1, true);
                }

                foreach (Series s in temp2.Series)
                {
                    s.Name = s.Name.Substring(0, s.Name.Length - 1) + ", S2)";
                    this.chtBenchmarkResults.Series.Add(s);

                    this.clbShownChartSeries.Items.Add(s);
                    this.clbShownChartSeries.SetItemChecked(this.clbShownChartSeries.Items.Count - 1, true);
                }
            }
        }

        private void btnImportKeepCurrent_Click(object sender, EventArgs e)
        {
            Chart temp = new Chart();
            bool error = false;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckPathExists = true;
            ofd.AddExtension = true;
            ofd.Filter = "FBD Files (*.fbd)|*.fbd";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    temp.Serializer.Load(Path.GetFullPath(ofd.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Benchmark data could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }

            if(!error)
            {
                foreach (Series s in this.chtBenchmarkResults.Series)
                {
                    s.Name = s.Name.Substring(0, s.Name.Length - 1) + ", S1)";
                }

                foreach (Series s in temp.Series)
                {
                    s.Name = s.Name.Substring(0, s.Name.Length - 1) + ", S2)";
                    this.chtBenchmarkResults.Series.Add(s);

                    this.clbShownChartSeries.Items.Add(s);
                    this.clbShownChartSeries.SetItemChecked(this.clbShownChartSeries.Items.Count - 1, true);
                }
            }
        }

        #endregion

        #region Benchmark futtatás és kapcsolódó metódusok
        private void BenchmarkThreadRunner()
        {
            bool noErrors = true;
            double[] results;

            try
            {
                this.SelectedBenchmark.StartBenchmark();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Benchmark start aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SetUI(false);
                return;
            }

            this.Invoke(new Action(() =>
            {
                this.chtBenchmarkResults.Series.Clear();
                this.clbShownChartSeries.Items.Clear();
                foreach (BenchmarkDataPoint bdp in this.SelectedBenchmark.Parameters)
                {                
                    Series serie = new Series(bdp.Name + " \n" + (bdp.UsesSecondaryAxis ? "(Secondary axis)" : "(Primary axis)"));
                    serie.ChartType = SeriesChartType.Line;
                    serie.YAxisType = bdp.UsesSecondaryAxis ? AxisType.Secondary : AxisType.Primary;
                    serie.BorderWidth = 2;

                    this.chtBenchmarkResults.Series.Add(serie);

                    this.clbShownChartSeries.Items.Add(serie);
                    this.clbShownChartSeries.SetItemChecked(this.clbShownChartSeries.Items.Count - 1, true);
                }

                this.chtBenchmarkResults.ChartAreas[0].AxisY.LabelStyle.Format = this.SelectedBenchmark.PrimaryAxisFormat;
                this.chtBenchmarkResults.ChartAreas[0].AxisY2.LabelStyle.Format = this.SelectedBenchmark.SecondaryAxisFormat;
            }));

            for (int i = 0; (i < this.SelectedBenchmark.IterationCount || this.SelectedBenchmark.Freerun); i++)
            {
                if (this.ThreadRunnerCancelNotifier.Token.IsCancellationRequested)
                {
                    //Itt kilépünk a ciklusból -> a következő lépés a statolás kicsit lejjebb
                    break;
                }

                this.BenchmarkStopwatch.Restart();
                try
                {
                    results = this.SelectedBenchmark.ExecuteInstance(i);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Benchmark has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    noErrors = false;
                    break;
                }

                long elapsed = this.BenchmarkStopwatch.ElapsedMilliseconds;
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        for (int j = 0; j < Math.Min(results.Length, this.chtBenchmarkResults.Series.Count); j++)
                        {
                            this.chtBenchmarkResults.Series[j].Points.Add(results[j]);
                        }
                    }
                    catch (Exception) { }
                }));
            }

            this.SetUI(false);

            this.Invoke(new Action(() =>
            {
                this.CalculateStats(noErrors);
            }));
        }

        private void CalculateStats(bool benchmarkResult)
        {
            var dataSample = this.chtBenchmarkResults.Series[0].Points.OrderBy(p => p.YValues[0]);
            
            this.lblPostRunStats.Text = "";
            int iterations = (int)dataSample.Count();
            if (iterations > 0)
            {
                double min = dataSample.Min(p => p.YValues[0]);
                double max = dataSample.Max(p => p.YValues[0]);
                double average = dataSample.Average(p => p.YValues[0]);
                double median = (dataSample.ElementAt(iterations / 2).YValues[0] + dataSample.ElementAt((iterations - 1) / 2).YValues[0]) / 2;

                this.lblPostRunStats.Text = String.Format("Iterations: {0} | Minimum: {1} ms | Maximum: {2} ms | Average: {3:0.0000} ms | Median: {4} ms", iterations, min, max, average, median);
            }
            if(!benchmarkResult)
            {
                this.lblPostRunStats.Text += " | The benchmark ended with an error!";
            }
        }

        private void SetUI(bool benchMarkStart)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    SetUINoInvoke(benchMarkStart);
                }));
            }
            else
            {
                SetUINoInvoke(benchMarkStart);
            }
        }

        private void SetUINoInvoke(bool benchMarkStart)
        {
            bool en = !benchMarkStart;
            this.btnStartBenchmark.Enabled = en;
            this.lbxSelectedBenchmark.Enabled = en;
            this.prgSelectedBenchmarkProperties.Enabled = en;
            this.btnAbortBenchmark.Enabled = !en;

            this.btnImportCompare.Enabled = en;
            this.btnImportOne.Enabled = en;
            this.btnExport.Enabled = en;
            this.btnSaveImage.Enabled = en;

        }
        #endregion
    }
}
