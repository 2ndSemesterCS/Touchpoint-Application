using System.Collections.Generic;
using TouchpointApp.Model;
using System;

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

        #region Liste af kursister
        public List<Kursist> Getlist
        {
            get { return _kursistList; }
            set { _kursistList = value; }
        }
        #endregion

        #region SingleTon
        public static KursistCatalog Instance()
        {
            if(_KursistCatalog == null)
            {
                _KursistCatalog = new KursistCatalog();
            }
            return _KursistCatalog;
        }
        #endregion

        #region Metode
        public void OpretKursist(string navn, string adresse, string email, string tlf, string land, string by)
        {
            foreach (var item in _kursistList)
            {
                if (item.EMail == email)
                {
                    throw new ArgumentException("Email eksisterer allerede i systemet");
                }
            }

            Kursist kursist1 = new Kursist(navn, email, by, land, adresse, tlf);
            _kursistList.Add(kursist1);
        }
        #endregion


    }
}