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

        private static KursusCatalog _Kursuscatalog;
        #endregion


        public static KursusCatalog Instance()
        {
            if (_Kursuscatalog == null)
            {
                _Kursuscatalog = new KursusCatalog();

            }
            return _Kursuscatalog;
        }
        #region Constructor
        private KursusCatalog()
        {
            _kl = new List<Kursus>();
        }
        #endregion

        public List<Kursus> Getlist
        {
            get { return _kl; }
            set { _kl = value; }
        }

        #region Metoder
        public void OpretKursus(string titel, DateTime dato, DateTime tidspunkt, string varighed, double pris, string sprog, string beskrivelse, double depositum,  Underviser underviser, Undervisningssted undervisningssted)
        {
            Kursus k1 = new Kursus(titel, dato, tidspunkt, varighed, pris, sprog ,beskrivelse,depositum ,underviser, undervisningssted);
            _kl.Add(k1);
        }

        public void Create()
        {

        }

        #endregion 
    }
}
