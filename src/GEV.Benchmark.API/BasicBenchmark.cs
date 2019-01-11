using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.Benchmark.API
{
    public abstract class BasicBenchmark : IBenchmark
    {
        [Category("General"), Description("The name of the benchmark"), ReadOnly(true)]
        abstract public string Name { get; }

        [Category("General"), DisplayName("Iteration count"), Description("How many times the benchmark measurement instance should run.")]
        public virtual int IterationCount { get; set; }

        [Category("General"), DisplayName("Freerun mode"), Description("If true, disregards \"Iteration count\" property and executes benchmark until not aborted.")]
        public virtual bool Freerun { get; set; }

        [Browsable(false)]
        public virtual List<BenchmarkDataPoint> Parameters{ get; protected set; }

        [Browsable(false)]
        public virtual string PrimaryAxisTitle { get; protected set; }

        [Browsable(false)]
        public virtual string SecondaryAxisTitle { get; protected set; }

        [Browsable(false)]
        public string PrimaryAxisFormat { get; protected set; }

        [Browsable(false)]
        public string SecondaryAxisFormat { get; protected set; }

        protected int CurrentIteration;

        public BasicBenchmark()
        {
            this.IterationCount = 1500;
            this.Parameters = new List<BenchmarkDataPoint>()
            {
                new BenchmarkDataPoint("Elapsed time (ms)", false),
            };

            this.PrimaryAxisTitle = "ms";
            this.PrimaryAxisFormat = "{0} ms";
            this.SecondaryAxisTitle = "";
            this.SecondaryAxisFormat = "";
        }

        /// <summary>
        /// Starts the benchmark. Usual opeations to be done here - opening  device if needed, resetting variables to default state etc.
        /// </summary>
        public abstract void StartBenchmark();

        /// <summary>
        /// Runs an Instance of the benchmark and provides datapoints at the end.
        /// </summary>
        /// <param name="instance">Iterative count of the running instance</param>
        /// <returns></returns>
        public abstract double[] ExecuteInstance(int instance);

        /// <summary>
        /// Stops the benchmark. Will not call 
        /// </summary>
        public abstract void StopBenchmark();
    }
}
