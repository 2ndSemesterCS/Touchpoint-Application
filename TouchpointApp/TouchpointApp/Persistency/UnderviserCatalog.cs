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

        //singelton instandsfield
        private static UnderviserCatalog _UnderviserCatalog;
        #endregion

        #region Constructor
        private UnderviserCatalog()
        {
            _Ul = new List<Underviser>();
        }
        #endregion
        
        //singelton implentering  public method and private constructor
        public static UnderviserCatalog Instance()
        {
            if (_UnderviserCatalog == null)
            {
                _UnderviserCatalog = new UnderviserCatalog();

            }
            return _UnderviserCatalog;
        } 

        //propperti for getting our list.
        public List<Underviser> Getlist
        {
            get { return _Ul; }
            set { _Ul = value;}
        }

        public List<Underviser> All
        { get; set; }


        #region Metoder
        public void OpretUnderviser(string Navn, string Adresse, string email, string tlf)
        {
              Underviser U1 = new Underviser(Navn, Adresse, email, tlf);
            _Ul.Add(U1);
        }

        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }
        #endregion
    }
}


