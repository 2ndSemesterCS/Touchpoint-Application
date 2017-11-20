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
<<<<<<< HEAD
        private string _tlf;
        private string _email;
        private string _adresse;

        public string Tlf{ get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        public Undervisningssted(string tlf, string email, string adresse)
        {
            _tlf = tlf;
            _email = email;
=======
        private string _adresse;
        private Lokale _lokale;
        public Undervisningssted(string adresse, Model.Lokale lokale)
        {
>>>>>>> 3b5821b60f7f252deefbee21e471d401f567c711
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
