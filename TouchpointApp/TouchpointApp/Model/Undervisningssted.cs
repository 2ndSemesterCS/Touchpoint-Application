using System;

namespace TouchpointApp.Model
{
    public class Undervisningssted
    {
        private string _adresse;
        private string _lokale;


        public Undervisningssted(string lokale, string adresse)
        {

            if (String.IsNullOrEmpty(lokale) || String.IsNullOrEmpty(adresse))
            {
                throw new ArgumentException("Adresse eller lokale mangler");
            }

            lokale = _lokale;
            adresse = _adresse;
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
        public override string ToString()
        {
            return $"{_adresse}, {_lokale}";
        }
    }
}
