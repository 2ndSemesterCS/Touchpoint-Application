﻿using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    public class UndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields
        private UndervisningsStedData _undervisningsstedData;
        private UndervisningsstedCatalog _undervisningsStedCatalog;

        #endregion

        #region Constructor
        public UndervisningsstedViewModel()
        {
            _undervisningsStedCatalog = UndervisningsstedCatalog.Instance();
            _undervisningsstedData = new UndervisningsStedData();
            OpretNytUndervisningsstedCommand = new RelayCommand(OpretNytUndervisningssted);

            if (_undervisningsStedCatalog.All.Count == 0)
            {
                _undervisningsStedCatalog.Load();
            }
        }
        #endregion

        #region Commands
        public RelayCommand OpretNytUndervisningsstedCommand { get; set; }
        public UndervisningsStedData UndervisningsStedData { get { return _undervisningsstedData; } set { _undervisningsstedData = value; } }

        #endregion

        #region ObservableCollection
        public ObservableCollection<Model.Undervisningssted> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Undervisningssted>();
            foreach (var item in UndervisningsstedCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Undervisningssted> Collection
        {
            get { return CreateObservableCollection(); }
        }
        #endregion

        #region Opret Metode
        public void OpretNytUndervisningssted()
        {
            _undervisningsStedCatalog.Create(new Model.Undervisningssted(_undervisningsstedData.Lokale, _undervisningsstedData.Adresse));
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

    }
}

