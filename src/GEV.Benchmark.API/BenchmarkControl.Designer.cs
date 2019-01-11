namespace GEV.Benchmark
{
    partial class BenchmarkControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chtBenchmarkResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPostRunStats = new System.Windows.Forms.Label();
            this.tbcMainTabControl = new System.Windows.Forms.TabControl();
            this.tabBenchmark = new System.Windows.Forms.TabPage();
            this.tlpBenchmark = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControlButtons = new System.Windows.Forms.Panel();
            this.btnAbortBenchmark = new System.Windows.Forms.Button();
            this.btnStartBenchmark = new System.Windows.Forms.Button();
            this.prgSelectedBenchmarkProperties = new System.Windows.Forms.PropertyGrid();
            this.gbxAvailableBenchmarks = new System.Windows.Forms.GroupBox();
            this.lbxSelectedBenchmark = new System.Windows.Forms.ListBox();
            this.lblSelectedBenchmarkName = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabPage();
            this.clbShownChartSeries = new System.Windows.Forms.CheckedListBox();
            this.tabImportExport = new System.Windows.Forms.TabPage();
            this.gbxImport = new System.Windows.Forms.GroupBox();
            this.gbxExport = new System.Windows.Forms.GroupBox();
            this.btnImportOne = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImportCompare = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnImportKeepCurrent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtBenchmarkResults)).BeginInit();
            this.tbcMainTabControl.SuspendLayout();
            this.tabBenchmark.SuspendLayout();
            this.tlpBenchmark.SuspendLayout();
            this.pnlControlButtons.SuspendLayout();
            this.gbxAvailableBenchmarks.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabImportExport.SuspendLayout();
            this.gbxImport.SuspendLayout();
            this.gbxExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chtBenchmarkResults, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPostRunStats, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbcMainTabControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 762);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chtBenchmarkResults
            // 
            chartArea1.AxisY.Title = "Primary Axis";
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY2.Title = "Secondary Axis";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chtBenchmarkResults.ChartAreas.Add(chartArea1);
            this.chtBenchmarkResults.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtBenchmarkResults.Legends.Add(legend1);
            this.chtBenchmarkResults.Location = new System.Drawing.Point(403, 3);
            this.chtBenchmarkResults.Name = "chtBenchmarkResults";
            this.chtBenchmarkResults.Size = new System.Drawing.Size(771, 716);
            this.chtBenchmarkResults.TabIndex = 3;
            this.chtBenchmarkResults.Text = "chart1";
            // 
            // lblPostRunStats
            // 
            this.lblPostRunStats.AutoSize = true;
            this.lblPostRunStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostRunStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostRunStats.Location = new System.Drawing.Point(403, 722);
            this.lblPostRunStats.Name = "lblPostRunStats";
            this.lblPostRunStats.Size = new System.Drawing.Size(771, 40);
            this.lblPostRunStats.TabIndex = 5;
            this.lblPostRunStats.Text = "{STATS}";
            this.lblPostRunStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbcMainTabControl
            // 
            this.tbcMainTabControl.Controls.Add(this.tabBenchmark);
            this.tbcMainTabControl.Controls.Add(this.tabView);
            this.tbcMainTabControl.Controls.Add(this.tabImportExport);
            this.tbcMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMainTabControl.Location = new System.Drawing.Point(3, 3);
            this.tbcMainTabControl.Name = "tbcMainTabControl";
            this.tableLayoutPanel1.SetRowSpan(this.tbcMainTabControl, 2);
            this.tbcMainTabControl.SelectedIndex = 0;
            this.tbcMainTabControl.Size = new System.Drawing.Size(394, 756);
            this.tbcMainTabControl.TabIndex = 7;
            // 
            // tabBenchmark
            // 
            this.tabBenchmark.Controls.Add(this.tlpBenchmark);
            this.tabBenchmark.Location = new System.Drawing.Point(4, 22);
            this.tabBenchmark.Name = "tabBenchmark";
            this.tabBenchmark.Padding = new System.Windows.Forms.Padding(3);
            this.tabBenchmark.Size = new System.Drawing.Size(386, 730);
            this.tabBenchmark.TabIndex = 0;
            this.tabBenchmark.Text = "Benchmark";
            this.tabBenchmark.UseVisualStyleBackColor = true;
            // 
            // tlpBenchmark
            // 
            this.tlpBenchmark.ColumnCount = 1;
            this.tlpBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBenchmark.Controls.Add(this.pnlControlButtons, 0, 3);
            this.tlpBenchmark.Controls.Add(this.prgSelectedBenchmarkProperties, 0, 2);
            this.tlpBenchmark.Controls.Add(this.gbxAvailableBenchmarks, 0, 0);
            this.tlpBenchmark.Controls.Add(this.lblSelectedBenchmarkName, 0, 1);
            this.tlpBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBenchmark.Location = new System.Drawing.Point(3, 3);
            this.tlpBenchmark.Name = "tlpBenchmark";
            this.tlpBenchmark.RowCount = 4;
            this.tlpBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBenchmark.Size = new System.Drawing.Size(380, 724);
            this.tlpBenchmark.TabIndex = 0;
            // 
            // pnlControlButtons
            // 
            this.pnlControlButtons.Controls.Add(this.btnAbortBenchmark);
            this.pnlControlButtons.Controls.Add(this.btnStartBenchmark);
            this.pnlControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlButtons.Location = new System.Drawing.Point(3, 687);
            this.pnlControlButtons.Name = "pnlControlButtons";
            this.pnlControlButtons.Size = new System.Drawing.Size(374, 34);
            this.pnlControlButtons.TabIndex = 4;
            // 
            // btnAbortBenchmark
            // 
            this.btnAbortBenchmark.Enabled = false;
            this.btnAbortBenchmark.Location = new System.Drawing.Point(238, 3);
            this.btnAbortBenchmark.Name = "btnAbortBenchmark";
            this.btnAbortBenchmark.Size = new System.Drawing.Size(133, 28);
            this.btnAbortBenchmark.TabIndex = 1;
            this.btnAbortBenchmark.Text = "Abort benchmark";
            this.btnAbortBenchmark.UseVisualStyleBackColor = true;
            this.btnAbortBenchmark.Click += new System.EventHandler(this.btnAbortBenchmark_Click);
            // 
            // btnStartBenchmark
            // 
            this.btnStartBenchmark.Location = new System.Drawing.Point(3, 3);
            this.btnStartBenchmark.Name = "btnStartBenchmark";
            this.btnStartBenchmark.Size = new System.Drawing.Size(133, 28);
            this.btnStartBenchmark.TabIndex = 0;
            this.btnStartBenchmark.Text = "Run benchmark";
            this.btnStartBenchmark.UseVisualStyleBackColor = true;
            this.btnStartBenchmark.Click += new System.EventHandler(this.btnStartBenchmark_Click);
            // 
            // prgSelectedBenchmarkProperties
            // 
            this.prgSelectedBenchmarkProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgSelectedBenchmarkProperties.Location = new System.Drawing.Point(3, 243);
            this.prgSelectedBenchmarkProperties.Name = "prgSelectedBenchmarkProperties";
            this.prgSelectedBenchmarkProperties.Size = new System.Drawing.Size(374, 438);
            this.prgSelectedBenchmarkProperties.TabIndex = 2;
            // 
            // gbxAvailableBenchmarks
            // 
            this.gbxAvailableBenchmarks.Controls.Add(this.lbxSelectedBenchmark);
            this.gbxAvailableBenchmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAvailableBenchmarks.Location = new System.Drawing.Point(3, 3);
            this.gbxAvailableBenchmarks.Name = "gbxAvailableBenchmarks";
            this.gbxAvailableBenchmarks.Size = new System.Drawing.Size(374, 194);
            this.gbxAvailableBenchmarks.TabIndex = 1;
            this.gbxAvailableBenchmarks.TabStop = false;
            this.gbxAvailableBenchmarks.Text = "Available benchmarks";
            // 
            // lbxSelectedBenchmark
            // 
            this.lbxSelectedBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSelectedBenchmark.FormattingEnabled = true;
            this.lbxSelectedBenchmark.Location = new System.Drawing.Point(3, 16);
            this.lbxSelectedBenchmark.Name = "lbxSelectedBenchmark";
            this.lbxSelectedBenchmark.Size = new System.Drawing.Size(368, 175);
            this.lbxSelectedBenchmark.TabIndex = 0;
            // 
            // lblSelectedBenchmarkName
            // 
            this.lblSelectedBenchmarkName.AutoSize = true;
            this.lblSelectedBenchmarkName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedBenchmarkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBenchmarkName.Location = new System.Drawing.Point(3, 200);
            this.lblSelectedBenchmarkName.Name = "lblSelectedBenchmarkName";
            this.lblSelectedBenchmarkName.Size = new System.Drawing.Size(374, 40);
            this.lblSelectedBenchmarkName.TabIndex = 5;
            this.lblSelectedBenchmarkName.Text = "{SELECTED}";
            this.lblSelectedBenchmarkName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.clbShownChartSeries);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(386, 730);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // clbShownChartSeries
            // 
            this.clbShownChartSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbShownChartSeries.FormattingEnabled = true;
            this.clbShownChartSeries.Location = new System.Drawing.Point(3, 3);
            this.clbShownChartSeries.Name = "clbShownChartSeries";
            this.clbShownChartSeries.Size = new System.Drawing.Size(380, 724);
            this.clbShownChartSeries.TabIndex = 0;
            this.clbShownChartSeries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbShownChartSeries_ItemCheck);
            // 
            // tabImportExport
            // 
            this.tabImportExport.Controls.Add(this.gbxExport);
            this.tabImportExport.Controls.Add(this.gbxImport);
            this.tabImportExport.Location = new System.Drawing.Point(4, 22);
            this.tabImportExport.Name = "tabImportExport";
            this.tabImportExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImportExport.Size = new System.Drawing.Size(386, 730);
            this.tabImportExport.TabIndex = 2;
            this.tabImportExport.Text = "Import/Export";
            this.tabImportExport.UseVisualStyleBackColor = true;
            // 
            // gbxImport
            // 
            this.gbxImport.Controls.Add(this.btnImportKeepCurrent);
            this.gbxImport.Controls.Add(this.btnImportCompare);
            this.gbxImport.Controls.Add(this.btnImportOne);
            this.gbxImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxImport.Location = new System.Drawing.Point(3, 3);
            this.gbxImport.Name = "gbxImport";
            this.gbxImport.Size = new System.Drawing.Size(380, 147);
            this.gbxImport.TabIndex = 0;
            this.gbxImport.TabStop = false;
            this.gbxImport.Text = "Import";
            // 
            // gbxExport
            // 
            this.gbxExport.Controls.Add(this.btnSaveImage);
            this.gbxExport.Controls.Add(this.btnExport);
            this.gbxExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxExport.Location = new System.Drawing.Point(3, 150);
            this.gbxExport.Name = "gbxExport";
            this.gbxExport.Size = new System.Drawing.Size(380, 107);
            this.gbxExport.TabIndex = 1;
            this.gbxExport.TabStop = false;
            this.gbxExport.Text = "Export";
            // 
            // btnImportOne
            // 
            this.btnImportOne.Location = new System.Drawing.Point(6, 19);
            this.btnImportOne.Name = "btnImportOne";
            this.btnImportOne.Size = new System.Drawing.Size(368, 35);
            this.btnImportOne.TabIndex = 0;
            this.btnImportOne.Text = "Import...";
            this.btnImportOne.UseVisualStyleBackColor = true;
            this.btnImportOne.Click += new System.EventHandler(this.btnImportOne_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(6, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(368, 35);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImportCompare
            // 
            this.btnImportCompare.Location = new System.Drawing.Point(6, 60);
            this.btnImportCompare.Name = "btnImportCompare";
            this.btnImportCompare.Size = new System.Drawing.Size(368, 35);
            this.btnImportCompare.TabIndex = 2;
            this.btnImportCompare.Text = "Compare two imports...";
            this.btnImportCompare.UseVisualStyleBackColor = true;
            this.btnImportCompare.Click += new System.EventHandler(this.btnImportCompare_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Location = new System.Drawing.Point(6, 60);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(368, 35);
            this.btnSaveImage.TabIndex = 3;
            this.btnSaveImage.Text = "Save graph image...";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnImportKeepCurrent
            // 
            this.btnImportKeepCurrent.Location = new System.Drawing.Point(6, 101);
            this.btnImportKeepCurrent.Name = "btnImportKeepCurrent";
            this.btnImportKeepCurrent.Size = new System.Drawing.Size(368, 35);
            this.btnImportKeepCurrent.TabIndex = 3;
            this.btnImportKeepCurrent.Text = "Compare import with current...";
            this.btnImportKeepCurrent.UseVisualStyleBackColor = true;
            this.btnImportKeepCurrent.Click += new System.EventHandler(this.btnImportKeepCurrent_Click);
            // 
            // BenchmarkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BenchmarkControl";
            this.Size = new System.Drawing.Size(1177, 762);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtBenchmarkResults)).EndInit();
            this.tbcMainTabControl.ResumeLayout(false);
            this.tabBenchmark.ResumeLayout(false);
            this.tlpBenchmark.ResumeLayout(false);
            this.tlpBenchmark.PerformLayout();
            this.pnlControlButtons.ResumeLayout(false);
            this.gbxAvailableBenchmarks.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabImportExport.ResumeLayout(false);
            this.gbxImport.ResumeLayout(false);
            this.gbxExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxAvailableBenchmarks;
        private System.Windows.Forms.ListBox lbxSelectedBenchmark;
        private System.Windows.Forms.PropertyGrid prgSelectedBenchmarkProperties;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBenchmarkResults;
        private System.Windows.Forms.Panel pnlControlButtons;
        private System.Windows.Forms.Button btnStartBenchmark;
        private System.Windows.Forms.Label lblPostRunStats;
        private System.Windows.Forms.Button btnAbortBenchmark;
        private System.Windows.Forms.TabControl tbcMainTabControl;
        private System.Windows.Forms.TabPage tabBenchmark;
        private System.Windows.Forms.TableLayoutPanel tlpBenchmark;
        private System.Windows.Forms.Label lblSelectedBenchmarkName;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabImportExport;
        private System.Windows.Forms.CheckedListBox clbShownChartSeries;
        private System.Windows.Forms.GroupBox gbxExport;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox gbxImport;
        private System.Windows.Forms.Button btnImportCompare;
        private System.Windows.Forms.Button btnImportOne;
        private System.Windows.Forms.Button btnImportKeepCurrent;
    }
}
