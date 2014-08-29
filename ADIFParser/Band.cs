using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK4FACB.ADIFParser
{
    public class Band
    {
        public string BandName { get; set; }
        public double LowerFreqInMHz { get; set; }
        public double UpperFreqInMHz { get; set; }

        public Band(string bandName, double lowerFreqInMHz, double upperFreqInMHz)
        {
            BandName = bandName;
            LowerFreqInMHz = lowerFreqInMHz;
            UpperFreqInMHz = upperFreqInMHz;
        }
    }
}
