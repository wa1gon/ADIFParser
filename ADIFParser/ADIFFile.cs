using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK4FACB.ADIFParser
{
    public class ADIFFile
    {
        /// <summary>
        /// The contacted statoin's mailing address.
        /// </summary>
        public string ADDRESS { get; set; }

        /// <summary>
        /// Version of ADIF format.
        /// </summary>
        public string ADIF_VER { get; set; }

        /// <summary>
        /// The contacted station operator's age in years.
        /// </summary>
        public Int16 AGE { get; set; }

        /// <summary>
        /// The geomagnetic A index at the time of the QSO.
        /// </summary>
        public int A_INDEX { get; set; }

        public int ANT_AZ { get; set; }
        public int ANT_EL { get; set; }
        public AntPath ANT_PATH { get; set; }
        public ARRLSection ARRL_SECT { get; set; }
        public Band BAND { get; set; }
        public Band BAND_RX { get; set; }

        /// <summary>
        /// The contacted station's callsign.
        /// </summary>
        public string CALL { get; set; }
        public string CHECK { get; set; }
        public string CLASS { get; set; }

        /// <summary>
        /// Date on which the QSO started.
        /// </summary>
        public DateTime QSO_DATE { get; set; }

        /// <summary>
        /// Date on which the QSO ended.
        /// </summary>
        public DateTime QSO_DATE_OFF { get; set; }

        public Int16 TX_POWER { get; set; }


        /// <summary>
        /// Import an ADIF file.
        /// </summary>
        /// <param name="filename">Filename to import form.</param>
        /// <returns>True if imported successfully.</returns>
        public Boolean ImportFromFile(string filename)
        {
            return true;
        }

        /// <summary>
        /// Export the ADIF file.
        /// </summary>
        /// <param name="filename">Filename to export to.</param>
        /// <returns>True if exported successfully.</returns>
        public Boolean ExportToFile(string filename)
        {
            return true;
        }
    }
}
