using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Kursisten
    {
        private string _navn;
        private string _telefon;
        private string _email;
        private int _kursistId;

        public int KursistId { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string Navn { get; set; }


        public Kursisten(int kursistId, string telefon, string email, string navn)
        {
            Telefon = telefon;
            KursistId = kursistId;
            Email = email;
            Navn = navn;

        }
    }
}

