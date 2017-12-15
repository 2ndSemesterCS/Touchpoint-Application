using System;

namespace TouchpointApp.Model
{
    public class Underviser : IKey
    {
        #region Instance fields
        private string _navn;
        private string _adresse;
        private string _email;
        private string _tlf;

        private int _underviserID;
        #endregion

        #region Constructor
        public Underviser(string navn, string adresse, string email, string tlf)
        {
            //if(String.IsNullOrEmpty(navn) || String.IsNullOrEmpty(addresse) 
            //    || String.IsNullOrEmpty(email) || string.IsNullOrEmpty(tlf))
            //{
            //    throw new ArgumentException("Personlig information mangler");
               
            //}

            //CheckForTal(navn);
            //CheckTlfLængde(tlf);
            //CheckForTalITlf(tlf);

            _navn = navn;
            _adresse = adresse;
            _email = email;
            _tlf = tlf;
        }
        #endregion

        //#region Metoder med exceptions
        //public void CheckForTalITlf(string Tlf)
        //{
        //    int value;
        //    if (!int.TryParse(Tlf, out value))
        //    {
        //        throw new ArgumentException("Kun tal i telefonnummer");
        //    }
        //}

        //public void CheckForTal(string navn)
        //{
        //    int value;

        //    if (int.TryParse(navn, out value))

        //    {
        //        throw new ArgumentException("Der kan ikke indtastes tal i navn");
        //    }
        //}

        //public void CheckTlfLængde(string tlf)
        //{

        //    if (tlf.Length < 8 || tlf.Length > 8)
        //    {
        //        throw new ArgumentException("Invalid telefonnummer");
        //    }

        //}
        //#endregion

        #region Properties
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        public int Key
        {
            get { return _underviserID; }
            set { _underviserID = value; }
        }
        public int UnderviserID
        {
            get { return _underviserID; }
            set { _underviserID = value; }
        }
        #endregion

        #region ToString metode
        public override string ToString()
        {
            return $"{_navn}";
        }
        #endregion

      
    }
}
