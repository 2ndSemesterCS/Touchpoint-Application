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

        public void OpretUndervisningssted(string tlf, string email, string adresse)
        {
            Undervisningssted u1 = new Undervisningssted(tlf, email, adresse);
            __usl.Add(u1);
        }

        #endregion


    }
}