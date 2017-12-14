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

        #region Singleton
        public static KursusCatalog Instance()
        {
            if (_Kursuscatalog == null)
            {
                _Kursuscatalog = new KursusCatalog();

            }
            return _Kursuscatalog;
        }
        #endregion

        #region Constructor
        private KursusCatalog()
        {
            _kl = new List<Kursus>();
           // _kl.Add(new Kursus("Fodterapi", new DateTime(2018, 02, 29), new DateTime(2018, 02, 29, 16, 30, 00), "2 Timer", 10000, "Dansk", "Dette er et kursus om fodterapi", 1000, new Underviser("John", "FugleBakken 4", "John@post9.tele.dk", "44957212"), new Undervisningssted("B112", "Jernbanegade 4")));
        }
        #endregion

        #region Liste af kurser
        public List<Kursus> Getlist
        {
            get { return _kl; }
            set { _kl = value; }
        }
        #endregion

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
