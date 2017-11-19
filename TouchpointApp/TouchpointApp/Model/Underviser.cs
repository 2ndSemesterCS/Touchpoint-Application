using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;

namespace TouchpointApp.Model
{
    public class Underviser
    {
        private int _undervisningsid;
        private string _navn;
        private string _addresse;
        private string _email;

        public Underviser(string navn, string addresse, string email, int underviserId)
        {
            _undervisningsid = underviserId;
            _navn = navn;
            _addresse = addresse;
            _email = email;
        }

        public int UnderviserId
        {
            get { return _undervisningsid; }
            set { _undervisningsid = value; }
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


       



    }
}
