using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Lokale
    {

        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public Lokale(string navn)
        {
            Navn = navn;
        }
    }
}
