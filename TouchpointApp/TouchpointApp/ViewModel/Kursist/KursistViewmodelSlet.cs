﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Kursist
{
    class KursistViewmodelSlet : ViewModelBase
    {
        #region Instance fields
        private Model.Kursist _ItemIsSeleceted;
        private KursistCatalog _kursistCatalog;
        #endregion

        public KursistViewmodelSlet()
        {
            _kursistCatalog = KursistCatalog.Instance();
            if (_kursistCatalog.All.Count == 0)
            {
                _kursistCatalog.Load();
            }
            CreateObservableCollection();
            SletCommand = new RelayCommand(DeleteMetode, () => { return _ItemIsSeleceted != null; });
        }
       
        #region ObservableCollection
        public ObservableCollection<Model.Kursist> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Kursist>();
            foreach (var item in KursistCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }
        #endregion

        #region Commands
        public RelayCommand SletCommand { get; set; }
       
        #endregion
        #region Propperties
        public Model.Kursist SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set
            {
                _ItemIsSeleceted = value;
                SletCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Model.Kursist> Collection
        {
            get { return CreateObservableCollection(); }
        }
        #endregion

        #region Slet Metode
        public void DeleteMetode()
        {
           _kursistCatalog.Delete(_ItemIsSeleceted.Key);
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

    }
}
