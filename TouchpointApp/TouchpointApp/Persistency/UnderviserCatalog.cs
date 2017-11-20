using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class UnderviserCatalog
    {

       

        #region Instance fields

        public Dictionary<int, Model.Underviser> _Dictionary;
        #endregion

        #region Constructor
        public UnderviserCatalog()
        {
            _Dictionary = new Dictionary<int, Underviser>();
        }
        #endregion

        #region Metoder
        public void OpretUnderviser(string navn, string addresse, string email, string tlf)
        {
            //dictionary(key, value) 
            Underviser underviser = new Underviser(navn, addresse, email, tlf);   //A underviser is created
        }
        #endregion



    }
}
