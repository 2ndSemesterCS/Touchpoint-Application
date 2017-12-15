using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.Model
{
    public class Serie : IKey
    {
        private List<Kursus> _kursusSerie;
        private string _beskrivelse;

        private int _serieID;


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
        public int Key
        {
            get { return _serieID; }
            set { _serieID = value; }
        }
        public int SerieID
        {
            get { return _serieID; }
            set { _serieID = value; }
        }



        public Serie(List<Kursus> kursusSerie, string beskrivelse)
        {
            if(String.IsNullOrEmpty(beskrivelse) || kursusSerie == null)
            {
                throw new ArgumentException("Intet kursus er valgt og information mangler");
            }
            _kursusSerie = kursusSerie;
            _beskrivelse = beskrivelse;
        }

        public override string ToString()
        {
            return $"{_beskrivelse}";
        }
    }
}
