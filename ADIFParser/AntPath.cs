using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK4FACB.ADIFParser
{
    public class AntPath
    {
        public Char Abbreviation { get; set; }
        public string Meaning { get; set; }

        public AntPath(char abbreviation, string meaning)
        {
            Abbreviation = abbreviation;
            Meaning = meaning;
        }
    }
}
