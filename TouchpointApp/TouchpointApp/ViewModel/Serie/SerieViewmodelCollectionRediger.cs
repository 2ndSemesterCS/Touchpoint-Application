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


namespace TouchpointApp.ViewModel.Serie
{
    class SerieViewmodelCollectionRediger : ViewModelBase
    {

        #region Instance Fields

        private SerieCatalog _serieCatalog;
        private KursusCatalog _kursusCatalog;
        private SerieData _serieData;

        private List<Model.Kursus> _ListAfKursus;

        private Model.Kursus _selelectedKurusFjern;
        private Model.Serie _selectedSerie;

        #endregion

        #region Constructor

        public SerieViewmodelCollectionRediger()
        {
            _serieCatalog = SerieCatalog.Instance();
            _kursusCatalog = KursusCatalog.Instance();

            _ListAfKursus = new List<Model.Kursus>();
            _serieData = new SerieData();

            // RedigerCommand = new RelayCommand(RedigerMetode, () => { return _itemIssellected != null; });
            FjernKurus = new RelayCommand(SletEtkurusFraSerien);
          //RedigerCommand = new RelayCommand(Mangler metodenavn, () => { return _itemIssellected != null; });
          
        }

        #endregion

        public SerieData SerieData { get { return _serieData; } set { _serieData = value; } }

        #region Commands
        public RelayCommand RedigerCommand { get; set; }
        public RelayCommand FjernKurus { get; set; }
        public RelayCommand AddKursus { get; set; }
        #endregion

        #region Rediger Metode
        //public void RedigerMetode()
        //{
        //    SerieCatalog.Instance().GetList.Remove(_itemIssellected);
        //    SerieCatalog.Instance().OpretSerie(_serieData.KursusSerie, _serieData.Beskrivelse);
        //    OnPropertyChanged(nameof(CollectionSerie));
        //}

        //Slet metode til pil. 
        public void SletEtkurusFraSerien()
        {
            _selectedSerie.KursusSerie.Remove(_selelectedKurusFjern);
            OnPropertyChanged(nameof(CollectionIndeholderKurser));
            CreateObservableCollectionMedKurusDerAlleredeErIListen();

        }

        //add metode til pil. 
        public void AddKurusTilSerie()
        {
          
        }
        #endregion


        #region CollectionAfKursurer ude til hæjre 
        public ObservableCollection<Model.Kursus> CreateObservableCollectionKursus()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in KursusCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Kursus> CollectionKursus
        {
            get { return CreateObservableCollectionKursus(); }
        }

        #endregion


        #region CollectionAfSerie ude til venstre

        public ObservableCollection<Model.Serie> CollectionSerie
        {
            get { return CreateObservableCollectionSerie(); }
        }

        public ObservableCollection<Model.Serie> CreateObservableCollectionSerie()
        {
            var Collection = new ObservableCollection<Model.Serie>();
            foreach (var item in SerieCatalog.Instance().GetList)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public Model.Serie SelectedItemSerieListView
        {
            get { return _selectedSerie; }
            set
            {
                _selectedSerie = value;
                if (_selectedSerie != null)
                {
                    _serieData.Beskrivelse = _selectedSerie.Beskrivelse;
                    _ListAfKursus = _selectedSerie.KursusSerie;
                }
                OnPropertyChanged(nameof(SerieData));
                OnPropertyChanged(nameof(CollectionIndeholderKurser));
            }
        }
        #endregion


        #region CollectionAfSerie i midten
        public ObservableCollection<Model.Kursus> CollectionIndeholderKurser
        {
            get { return CreateObservableCollectionMedKurusDerAlleredeErIListen(); }
        }

        public ObservableCollection<Model.Kursus> CreateObservableCollectionMedKurusDerAlleredeErIListen()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in _ListAfKursus)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public Model.Kursus SelectedItemFjernEtKurus
        {
            get { return _selelectedKurusFjern; }
            set { _selelectedKurusFjern = value; }
        }
        #endregion



       


    }
}
