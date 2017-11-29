using System.Collections.Generic;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class KursistCatalog
    {

        #region Instance Field
        private List<Kursist> _kursistList;
        #endregion


        #region Constructor

        public KursistCatalog()
        {
            _kursistList = new List<Kursist>();
        }
        #endregion


        public void OpretKursist(string navn, string email, string by, string land, string adresse, string tlf)
        {
            Kursist kursist1 = new Kursist(navn, email, by, land, adresse, tlf);
            _kursistList.Add(kursist1);
        }

    }
}