using System;
using TouchpointApp.DataStorage;

namespace TouchpointApp.Model
{
    public class Kursist : IKey
    {
        #region Instance Fields
        private int _kursistID;
        private string _navn;
        private string _email;
        private string _by;
        private string _land;
        private string _adresse;
        private string _tlf;
        #endregion


       #region Properties

        //Nøglen som vi får fra vores Interface
        public int Key
        {
            get { return _kursistID; }
            set { _kursistID = value; }
        }

        // en propperty vi bruger til at gemme KursistID (som kommer fra databasen) 
         public int KursistID
        {
            get { return _kursistID; }
            set { _kursistID = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }

        public string By
        {
            get { return _by; }
            set { _by = value; }
        }

        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }
     
        #endregion


        #region Constructor

        public Kursist(string navn, string adresse, string email, string tlf, string land, string by)
        {
            if (String.IsNullOrEmpty(navn) || String.IsNullOrEmpty(email)
                || String.IsNullOrEmpty(by) || String.IsNullOrEmpty(land)
                || String.IsNullOrEmpty(adresse) || String.IsNullOrEmpty(tlf))
            {
                throw new ArgumentException("Personlig information mangler");
            }


            CheckForTal(navn, by, land);
            CheckForTalITlf(tlf);

            _navn = navn;
            _email = email;
            _by = by;
            _land = land;
            _adresse = adresse;
            _tlf = tlf;
        }
        #endregion

        #region Metoder med exceptions
        public void CheckForTal(string navn, string by, string land)
        {
            int value;


            if (int.TryParse(navn, out value))

            {
                throw new ArgumentException("Der kan ikke indtastes tal i navn");
            }

            if (int.TryParse(by, out value))
            {
                throw new ArgumentException("Der kan ikke indtastes tal i by");
            }

            if (int.TryParse(land, out value))
            {
                throw new ArgumentException("Der kan ikke indtastes tal i land");
            }

        }

        public void CheckForTalITlf(string Tlf)
        {
            int value;
            if (!int.TryParse(Tlf, out value))
            {
                throw new ArgumentException("Kun tal i telefonnummer");
            }
        }

        #endregion

        #region Metode Tostring
        public override string ToString()
        {
            return $"{_navn}";
        }
        #endregion

       
    }
}