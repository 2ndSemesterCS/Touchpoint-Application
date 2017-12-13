
using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class KursistData : ViewModelBase
    {
        #region Instance Fields
        private string _email;
        private string _tlf;
        private string _navn;
        private string _by;
        private string _land;
        private string _adresse;
        #endregion

        #region Constructor
        public KursistData ()
        {

        }
        #endregion

        #region Properties

        public string Email { get { return _email; } set { _email = value; OnPropertyChanged("Email"); } }

        public string Navn { get { return _navn; } set { _navn = value; OnPropertyChanged("navn"); } }
       
        public string Tlf { get { return _tlf; } set { _tlf = value; OnPropertyChanged("tlf"); } }

        public string By { get { return _by; } set { _by = value; OnPropertyChanged("by"); } }

        public string Land { get { return _land; } set { _land = value; OnPropertyChanged("land"); } }

        public string Adresse { get { return _adresse; } set { _adresse = value; OnPropertyChanged("adresse"); } }
    }
#endregion
}