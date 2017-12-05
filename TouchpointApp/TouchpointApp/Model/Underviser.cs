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
            if(String.IsNullOrEmpty(navn))
            {
                throw new ArgumentException("Navn mangler");
            }
            if (String.IsNullOrEmpty(addresse))
            {
                throw new ArgumentException("Adresse mangler");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email mangler");
            }
            if (String.IsNullOrEmpty(tlf))
            {
                throw new ArgumentException("Telefonnummer mangler");
            }
            _navn = navn;
            _addresse = addresse;
            _email = email;
            _tlf = tlf;
        }

        public Underviser()
        {
            throw new NotImplementedException();
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
