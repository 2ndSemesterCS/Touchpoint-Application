using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.DataStorage
{
    class LokaleData
    {
        #region Instance Fields
        private string _navn;
        #endregion

         #region Properties
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        #endregion
    }
}
