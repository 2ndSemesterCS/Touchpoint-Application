using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Underviser
    {
        public int UnderviserId { get; set; }

        public string Navn { get; set; }
        public string Addresse { get; set; }
        public string Email { get; set; }


        public Underviser(string navn, string addresse, string email, int underviserId)
        {
            UnderviserId = underviserId;
            Navn = navn;
            Addresse = addresse;
            Email = email;
        }



    }
}
