using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
<<<<<<< HEAD
   public class Serie
=======
    public class Serie
>>>>>>> edc27d607db0a48d9ecf25ff32f45bad1c4e7f37
    {
        private List<Kursus> _kursusSerie;
        private string _beskrivelse;


        public List<Kursus> KursusSerie
        {
            get { return _kursusSerie; }
            set { _kursusSerie = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public Serie(List<Kursus> kursusSerie, string beskrivelse)
        {
            _kursusSerie = kursusSerie;
            _beskrivelse = beskrivelse;
        }
    }
}
