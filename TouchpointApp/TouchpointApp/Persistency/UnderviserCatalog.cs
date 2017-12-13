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

        //singelton instancesfield
        private static UnderviserCatalog _UnderviserCatalog;
        #endregion

        #region Constructor
        private UnderviserCatalog()
        {
            _Ul = new List<Underviser>();
            _Ul.Add(new Underviser("Jonas", "Kildevej 19", "Jonaspedersen@live.dk", "11223344"));  //Hard coded objeket. 
        }
        #endregion

        #region Singleton
        //singelton implentering  public method and private constructor
        public static UnderviserCatalog Instance()
        {
            if (_UnderviserCatalog == null)
            {
                _UnderviserCatalog = new UnderviserCatalog();

            }
            return _UnderviserCatalog;
        }
        #endregion

        #region Property for at modtage vores liste
        public List<Underviser> Getlist
        {
            get { return _Ul; }
            set { _Ul = value;}
            
        }
        #endregion

        #region Liste af Undervisere
        public List<Underviser> All
        { get; set; }
        #endregion

        #region Metoder
        public void OpretUnderviser(string Navn, string Adresse, string email, string tlf)
        {
            foreach (var item in Getlist)
            {
               if( item.Email == email)
                {
                    throw new ArgumentException("Email eksisterer allerede i systemet");
                }
            }
              Underviser U1 = new Underviser(Navn, Adresse, email, tlf);
            _Ul.Add(U1);
        }
        #endregion
    }
}


