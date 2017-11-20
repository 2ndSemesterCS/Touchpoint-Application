using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class KursusCatalog
    {
        #region Instance Fields
        private List<Kursus> _kl;
        #endregion

        #region Constructor
        public KursusCatalog()
        {
            _kl = new List<Kursus>();
        }
        #endregion

        #region Metoder
        public void OpretKursus(string titel, string dato, string tidspunkt, string varighed, 
            double pris, Underviser underviser, Undervisningssted undervisningssted, string sprog, string beskrivelse, double depositum)
        {
            Kursus k1 = new Kursus(titel, dato, tidspunkt, varighed, pris, underviser, undervisningssted, sprog, beskrivelse, depositum);
            _kl.Add(k1);
        }
        #endregion 
    }
}
