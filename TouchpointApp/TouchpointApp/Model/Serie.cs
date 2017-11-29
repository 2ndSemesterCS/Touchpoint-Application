﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Serie
    {
        private List<Kursus> _kursusSerie;
        private string _beskrivelse;


        public List<Kursus> KursusSerie
        {
            get { return _kursusSerie; }
            set { _kursusSerie = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public Serie(List<Kursus> kursusSerie, string beskrivelse)
        {
            _kursusSerie = kursusSerie;
            _beskrivelse = beskrivelse;
        }
    }
}
