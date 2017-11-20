using TouchpointApp.Command;
using TouchpointApp.Persistency;
using TouchpointApp.Model;
using TouchpointApp.ViewModel;
using TouchpointApp.Views;

namespace TouchpointApp.ViewModel
{
    public class UnderviserViewModel : ViewModelBase
    {
        #region Instandsfields

        //Referance to our underviser class, need it for our propperties in the viewmodel.
        private Model.Underviser _underviser;
        private UnderviserCatalog _underviserCatalog;

        private RelayCommand _relayCommand;

        #endregion


        #region Constructor
        public UnderviserViewModel()
        {
            _underviserCatalog = new UnderviserCatalog();
            _relayCommand = new RelayCommand(OpretUnderviser);

        }
        #endregion

        public void OpretUnderviser()
        {
          _underviserCatalog.OpretUnderviser(Navn, Addresse, Email, Tlf);
        }

        #region RelayCommand propperties
        public RelayCommand OpretNytKursusCommand
        {
            get { return _relayCommand; }
        }
        #endregion

        #region Propperties For Navn, Addresse, Email Og Id 
        public string Navn
        {
            get { return _underviser.Navn; }
            set
            {
                _underviser.Navn = value;
                OnPropertyChanged("Navn opdateret");
            }
        }

        public string Addresse
        {
            get { return _underviser.Addresse; }
            set
            {
                _underviser.Addresse = value;
                OnPropertyChanged("Addresse opdateret");
            }
        }
        public string Email
        {
            get { return _underviser.Email; }
            set
            {
                _underviser.Email = value;
                OnPropertyChanged("Email opdateret");
            }
        }
        public string Tlf
        {
            get { return _underviser.Tlf; }
            set
            {
                _underviser.Tlf = value;
                OnPropertyChanged("Email opdateret");
            }
        }
        #endregion



    }
}
