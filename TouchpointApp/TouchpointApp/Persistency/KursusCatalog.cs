using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class KursusCatalog
    {
        #region Instance Fields
        private List<Kursus> _kc;
        #endregion

        #region Constructor
        public KursusCatalog()
        {
            _kc = new List<Kursus>();
        }
        #endregion

        #region Metoder
        public void OpretKursus(string titel, string dato, string tidspunkt, string varighed, double pris, Underviser underviser, Undervisningssted undervisningssted)
        {
            Kursus _k1 = new Kursus(titel, dato, tidspunkt, varighed, pris, underviser, undervisningssted);
            _kc.Add(_k1);
        }
        #endregion 
    }
}
