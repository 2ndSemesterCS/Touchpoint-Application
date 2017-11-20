using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Undervisningssted(string adresse )
        {
>>>>>>> 3b5821b60f7f252deefbee21e471d401f567c711
            _adresse = adresse;
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
    }
}
