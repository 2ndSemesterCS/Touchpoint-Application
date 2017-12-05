using System.Collections.Generic;
using System.Net.NetworkInformation;
using TouchpointApp.Views.Undervisningssted;
using TouchpointApp.Model;
using TouchpointApp.Persistency;
using System;


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

        public void OpretUndervisningssted(string lokale, string adresse)
        {
            Undervisningssted us1 = new Undervisningssted(lokale, adresse);


            { 
                __usl.Add(us1);
            }
            
        }

        #endregion


    }


