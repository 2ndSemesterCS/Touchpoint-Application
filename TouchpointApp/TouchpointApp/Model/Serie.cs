using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Serie
    {
        private int _serieId;
        private Kursus _kursus;
        private string _beskrivelse;

        public int SerieID { get; set; }
        public Kursus Kursus { get; set; }
        public string Beskrivelse { get; set; }

        public Serie(int SerieID, Kursus Kursus, string Beskrivelse)
        {
            SerieID = _serieId;
            Kursus = _kursus;
            Beskrivelse = _beskrivelse;
        }
    }
}
