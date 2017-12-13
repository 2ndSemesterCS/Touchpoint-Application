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
        private SerieData _serieData;

        private List<Model.Kursus> _kursusSerie;

        private KursusCatalog _kursusCatalog;
        private Model.Kursus _selectedKursus;

        #endregion

        #region Constructor
        
        public SerieViewModel()
        {
            _serieCatalog = SerieCatalog.Instance();
            _kursusCatalog = KursusCatalog.Instance();

            _kursusSerie = new List<Model.Kursus>();

            _serieData = new SerieData();
            OpretNySerieCommand = new RelayCommand(OpretNytSerie);
            addSerie = new RelayCommand(AddKursusTilSerie);
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
            foreach (var item in SerieCatalog.Instance().GetList)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Serie> CollectionSerie
        {
            get { return CreateObservableCollectionSerie(); }
        }
        #endregion

        #region CollectionKursusTilSerie
        public ObservableCollection<Model.Kursus> CreateObservableCollectionKursusSerie()
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
            get { return CreateObservableCollectionKursusSerie(); }
        }

        #endregion

        #region CollectionKursus

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







        // Med denne metode kan vi adde Kursus til vores KursusSerieListveiw.
        public void AddKursusTilSerie()
        {
            _serieData.KursusSerie = _kursusSerie;

            _kursusSerie.Add(_selectedKursus);
            CreateObservableCollectionKursusSerie();
            OnPropertyChanged(nameof(CollectionKursusTilserie));
        }

        public void OpretNytSerie()
        {
            
            _serieCatalog.OpretSerie(_serieData.KursusSerie, _serieData.Beskrivelse);
            CreateObservableCollectionSerie();
            OnPropertyChanged(nameof(CollectionSerie));
        }

    }
}
