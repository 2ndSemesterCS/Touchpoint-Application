using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class UnderviserData : ViewModelBase
    {
        private string _navn;
        private string _addresse;
        private string _email;
        private string _tlf;

        public UnderviserData()
        {

        }

        public string Navn { get { return _navn; } set { _navn = value; OnPropertyChanged("navn"); } }
        public string Adresse { get { return _addresse; } set { _addresse = value; OnPropertyChanged("navn"); } }
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged("navn"); } }
        public string Tlf { get { return _tlf; } set { _tlf = value; OnPropertyChanged("navn"); } }


    }
}