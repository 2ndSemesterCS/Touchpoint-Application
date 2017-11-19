using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    class UnderviserCatelog
    {
        #region Instqandfields
        public Dictionary<int, Model.Underviser> _Dictionary;
        #endregion

        #region MyRegion
        public UnderviserCatelog()
        {
            _Dictionary = new Dictionary<int, Underviser>();
        }
        #endregion

        #region MyRegion
        public void OpretUnderviser(string navn, string addresse, string email)
        {
            //dictionary(key, value) 
            Underviser underviser = new Underviser(navn, addresse, email);   //A underviser is created
            _Dictionary.Add(underviser.UnderviserId, underviser);            //Adding the underviser to a dictionary
        }
        #endregion



    }
}
