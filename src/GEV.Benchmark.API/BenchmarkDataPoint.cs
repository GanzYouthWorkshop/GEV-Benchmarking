using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.Benchmark.API
{
    public class BenchmarkDataPoint
    {
        public string Name { get; set; }
        public bool UsesSecondaryAxis { get; set; }

        public BenchmarkDataPoint(string name, bool secondaryAxis)
        {
            this.Name = name;
            this.UsesSecondaryAxis = secondaryAxis;
        }
    }
}
