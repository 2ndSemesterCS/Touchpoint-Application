﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Model;
using TouchpointApp.Command;

namespace TouchpointApp.ViewModel.Underviser
{
    public class UnderviserViewmodelCollectionRediger : ViewModelBase
    {
        private Model.Underviser _ItemIsSeleceted;
        private ObservableCollection<Model.Underviser> _observableCollection;
        private UnderviserData _UnderviserData;


        public UnderviserViewmodelCollectionRediger()
        {
            CreateObservableCollection();
            _UnderviserData = new UnderviserData();
            RedigerCommand = new RelayCommand(RedigerMetode);
        }

        //Bindes til knappen "rediger" Det er først når der trykke på knappen at der bliver lavet ændringer, hvis vi ikke havde sådan en, 
        // Så ville vi rette direkt i model klasse, det var hvad vi gjorde til at starte med.  
        public void RedigerMetode()
        {
            Collection.Remove(_ItemIsSeleceted);
            Collection.Add(new Model.Underviser(_UnderviserData.Navn, _UnderviserData.Adresse, _UnderviserData.Email, _UnderviserData.Tlf));
        }
        public RelayCommand RedigerCommand { get; set; }

        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public void CreateObservableCollection()
        {
            //Der oprettes et ObservableCollection 
            var Collection = new ObservableCollection<Model.Underviser>();


            // UnderviserCatalog.Instance().Getlist   --> UnderviserCatalog.Instance(), because we allready have an instandse of UnderviserCatalog
            // it will return the objenct instead and therefore we can call .getlist.
            foreach (var item in UnderviserCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            _observableCollection = Collection;
        }

        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Underviser SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set
             {
                _ItemIsSeleceted = value;
                OnPropertyChanged();
            }
        }

        //propperty der skal bindes til listviewets ItemsSource
        public ObservableCollection<Model.Underviser> Collection
        {
            get { return _observableCollection; }
            set
            {
                _observableCollection = value;
                OnPropertyChanged();
            }
        }
    }
}
