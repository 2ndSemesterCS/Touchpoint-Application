using System.Collections.Generic;
using System.Net.NetworkInformation;
using TouchpointApp.Views.Undervisningssted;
using TouchpointApp.Model;
namespace TouchpointApp.Persistency
{
    public class UndervisningsstedCatalog
    {
        #region Instance Fields
        private List<Undervisningssted> __usl;
        #endregion

        #region Constructor
        public UndervisningsstedCatalog()
        {
            __usl = new List<Undervisningssted>();
        }
        #endregion

        #region Metoder

        public void OpretUndervisningssted(string adresse, Lokale lokale)
        {
            Undervisningssted u1 = new Undervisningssted(adresse, lokale);
            __usl.Add(u1);
        }

        #endregion


    }
}