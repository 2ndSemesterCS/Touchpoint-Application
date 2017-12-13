using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;
using System.Collections.ObjectModel;


namespace TouchpointApp.ViewModel.Underviser
{
    public class UnderviserViewmodel : ViewModelBase
    {
        private UnderviserData _underviserData;
        private UnderviserCatalog _underviserCatalog;
        private RelayCommand _loadCommand;
        private RelayCommand _saveCommand;

        public UnderviserViewmodel()
        {
            //singelton method is used. 
            _underviserCatalog = UnderviserCatalog.Instance();
            _underviserData = new UnderviserData();
            OpretNyUnderviserCommand = new RelayCommand(OpretNyUnderviser);
       
        }


        public ObservableCollection<Model.Underviser> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Underviser>();
            foreach (var item in UnderviserCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Underviser> Collection
        {
            get { return CreateObservableCollection(); }
        }


        //Propperty with type relaycommand, so we can bind our creat method to a buttom. 
        public RelayCommand OpretNyUnderviserCommand { get; set; }

        

        public UnderviserData UnderviserData { get { return _underviserData; } set { _underviserData = value; } }

        public void OpretNyUnderviser()
        {
            _underviserCatalog.OpretUnderviser(_underviserData.Navn, _underviserData.Adresse, _underviserData.Email, _underviserData.Tlf);
            OnPropertyChanged(nameof(Collection));
        }






    }
}
