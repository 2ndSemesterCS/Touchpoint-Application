using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{

    public class UnderviserCatalog : Catalog<Underviser>
    {
        #region Instance Fields

        //singelton instancesfield
        private static UnderviserCatalog _UnderviserCatalog;
        #endregion

        #region Constructor
        private UnderviserCatalog(string url) : base(url, "Undervisers")
        {

        }
        #endregion

        #region Singleton
        //singelton implentering  public method and private constructor
        public static UnderviserCatalog Instance()
        {
            if (_UnderviserCatalog == null)
            {
                _UnderviserCatalog = new UnderviserCatalog("http://touchpointdbwebservice.azurewebsites.net");

            }
            return _UnderviserCatalog;
        }
        #endregion
    }
}



