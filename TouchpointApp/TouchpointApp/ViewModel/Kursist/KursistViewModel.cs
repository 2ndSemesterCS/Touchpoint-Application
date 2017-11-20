using TouchpointApp.Command;
using TouchpointApp.Persistency;
using TouchpointApp.Model;

namespace TouchpointApp.ViewModel.Kursist
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields


        private Model.Kursist _kursist;
        private KursistCatalog _kursistCatalog;

        #endregion

        #region Properties
        public string Email
        {
            get { return _kursist.EMail; }
            set
            {_kursist.EMail = value;
                OnPropertyChanged("Email");
            }
        }

        public string Telefon
        {
            get { return _kursistTlf; }
            set
            {
                _kursistTlf = value;
                OnPropertyChanged("Telefon");
            }
        }

        public string Navn
        {
            get { return _kursistNavn; }
            set { _kursistNavn = value;
                OnPropertyChanged("Navn"); }
        }

        #endregion

        #region Commands
        public RelayCommand OpretNyKursistCommand { get; set; }
        #endregion

        #region Constructor

        public KursistViewModel()
        {
            _kursistCatalog = new KursistCatalog();
            OpretNyKursistCommand = new RelayCommand(OpretNyKursist);
        }
        #endregion

        #region Metoder

        public void OpretNyKursist()
        {
            _kursistCatalog.OpretKursist(Navn, Email, Telefon);
        }

        #endregion
    }
}
