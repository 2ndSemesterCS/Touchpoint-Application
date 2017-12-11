using System.Collections.Generic;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class KursistCatalog
    {

        #region Instance Field
        private List<Kursist> _kursistList;

        private static KursistCatalog _KursistCatalog;
        #endregion


        #region Constructor

        public KursistCatalog()
        {
            _kursistList = new List<Kursist>();
        }
        #endregion

        public List<Kursist> Getlist
        {
            get { return _kursistList; }
            set { _kursistList = value; }
        }

        public static KursistCatalog Instance()
        {
            if(_KursistCatalog == null)
            {
                _KursistCatalog = new KursistCatalog();
            }
            return _KursistCatalog;
        }


        public void OpretKursist(string navn, string adresse, string email, string tlf, string land, string by)
        {
            Kursist kursist1 = new Kursist(navn, email, by, land, adresse, tlf);
            _kursistList.Add(kursist1);
        }

    }
}