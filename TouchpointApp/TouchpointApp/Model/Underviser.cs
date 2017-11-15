using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    class Underviser
    {
        private string _navn;
        private int _underviserId;


        public int UnderviserId { get; set; }

        public string navn { get; set; }




        public Underviser(string navn, int UnderviserId)
        {
            UnderviserId = _underviserId;
            navn = _navn;
        }



    }
}
