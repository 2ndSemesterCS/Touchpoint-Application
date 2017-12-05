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
        private string _lokale;


        public Undervisningssted(string lokale, string adresse)
        {
            if( String.IsNullOrEmpty(lokale) || adresse == null)
            {
                throw new ArgumentException("Name must contain at least two characters");
            }
          
            _lokale = lokale;
            _adresse = adresse;
        }
   

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Lokale
        {
            get { return _lokale; }
            set { _lokale = value; }
        }
    }
}
