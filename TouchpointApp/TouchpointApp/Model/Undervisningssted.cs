using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Undervisningssted
    {
        private string _adresse;
        public Undervisningssted(string adresse )
        {
            _adresse = adresse;
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
    }
}
