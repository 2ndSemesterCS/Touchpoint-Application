using TouchpointApp.Persistency;
namespace TouchpointApp.DataStorage
{
    public class KursistData
    {
        #region Instance Fields

        private Model.Kursist _kursist;
        private KursistCatalog _kursistCatalog;
        private string _email;
        private string _tlf;
        private string _navn;

#endregion

        #region Properties
        public string Email
        {
            get
            {
                return _kursist.EMail;
            }
            set
            {
                _kursist.EMail = value;
             
            }
        }

        public string Telefon
        {
            get { return _kursist.Tlf; }
            set
            {
                _kursist.Tlf = value;
                
            }
        }

        public string Navn
        {
            get { return _kursist.Navn; }
            set
            {
                _kursist.Navn = value;
                ;
            }
        }

    }
#endregion
}