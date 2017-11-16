using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Serie
    {

        public int SerieID { get ; set; }
        public Kursus Kursus { get; set; }
        public string Beskrivelse { get; set; }

        public Serie(int serieId, Kursus kursus, string beskrivelse)
        {
            SerieID = serieId;
            Kursus = kursus;
            Beskrivelse = beskrivelse;
        }
    }
}
