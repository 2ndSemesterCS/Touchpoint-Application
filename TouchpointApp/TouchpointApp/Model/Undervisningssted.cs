using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Undervisningssted
    {
        public string Tlf{ get; set; }
        public string Email { get; set; }
        public string Adressse { get; set; }
        public int UndervisningsstedID { get; set; }

        public Undervisningssted(string tlf, string email, string adresse, int undervisningsstediD)
        {
            Tlf = tlf;
            Email = email;
            Adressse = adresse;
            UndervisningsstedID = undervisningsstediD;
        }

    }
}
