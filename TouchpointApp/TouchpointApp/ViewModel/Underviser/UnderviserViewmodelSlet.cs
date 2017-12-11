﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserViewmodelSlet : ViewModelBase
    {
        private Model.Underviser _ItemIsSeleceted;

        public UnderviserViewmodelSlet()
        {
            CreateObservableCollection();
            SletCommand = new RelayCommand(DeleteCommand, ()=> { return _ItemIsSeleceted != null; });
        }

        public RelayCommand SletCommand { get; set; }


        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Underviser> CreateObservableCollection()
        {
            //Der oprettes et ObservableCollection 
            var Collection = new ObservableCollection<Model.Underviser>();

            // UnderviserCatalog.Instance().Getlist   --> UnderviserCatalog.Instance(), because we allready have an instandse of UnderviserCatalog
            // it will return the objenct instead and therefore we can call .getlist.
            foreach (var item in UnderviserCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Underviser SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set
            {
                _ItemIsSeleceted = value;
                SletCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        //propperty der skal bindes til listviewets ItemsSource
        public ObservableCollection<Model.Underviser> Collection
        {
            get { return CreateObservableCollection(); }
        }

        public void DeleteCommand()
        {
            UnderviserCatalog.Instance().Getlist.Remove(_ItemIsSeleceted);
            OnPropertyChanged(nameof(Collection));
        }
    }
}
 