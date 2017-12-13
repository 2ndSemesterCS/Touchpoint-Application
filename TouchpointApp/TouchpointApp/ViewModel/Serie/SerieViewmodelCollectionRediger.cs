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
        private SerieData _serieData;
        private Model.Serie _itemIssellected;

        private KursusCatalog _kursusCatalog;
        private Model.Kursus _selectedKursus;

        #endregion

        #region Constructor

        public SerieViewmodelCollectionRediger()
        {
            _serieData = new SerieData();
            RedigerCommand = new RelayCommand(RedigerMetode, () => { return _itemIssellected != null; });
        }

        #endregion

        #region Commands

        public RelayCommand RedigerCommand { get; set; }
        public SerieData SerieData { get { return _serieData; } set { _serieData = value; } }

        #endregion

        #region Rediger Metode

        public void RedigerMetode()
        {

            SerieCatalog.Instance().GetList.Remove(_itemIssellected);
            SerieCatalog.Instance().OpretSerie(_serieData.KursusSerie, _serieData.Beskrivelse);
            OnPropertyChanged(nameof(Collection));

        }

        #endregion

        #region Propperty

        public SerieData serieData { get { return _serieData; } set { _serieData = value; } }
        public RelayCommand redigerSerieCommand { get; set; }

        #endregion

        #region ObservableCollection

        public ObservableCollection<Model.Serie> Collection
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

        #endregion


    }
}
