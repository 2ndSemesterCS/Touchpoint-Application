using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TouchpointApp.ViewModel.Kursist
{
    class KursistViewmodelCollectionRediger : ViewModelBase
    {
        private Model.Kursist _ItemIsSeleceted;
        private KursistData _KursistData;


        public KursistViewmodelCollectionRediger()
        {
            _KursistData = new KursistData();
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _ItemIsSeleceted != null; });
        }

        public RelayCommand RedigerCommand { get; set; }
        public KursistData KursistData { get { return _KursistData; } set { _KursistData = value; } }

        
        public void RedigerMetode()
        {
            KursistCatalog.Instance().Getlist.Remove(_ItemIsSeleceted);
            KursistCatalog.Instance().OpretKursist(_KursistData.Navn, _KursistData.Adresse, _KursistData.Email, _KursistData.Tlf, _KursistData.Land, _KursistData.By);
            OnPropertyChanged(nameof(Collection));
        }
 
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

       
        public ObservableCollection<Model.Kursist> Collection
        {
            get { return CreateObservableCollection(); }
        }

       
        public ObservableCollection<Model.Kursist> CreateObservableCollection()
        {
       
            var Collection = new ObservableCollection<Model.Kursist>();

            foreach (var item in KursistCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }
    }
}
