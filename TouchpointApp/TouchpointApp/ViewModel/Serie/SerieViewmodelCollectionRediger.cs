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

        private Model.Serie _itemIssellected;
        private List<Model.Kursus> _ListAfKursus;

        private Model.Kursus _selelectedKurusFjern;
        private Model.Serie _selectedSerie;

        #endregion

        #region Constructor

        public SerieViewmodelCollectionRediger()
        {
            _serieCatalog = SerieCatalog.Instance();
            _kursusCatalog = KursusCatalog.Instance();

            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _itemIssellected != null; });
            RedigerCommand = new RelayCommand(SletEtkurusFraSerien, () => { return _itemIssellected != null; });
            _ListAfKursus = new List<Model.Kursus>();
            _serieData = new SerieData();
        }

        #endregion

        #region Commands

        public RelayCommand RedigerCommand { get; set; }
        public RelayCommand FjernKurus { get; set; }
        public SerieData SerieData { get { return _serieData; } set { _serieData = value; } }

        #endregion

        #region Rediger Metode

        public void RedigerMetode()
        {

            SerieCatalog.Instance().GetList.Remove(_itemIssellected);
            SerieCatalog.Instance().OpretSerie(_serieData.KursusSerie, _serieData.Beskrivelse);
            OnPropertyChanged(nameof(CollectionSerie));

        }

        #endregion


        public ObservableCollection<Model.Kursus> CreateObservableCollectionKursus()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in KursusCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Kursus> CollectionKursus
        {
            get { return CreateObservableCollectionKursus(); }
        }



        #region ObservableCollection

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
                if(_selectedSerie != null)
                {
                    _serieData.Beskrivelse = _selectedSerie.Beskrivelse;
                    _ListAfKursus = _selectedSerie.KursusSerie;
                }
                OnPropertyChanged(nameof(SerieData));
                OnPropertyChanged(nameof(CollectionIndeholderKurser));
            }
        }
        #endregion

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
            set {_selelectedKurusFjern = value;}
        }



        public void SletEtkurusFraSerien()
        {
           _ListAfKursus.Remove(_selelectedKurusFjern);
            OnPropertyChanged(nameof(CollectionIndeholderKurser));
        }


    }
}
