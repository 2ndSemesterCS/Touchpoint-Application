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
        #region Instance fields
        private UnderviserData _underviserData;
        private UnderviserCatalog _underviserCatalog;

        #endregion

        #region Constructor
        public UnderviserViewmodel()
        {
            //singelton method is used. 
            _underviserCatalog = UnderviserCatalog.Instance();
            if (_underviserCatalog.All.Count == 0)
            {
                _underviserCatalog.Load();
            }
            _underviserData = new UnderviserData();
            OpretNyUnderviserCommand = new RelayCommand(OpretNyUnderviser);
        }
        #endregion

        #region ObservableCollection
        public ObservableCollection<Model.Underviser> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Underviser>();
            foreach (var item in _underviserCatalog.All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Underviser> Collection
        {
            get { return CreateObservableCollection(); }
        }
        #endregion

        #region Commands
        //Propperty with type relaycommand, so we can bind our creat method to a buttom
        public RelayCommand OpretNyUnderviserCommand { get; set; }
        public UnderviserData UnderviserData { get { return _underviserData; } set { _underviserData = value; } }
        #endregion

        #region Opret metode
        public void OpretNyUnderviser()
        {
            _underviserCatalog.Create(new Model.Underviser(_underviserData.Navn, _underviserData.Adresse, _underviserData.Email, _underviserData.Tlf));
            OnPropertyChanged(nameof(Collection));
        }
        #endregion
    }
}
