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

    public class UnderviserCatalog : WebAPICatalog<Underviser>
    {
        #region Instance Fields

        //singelton instancesfield
        private static UnderviserCatalog _UnderviserCatalog;
        #endregion

        #region Constructor
        private UnderviserCatalog(string url)
            : base(url, "Underviser")
        {
            //_Ul = new List<Underviser>();
            //_Ul.Add(new Underviser("Jonas", "Kildevej 19", "Jonaspedersen@live.dk", "11223344"));  //Hard coded objeket. 
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


        #region Liste af Undervisere
        public List<Underviser> All
        { get; set; }
        #endregion

        #region Metoder
        public void OpretUnderviser(string Navn, string Adresse, string email, string tlf)
        {
            foreach (var item in All)
            {
               if( item.Email == email)
                {
                    throw new ArgumentException("Email eksisterer allerede i systemet");
                }
            }
            
            
        }
        #endregion
    }
}


