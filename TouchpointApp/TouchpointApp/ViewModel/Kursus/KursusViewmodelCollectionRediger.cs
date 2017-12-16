using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Kursus
{
     public class KursusViewmodelCollectionRediger :ViewModelBase
    {
        #region Instance fields
        private Model.Kursus _itemIsSeleceted;
        private KursusData _kursusData;
        #endregion

        #region Constructor
        public KursusViewmodelCollectionRediger()
        {
            _kursusData = new KursusData();
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _itemIsSeleceted != null; });
        }
        #endregion

        #region Commands
        public RelayCommand RedigerCommand { get; set; }
        public KursusData KursusData { get { return _kursusData; } set { _kursusData = value; } }
        #endregion

        #region RedigerMetode
        public void RedigerMetode()
        {
            KursusCatalog.Instance().All.Remove(_itemIsSeleceted);
            KursusCatalog.Instance().OpretKursus(_kursusData.Titel, _kursusData.Dato, 
                _kursusData.Tidspunkt, _kursusData.Varighed, _kursusData.Pris, _kursusData.Sprog,
                _kursusData.Beskrivelse, _kursusData.Depositum, _kursusData.UnderviserKey, _kursusData.UndervisningsstedKey);
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

        #region Properties
        
        public Model.Kursus SelectedItem
        {
            get { return _itemIsSeleceted; }
            set
            {
                _itemIsSeleceted = value;
                if (_itemIsSeleceted != null)
                {
                    _kursusData.Titel = _itemIsSeleceted.Titel;
                    _kursusData.Dato = _itemIsSeleceted.Dato;
                    _kursusData.Tidspunkt = _itemIsSeleceted.Tidspunkt;
                    _kursusData.Varighed = _itemIsSeleceted.Varighed;
                    _kursusData.Pris = _itemIsSeleceted.Pris;
                    _kursusData.Sprog = _itemIsSeleceted.Sprog;
                    _kursusData.Beskrivelse = _itemIsSeleceted.Beskrivelse;
                    _kursusData.Depositum = _itemIsSeleceted.Depositum;
                    _kursusData.UnderviserKey = _itemIsSeleceted.UnderviserKey;
                    _kursusData.UndervisningsstedKey = _itemIsSeleceted.UndervisningsstedKey;
                }
                OnPropertyChanged(nameof(KursusData));
                RedigerCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region ObsercableCollection
        public ObservableCollection<Model.Kursus> Collection
        {
            get { return CreateObservableCollection(); }
        }
        
        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Kursus> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in KursusCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }
        #endregion

    }
}
