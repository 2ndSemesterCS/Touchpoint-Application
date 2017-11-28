using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class UnderviserCatalog
    {
        #region Instance Fields
        private List<Underviser> _Ul;
        #endregion

        #region Constructor
        public UnderviserCatalog()
        {
            _Ul = new List<Underviser>();

        }
        #endregion

        #region Metoder
        public void OpretKursus(string Navn, string Adresse, string email, string tlf)
        {
              Underviser U1 = new Underviser(Navn, Adresse, email, tlf);
            _Ul.Add(U1);
        }
        #endregion
    }
}


