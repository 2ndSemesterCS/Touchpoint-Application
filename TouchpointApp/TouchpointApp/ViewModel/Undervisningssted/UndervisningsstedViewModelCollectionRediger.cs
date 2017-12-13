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
using TouchpointApp.ViewModel;
using Windows.UI.Xaml.Controls;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    class UndervisningsstedViewModelCollectionRediger : ViewModelBase
    {
        #region Instance fields
        private Model.Undervisningssted _ItemIsSeleceted;
        private UndervisningsStedData _UndervisningsstedData;
        #endregion

        #region Constructor
        public UndervisningsstedViewModelCollectionRediger()
        {
            _UndervisningsstedData = new UndervisningsStedData();
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _ItemIsSeleceted != null; });
        }
        #endregion

        #region Commands
        public RelayCommand RedigerCommand { get; set; }
       
        public UndervisningsStedData undervisningstedData { get { return _UndervisningsstedData; } set { _UndervisningsstedData = value; } }
        #endregion

        #region RedigerMetode
        //Bindes til knappen "rediger" Det er først når der trykke på knappen at der bliver lavet ændringer, hvis vi ikke havde sådan en, 
        // Så ville vi rette direkt i model klasse, det var hvad vi gjorde til at starte med.  
        public void RedigerMetode()
        {
            UndervisningsstedCatalog.Instance().Getlist.Remove(_ItemIsSeleceted);
            UndervisningsstedCatalog.Instance().OpretUndervisningssted(_UndervisningsstedData.Lokale, _UndervisningsstedData.Adresse);
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

        #region Property
        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Undervisningssted SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set
            {
                _ItemIsSeleceted = value;
                if (_ItemIsSeleceted != null)
                {
                    _UndervisningsstedData.Adresse = _ItemIsSeleceted.Adresse;
                    _UndervisningsstedData.Lokale = _ItemIsSeleceted.Lokale;
                }
                OnPropertyChanged(nameof(undervisningstedData));
                RedigerCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region ObservableCollection
        //propperty der skal bindes til listviewets ItemsSource
        public ObservableCollection<Model.Undervisningssted> Collection
        {
            get { return CreateObservableCollection(); }
        }

        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Undervisningssted> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Undervisningssted>();
            foreach (var item in UndervisningsstedCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }
        #endregion
    }
}

