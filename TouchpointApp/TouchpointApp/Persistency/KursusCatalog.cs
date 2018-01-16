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


    }
}
