using System;
using System.Collections.ObjectModel;
using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using Windows.UI.Xaml.Controls;


namespace TouchpointApp.ViewModel.Serie
{
    public class SerieViewModel : ViewModelBase
    {
        #region Instance Fields
        private SerieCatalog _serieCatalog;
        private SerieData _serieData;
        private Model.Serie _selectedSerie;

        private KursusCatalog _kursusCatalog;
        private Model.Kursus _selectedKursus;

        #endregion

        #region Constructor
        
        public SerieViewModel()
        {
            _serieCatalog = SerieCatalog.Instance();
            _kursusCatalog = KursusCatalog.Instance();

            _serieData = new SerieData();
            OpretNytSerieCommand = new RelayCommand(OpretNytSerie);
        }

        #endregion


        #region Properties
        public SerieData serieData { get { return _serieData; } set { _serieData = value; } }
        public RelayCommand OpretNytSerieCommand { get; set; }
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

        public Model.Serie SelectedItemListviewSerie
        {
            get { return _selectedSerie; }
            set { _selectedSerie = value; }
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
            set { _selectedKursus = value; }
        }

        #endregion

        public void OpretNytSerie()
        {
            _serieCatalog.OpretSerie(_serieData.KursusSerie, _serieData.Beskrivelse);
        }

    }
}
