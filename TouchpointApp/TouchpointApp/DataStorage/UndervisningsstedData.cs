using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class UndervisningsstedData : ViewModelBase
    {
        private string _adresse;
        private string _lokale;

        UndervisningsstedData()
        {

        }

        public string Adresse {get { return _adresse; } set { value = _adresse; OnPropertyChanged ("adresse"); }}
        public string Lokale { get { return _lokale; } set { value = _lokale; OnPropertyChanged("lokale"); } }
        
    }
}