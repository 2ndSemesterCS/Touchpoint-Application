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
            _navn = navn;
            _addresse = addresse;
            _email = email;
            _tlf = tlf;
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
