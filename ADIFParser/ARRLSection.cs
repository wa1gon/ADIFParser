using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK4FACB.ADIFParser
{
    public class ARRLSection
    {
        public string Abbreviation { get; set; }
        public string Section { get; set; }

        public ARRLSection(string abbreviation, string section)
        {
            Abbreviation = abbreviation;
            Section = section;
        }
    }
}
