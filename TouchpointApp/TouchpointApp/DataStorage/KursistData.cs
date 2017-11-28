using TouchpointApp.Persistency;
using TouchpointApp.ViewModel;
namespace TouchpointApp.DataStorage
{
    public class KursistData : ViewModelBase
    {
        #region Instance Fields
        
        private string _email;
        private string _tlf;
        private string _navn;

#endregion


        public KursistData ()
        {

        }

        #region Properties

        public string Email { get { return _email; } set { _email = value; OnPropertyChanged("Email"); } }

        public string Navn { get { return _navn; } set { _navn = value; OnPropertyChanged("navn"); } }
       
        public string Tlf { get { return _tlf; } set { _tlf = value; OnPropertyChanged("tlf"); } }
        //public string Email
        //{
        //    get
        //    {
        //        return _kursist.EMail;
        //    }
        //    set
        //    {
        //        _kursist.EMail = value;

        //    }
        //}

        //public string Telefon
        //{
        //    get { return _kursist.Tlf; }
        //    set
        //    {
        //        _kursist.Tlf = value;

        //    }
        //}

        //public string Navn
        //{
        //    get { return _kursist.Navn; }
        //    set
        //    {
        //        _kursist.Navn = value;
        //        ;
        //    }
        //}

    }
#endregion
}