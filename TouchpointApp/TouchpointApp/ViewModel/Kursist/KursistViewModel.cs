using TouchpointApp.Command;
using TouchpointApp.Persistency;
using TouchpointApp.Model;
using TouchpointApp.DataStorage;

namespace TouchpointApp.ViewModel.Kursist
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields

        private KursistCatalog _kc;
        private KursistData _kd;

        private Model.Kursist _kursist;
        private KursistCatalog _kursistCatalog;

        #endregion

        #region Properties
        public string Email
        {
            get
            {
                return _kursist.EMail;
            }
            set
            {_kursist.EMail = value;
                OnPropertyChanged("Email");
            }
        }

        public string Telefon
        {
            get { return _kursist.Tlf; }
            set
            {
                _kursist.Tlf = value;
                OnPropertyChanged("Telefon");
            }
        }

        public string Navn
        {
            get { return _kursist.Navn; }
            set { _kursist.Navn = value;
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
            _kd = new KursistData();

            OpretNyKursistCommand = new RelayCommand(OpretNyKursist);
        }
        #endregion

        #region Metoder

        public void OpretNyKursist()
        {
            _kc.OpretKursist(_kd.Navn,_kd.Email,_kd.Telefon);
        }

        #endregion
    }
}
