using System;

namespace TouchpointApp.Model
{
    public class Underviser 
    {
        private string _navn;
        private string _addresse;
        private string _email;
        private string _tlf;

        public Underviser(string navn, string addresse, string email, string tlf)
        {
            if(String.IsNullOrEmpty(navn) || String.IsNullOrEmpty(addresse) 
                || String.IsNullOrEmpty(email) || string.IsNullOrEmpty(tlf))
            {
                throw new ArgumentException("Personlig information mangler");
               
            }

            CheckForTal(navn);
            CheckTlfLængde(tlf);
            
            _navn = navn;
            _addresse = addresse;
            _email = email;
            _tlf = tlf;
        }

        public void CheckForTal(string navn)
        {
            int value;

            if (int.TryParse(navn, out value))

            {
                throw new ArgumentException("Der kan ikke indtastes tal i navn");
            }
        }

        public void CheckTlfLængde(string tlf)
        {
            
            if (tlf.Length < 8 || tlf.Length > 8)
            {
                throw new ArgumentException("Invalid telefonnummer");
            }

                
        }

       

       
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Addresse
        {
            get { return _addresse; }
            set { _addresse = value; }
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
    }
}
