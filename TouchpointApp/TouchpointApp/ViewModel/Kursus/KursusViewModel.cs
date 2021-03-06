﻿using System;
using System.Collections.ObjectModel;
using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using Windows.UI.Xaml.Controls;

namespace TouchpointApp.ViewModel.Kursus
{
    public class KursusViewModel : ViewModelBase
    {
        #region Instance fields
        private KursusCatalog _kursusCatalog;
        private KursusData _kursusData;
        private UnderviserCatalog _underviserCatalog;
        private UndervisningsstedCatalog _undervisersStedsCatalog;

        private Model.Kursus _selectedKurus;
        private Model.Underviser _selectedUnderviser;
        private Model.Undervisningssted _selectedUnderviserssted;
        #endregion

        #region Constructor
        public KursusViewModel()
        {
            _kursusCatalog = KursusCatalog.Instance();
            _underviserCatalog = UnderviserCatalog.Instance();
            _undervisersStedsCatalog = UndervisningsstedCatalog.Instance();

            //if (_kursusCatalog.All.Count == 1)
            //{
            //    _kursusCatalog.Load();
            //}
            if (_underviserCatalog.All.Count == 0)
            {
                _underviserCatalog.Load();
            }
            if (_undervisersStedsCatalog.All.Count == 0)
            {
                _undervisersStedsCatalog.Load();
            }

            _kursusData = new KursusData();
            OpretNytKursusCommand = new RelayCommand(OpretNytKursus);
        }
        #endregion

        #region Commands
        public KursusData kursusData { get { return _kursusData; } set {value = _kursusData; } }
        public RelayCommand OpretNytKursusCommand { get; set; }
        #endregion

        #region CollectionKurus
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

        public Model.Kursus SelectedItemListviewKurus
        {
            get { return _selectedKurus; }
            set { _selectedKurus = value; }
        }
        #endregion

        #region CollectionUnderviser
        public ObservableCollection<Model.Underviser> CreateObservableCollectionUnderviser()
        {
            var Collection = new ObservableCollection<Model.Underviser>();
            foreach (var item in UnderviserCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Underviser> CollectionUnderviser
        {
            get { return CreateObservableCollectionUnderviser(); }
        }

        public Model.Underviser SelectedItemListviewUnderviser
        {
            get { return _selectedUnderviser; }
            set
            {
                _selectedUnderviser = value;
                if (_selectedUnderviser != null)
                {
                    _kursusData.UnderviserKey = _selectedUnderviser.Key;
                }
                OnPropertyChanged(nameof(_kursusData));
                OpretNytKursusCommand.RaiseCanExecuteChanged();

            }
        } 
        #endregion

        #region CollectionUndervisningsSted
        public ObservableCollection<Model.Undervisningssted> CreateObservableCollectionUndervisningsSted()
        {
            var Collection = new ObservableCollection<Model.Undervisningssted>();
            foreach (var item in UndervisningsstedCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Undervisningssted> CollectionUndervisningsSted
        {
            get { return CreateObservableCollectionUndervisningsSted(); }
        }

        public Model.Undervisningssted SelectedItemListviewUnderviserssted
        {
            get { return _selectedUnderviserssted; }
            set {
                _selectedUnderviserssted = value;
                if (_selectedUnderviserssted != null)
                {
                    _kursusData.UndervisningsstedKey = _selectedUnderviserssted.Key;
                }
                OnPropertyChanged(nameof(_kursusData));
                OpretNytKursusCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region Opret metode
        public void OpretNytKursus()
        {
            Model.Kursus obj = new Model.Kursus(_kursusData.Titel, _kursusData.Dato, _kursusData.Tidspunkt, _kursusData.Varighed, _kursusData.Pris, _kursusData.Sprog, _kursusData.Beskrivelse, _kursusData.Depositum, _kursusData.UnderviserKey, _kursusData.UndervisningsstedKey);
           _kursusCatalog.Create(obj);
            OnPropertyChanged(nameof(CollectionKursus));
        }
        #endregion
    }
}

