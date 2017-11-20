using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Serie
    {

        public Kursus Kursus { get; set; }
        public string Beskrivelse { get; set; }

        public Serie(Kursus kursus, string beskrivelse)
        {
            Kursus = kursus;
            Beskrivelse = beskrivelse;
        }
    }
}
