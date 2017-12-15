using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Model;
using TouchpointApp.Command;

namespace TouchpointApp.ViewModel.Underviser
{
    public class UnderviserViewmodelCollectionRediger : ViewModelBase
    {
        #region Instance fields
        private Model.Underviser _ItemIsSeleceted;
        private UnderviserData _UnderviserData;
        private UnderviserCatalog _underviserCatalog;
        #endregion

        #region Constructor
        public UnderviserViewmodelCollectionRediger()
        {
            _UnderviserData = new UnderviserData();
            _underviserCatalog = UnderviserCatalog.Instance() ;
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _ItemIsSeleceted != null; });
        }
        #endregion

        #region Commands
        public RelayCommand RedigerCommand { get; set; }
        public UnderviserData UnderviserData { get { return _UnderviserData; } set { _UnderviserData = value; } }
        #endregion

        #region RedigerMetode
        //Bindes til knappen "rediger" Det er først når der trykke på knappen at der bliver lavet ændringer, hvis vi ikke havde sådan en, 
        // Så ville vi rette direkt i model klasse, det var hvad vi gjorde til at starte med.  
        public void RedigerMetode()
        {
            int key = _ItemIsSeleceted.Key;
            _underviserCatalog.Delete(key);
            Model.Underviser Underviser = new Model.Underviser(_UnderviserData.Navn, _UnderviserData.Adresse, _UnderviserData.Email, _UnderviserData.Tlf));
            Underviser.Key = key;
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

        #region Property
        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Underviser SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set
             {
                _ItemIsSeleceted = value;
                if (_ItemIsSeleceted != null)
                {
                    _UnderviserData.Navn = _ItemIsSeleceted.Navn;
                    _UnderviserData.Email = _ItemIsSeleceted.Email;
                    _UnderviserData.Adresse = _ItemIsSeleceted.Addresse;
                    _UnderviserData.Tlf = _ItemIsSeleceted.Tlf;
                }
                OnPropertyChanged(nameof(UnderviserData));
                RedigerCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region ObservableCollection
        //propperty der skal bindes til listviewets ItemsSource
        public ObservableCollection<Model.Underviser> Collection
        {
            get { return CreateObservableCollection(); }
        }

        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Underviser> CreateObservableCollection()
        {
            //Der oprettes et ObservableCollection 
            var Collection = new ObservableCollection<Model.Underviser>();

            // UnderviserCatalog.Instance().Getlist   --> UnderviserCatalog.Instance(), because we allready have an instandse of UnderviserCatalog
            // it will return the objenct instead and therefore we can call .getlist.
            foreach (var item in UnderviserCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }
        #endregion
    }
}
