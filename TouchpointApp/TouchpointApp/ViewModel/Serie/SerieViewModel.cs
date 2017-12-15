using System;
using System.Collections.ObjectModel;
using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using Windows.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TouchpointApp.ViewModel.Serie
{
    public class SerieViewModel : ViewModelBase
    {
        #region Instance Fields
        private SerieCatalog _serieCatalog;
        private KursusCatalog _kursusCatalog;

        private SerieData _serieData;
        private List<Model.Kursus> _kursusSerie;
        private Model.Kursus _selectedKursus;

        #endregion

        #region Constructor

        public SerieViewModel()
        {
            _serieCatalog = SerieCatalog.Instance();
            _kursusCatalog = KursusCatalog.Instance();

            _kursusSerie = new List<Model.Kursus>();
            _serieData = new SerieData();
            OpretNySerieCommand = new RelayCommand(OpretNySerie);
            addSerie = new RelayCommand(AddKursusTilSerie);

            if (_serieCatalog.All.Count == 0)
            {
                _serieCatalog.Load();
            }
            if (_kursusCatalog.All.Count == 0)
            {
                _kursusCatalog.Load();
            }
        }

        #endregion


        #region Properties
        public SerieData serieData { get { return _serieData; } set { _serieData = value; } }
        public RelayCommand OpretNySerieCommand { get; set; }
        public RelayCommand addSerie { get; set; }
        #endregion

        #region CollectionSerie

        public ObservableCollection<Model.Serie> CreateObservableCollectionSerie()
        {
            var Collection = new ObservableCollection<Model.Serie>();
            foreach (var item in SerieCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Serie> CollectionSerie
        {
            get { return CreateObservableCollectionSerie(); }
        }
            
        

        public ObservableCollection<Model.Kursus> CreateObservableCollectionKursusSerie()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in _kursusSerie)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Kursus> CollectionKursusTilSerie
        {
            get { return CreateObservableCollectionKursusSerie(); }
        }



        #endregion

        #region CollectionKursus

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

        public Model.Kursus SelectedItemListviewKursus
        {
            get { return _selectedKursus; }
            set
            {
                _selectedKursus = value;
                OnPropertyChanged(nameof(UnderviserData));
                addSerie.RaiseCanExecuteChanged();
            }
        }

        #endregion


        #region CollectionKursusTilSerie
        public ObservableCollection<Model.Kursus> CreateObservableCollectionKursusTilSerie()
        {
            var Collection = new ObservableCollection<Model.Kursus>();
            foreach (var item in _kursusSerie)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Kursus> CollectionKursusTilserie
        {
            get { return CreateObservableCollectionKursusTilSerie(); }
        }

#endregion





        public void AddKursusTilSerie()
        {
            _serieData.KursusSerie = _kursusSerie;
            _kursusSerie.Add(_selectedKursus);
            CreateObservableCollectionKursusTilSerie();
            OnPropertyChanged(nameof(CollectionKursusTilserie));
        }

        public void OpretNySerie()
        {
            _serieCatalog.Create(_serieData.KursusSerie, _serieData.Beskrivelse);
            CreateObservableCollectionSerie();
            OnPropertyChanged(nameof(CollectionSerie));

        }

    }
}


//    public class KursistViewModel : ViewModelBase
//    {
//        #region Instance Fields

//        private KursistCatalog _kursistCatalog;
//        private KursistData _kd;
//        #endregion

//        #region Constructor
//        public KursistViewModel()
//        {
//            _kursistCatalog = KursistCatalog.Instance();
//            if (_kursistCatalog.All.Count == 0)
//            {
//                _kursistCatalog.Load();
//            }
//            _kd = new KursistData();

//            OpretNyKursistCommand = new RelayCommand(OpretNyKursist);
//        }
//        #endregion

//        #region ObservableCollection
//        public ObservableCollection<Model.Kursist> CreateObservableCollection()
//        {

//            var Collection = new ObservableCollection<Model.Kursist>();
//            foreach (var item in _kursistCatalog.All)
//            {
//                Collection.Add(item);
//            }
//            return Collection;
//        }

//        public ObservableCollection<Model.Kursist> Collection
//        {
//            get { return CreateObservableCollection(); }
//        }
//        #endregion

//        #region Commands
//        public RelayCommand OpretNyKursistCommand { get; set; }

//        public KursistData KursistData { get { return _kd; } set { _kd = value; } }
//        #endregion

//        #region Metoder
//        public void OpretNyKursist()
//        {
//            _kursistCatalog.Create(new Model.Kursist(_kd.Navn, _kd.Adresse, _kd.Email, _kd.Tlf, _kd.Land, _kd.By));
//            OnPropertyChanged(nameof(Collection));
//        }
//        #endregion
//    }
//}
