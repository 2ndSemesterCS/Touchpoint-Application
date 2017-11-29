using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class LokaleData : ViewModelBase
    {
        private string _navn;

        public LokaleData()
        {

        }

        public string Navn { get { return _navn; } set { _navn = value; OnPropertyChanged("navn"); } }

    }
}
