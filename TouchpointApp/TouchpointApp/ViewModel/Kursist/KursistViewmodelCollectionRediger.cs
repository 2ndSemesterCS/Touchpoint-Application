using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;
using System.Collections.ObjectModel;
using TouchpointApp.Model;

namespace TouchpointApp.ViewModel.Kursist
{
    class KursistViewmodelCollectionRediger : ViewModelBase
    {
        #region Instance fields
        private Model.Kursist _ItemIsSeleceted;
        private KursistData _KursistData;
        private KursistCatalog _kursistCatalog;
        #endregion

        #region Constructor
        public KursistViewmodelCollectionRediger()
        {
            _kursistCatalog = KursistCatalog.Instance();
            _kursistCatalog.Load();
            _KursistData = new KursistData(); 
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _ItemIsSeleceted != null; });
        }
        #endregion

        #region Commands
        public RelayCommand RedigerCommand { get; set; }
        public KursistData KursistData { get { return _KursistData; } set { _KursistData = value; } }
        #endregion

        #region Metode
        public void RedigerMetode()
        {
            KursistCatalog.Instance().All.Remove(_ItemIsSeleceted);
            KursistCatalog.Instance().Create(new Model.Kursist(_KursistData.Navn, _KursistData.Adresse, _KursistData.Email, _KursistData.Tlf, _KursistData.Land, _KursistData.By));
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

        #region SelectedItemListView
        public Model.Kursist SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set
            {
                _ItemIsSeleceted = value;
                if (_ItemIsSeleceted != null)
                {
                    _KursistData.Navn = _ItemIsSeleceted.Navn;
                    _KursistData.Email = _ItemIsSeleceted.EMail;
                    _KursistData.Adresse = _ItemIsSeleceted.Adresse;
                    _KursistData.Tlf = _ItemIsSeleceted.Tlf;
                    _KursistData.Land = _ItemIsSeleceted.Land;
                    _KursistData.By = _ItemIsSeleceted.By;
                }
                OnPropertyChanged(nameof(KursistData));
                RedigerCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region ObservableCollection
        public ObservableCollection<Model.Kursist> Collection
        {
            get { return CreateObservableCollection(); }
        }

        public ObservableCollection<Model.Kursist> CreateObservableCollection()
        {
       
            var Collection = new ObservableCollection<Model.Kursist>();

            foreach (var item in KursistCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }
        #endregion

    }
}
