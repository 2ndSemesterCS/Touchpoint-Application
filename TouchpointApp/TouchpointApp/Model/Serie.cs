using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Serie
    {
        private Kursus _kursus;
        private string _beskrivelse;


        public Kursus Kursus
        {
            get { return _kursus; }
            set { _kursus = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public Serie(Kursus kursus, string beskrivelse)
        {
            _kursus = kursus;
            _beskrivelse = beskrivelse;
        }
    }
}
