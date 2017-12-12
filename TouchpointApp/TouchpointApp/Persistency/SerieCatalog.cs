using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    class SerieCatalog
    {
        #region Instance fields
        private List<Serie> _sl;

        private static SerieCatalog _SerieCatalog;

        #endregion

        public static SerieCatalog Instance()
        {
            if(_SerieCatalog == null)
            {
                _SerieCatalog = new SerieCatalog();
            }
            return _SerieCatalog;
        }

        #region Constructor
        private SerieCatalog()
        {
            _sl = new List<Serie>();
        }
        #endregion

        public List<Serie> GetList
        {
            get { return _sl; }
            set { _sl = value; }
        }

        #region Metode
        public void OpretSerie(List<Kursus> kursusSerie, string beskrivelse)
        {
            Serie s1 = new Serie(kursusSerie, beskrivelse);
            _sl.Add(s1);
        }

        public void Create()
        {

        }
        #endregion
    }
}
