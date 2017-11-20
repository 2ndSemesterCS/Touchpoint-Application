using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.Model
{
    public class Undervisningssted
    {
        private string _adresse;
        private Lokale _lokale;


        public Undervisningssted(Lokale lokale, string adresse)
        {
          
          _lokale = lokale;
            _adresse = adresse;
        }


      
        public Undervisningssted(string adresse, Model.Lokale lokale)
        {
            _adresse = adresse;
            _lokale = lokale;
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public Lokale Lokale
        {
            get { return _lokale; }
            set { _lokale = value; }
        }
    }
}
