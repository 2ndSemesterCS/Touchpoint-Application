using System;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class KursusCatalog : Catalog<Kursus>
    {
        #region Instance Fields
        private static KursusCatalog _kursuscatalog;
        #endregion

        #region Singleton
        public static KursusCatalog Instance()
        {
            if (_kursuscatalog == null)
            {
                _kursuscatalog = new KursusCatalog("http://touchpointdbwebservice.azurewebsites.net");

            }
            return _kursuscatalog;
        }
        #endregion

        #region Constructor
        private KursusCatalog(string url) : base(url, "Kursus")
        {
        }
        #endregion


        #region Metoder
        public void OpretKursus(string titel, DateTime dato, DateTime tidspunkt, string varighed, double pris, string sprog, string beskrivelse, double depositum,  Underviser underviser, Undervisningssted undervisningssted)
        {
            Create(new Kursus(titel, dato, tidspunkt, varighed, pris, sprog, beskrivelse, depositum, underviser, undervisningssted));
        }
        #endregion 
    }
}
