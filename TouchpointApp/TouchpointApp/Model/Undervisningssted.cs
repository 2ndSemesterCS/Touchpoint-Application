using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Undervisningssted
    {
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
            _adresse = adresse;
        }

    }
}
