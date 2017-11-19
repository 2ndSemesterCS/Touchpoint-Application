using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Lokale
    {

        private string _navn;
        private int _lokaleId;

        public int LokaleId { get; set; }

        public string Navn { get; set; }

        public Lokale(int lokaleId, string navn)
        {
            Navn = navn;
            LokaleId = lokaleId;
        }
    }
}
