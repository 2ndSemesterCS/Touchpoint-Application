using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Underviser
    {
        public int UnderviserId { get; set; }

        public string Navn { get; set; }


        public Underviser(string navn, int underviserId)
        {
            UnderviserId = underviserId;
            Navn = navn;
        }



    }
}
