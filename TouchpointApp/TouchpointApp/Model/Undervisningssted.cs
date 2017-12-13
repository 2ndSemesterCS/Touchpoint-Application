using System;

namespace TouchpointApp.Model
{
    public class Undervisningssted
    {
        #region Instance fields
        private string _adresse;
        private string _lokale;
        #endregion

        #region Constructor
        public Undervisningssted(string lokale, string adresse)
        {
             // skaber problemer når man skal slette et objekt igen.
            //if (String.IsNullOrEmpty(lokale) || String.IsNullOrEmpty(adresse))
            //{
            //    throw new ArgumentException("Adresse eller lokale mangler");
            //}

            _lokale = lokale;
            _adresse = adresse;
        }
        #endregion

        #region Properties
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
        #endregion

        #region ToString Metode
        public override string ToString()
        {
            return $"{_adresse}, {_lokale}";
        }
        #endregion

    }
}
