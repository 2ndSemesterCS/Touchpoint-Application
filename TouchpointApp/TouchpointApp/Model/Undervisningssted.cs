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
        private int _undervisningsstedID;

        public string Tlf{ get; set; }
        public string Email { get; set; }
        public string Adressse { get; set; }
        public int UndervisningsstedID { get; set; }

        public Undervisningssted(string Tlf, string Email, string Adresse, int UndervisningsstedID)
        {
            Tlf = _tlf;
            Email = _email;
            Adresse = _adresse;
            UndervisningsstedID = _undervisningsstedID;
        }

    }
}
