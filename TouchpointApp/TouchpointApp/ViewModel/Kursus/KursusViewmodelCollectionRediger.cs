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

        private Model.Kursus _itemIsSeleceted;
        private KursusData _kursusData;


        public KursusViewmodelCollectionRediger()
        {
            _kursusData = new KursusData();
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _itemIsSeleceted != null; });
        }

        public RelayCommand RedigerCommand { get; set; }
        public KursusData KursusData { get { return _kursusData; } set { _kursusData = value; } }

        public void RedigerMetode()
        {
            KursusCatalog.Instance().Getlist.Remove(_itemIsSeleceted);
            KursusCatalog.Instance().OpretKursus(_kursusData.Titel, _kursusData.Dato, 
                _kursusData.Tidspunkt, _kursusData.Varighed, _kursusData.Pris, _kursusData.Sprog,
                _kursusData.Beskrivelse, _kursusData.Depositum, _kursusData.Underviser, _kursusData.Undervisningssted);
            OnPropertyChanged(nameof(Collection));
        }

        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Kursus SelectedItemListview
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
                    _kursusData.Underviser = _itemIsSeleceted.Underviser;
                    _kursusData.Undervisningssted = _itemIsSeleceted.Undervisningssted;
                }
                OnPropertyChanged(nameof(KursusData));
                RedigerCommand.RaiseCanExecuteChanged();
            }
        }

        //propperty der skal bindes til listviewets ItemsSource
        public ObservableCollection<Model.Kursus> Collection
        {
            get { return CreateObservableCollection(); }
        }

        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Kursus> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in KursusCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

    }
}
