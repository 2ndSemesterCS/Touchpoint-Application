using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    public class UndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields

        private UndervisningsstedCatalog _uc;

        private Model.Lokale _lokale;
        private string _adresse;
        #endregion

        public Model.Lokale Lokale
        {
            get { return _lokale; }
            set
            {
                _lokale = value;
                OnPropertyChanged("Lokale");
            }
        }

        public string Adresse
        {
            get { return _adresse; }
            set
            {
                _adresse = value;
                OnPropertyChanged("Adresse");
            }
        }

        public void OpretNytUndervisningssted()
        {
            _uc.OpretUndervisningssted(_adresse, _lokale);
        }

    }
}
