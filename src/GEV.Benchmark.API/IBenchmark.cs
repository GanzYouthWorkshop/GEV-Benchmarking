using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.Benchmark.API
{
    public interface IBenchmark
    {
        /// <summary>
        /// Name of the benchmark.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Title displayed on the primary Y axis.
        /// </summary>
        string PrimaryAxisTitle { get; }

        /// <summary>
        /// Title displayed on the secondary Y axis.
        /// </summary>
        string SecondaryAxisTitle { get;  }

        /// <summary>
        /// String format on the primary Y axis datapoints.
        /// </summary>
        string PrimaryAxisFormat { get; }

        /// <summary>
        /// String format on the secondary Y axis datapoints.
        /// </summary>
        string SecondaryAxisFormat { get; }

        /// <summary>
        /// Expected datapoints from the ExecuteInstance() method.
        /// </summary>
        List<BenchmarkDataPoint> Parameters { get; }
     
        /// <summary>
        /// Count of instances the benchmark should run.
        /// </summary>
        int IterationCount { get; set; }

        /// <summary>
        /// If set to true - disregards the IterationCount property - the banchmark will run indfefinitely.
        /// </summary>
        bool Freerun { get; set; }

        /// <summary>
        /// Starts the banchmark.
        /// </summary>
        void StartBenchmark();

        /// <summary>
        /// Returns one set of data of the banchmark.
        /// </summary>
        /// <param name="instance">Iterative count of the instance</param>
        /// <returns></returns>
        double[] ExecuteInstance(int instance);

        /// <summary>
        /// Stops the banchmark.
        /// </summary>
        void StopBenchmark(); 
    }

}
