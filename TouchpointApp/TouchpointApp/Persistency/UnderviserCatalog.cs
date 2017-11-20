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
<<<<<<< HEAD:TouchpointApp/TouchpointApp/Persistency/UnderviserCatelog.cs
        #region Instq andfields
=======
        #region Instance fields
>>>>>>> 43ac465f420b1b11c7b5734f4dfc2a3294231db4:TouchpointApp/TouchpointApp/Persistency/UnderviserCatalog.cs
        public Dictionary<int, Model.Underviser> _Dictionary;
        #endregion

        #region Constructor
        public UnderviserCatalog()
        {
            _Dictionary = new Dictionary<int, Underviser>();
        }
        #endregion

        #region Metoder
        public void OpretUnderviser(string navn, string addresse, string email)
        {
            //dictionary(key, value) 
            Underviser underviser = new Underviser(navn, addresse, email);   //A underviser is created
            _Dictionary.Add(underviser.UnderviserId, underviser);            //Adding the underviser to a dictionary
        }
        #endregion



    }
}
