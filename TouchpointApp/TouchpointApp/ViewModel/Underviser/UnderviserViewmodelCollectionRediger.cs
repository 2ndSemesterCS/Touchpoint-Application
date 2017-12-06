using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Model;

namespace TouchpointApp.ViewModel.Underviser
{
    public class UnderviserViewmodelCollectionRediger : ViewModelBase
    {
        private Model.Underviser _ItemIsSeleceted;
        private ObservableCollection<Model.Underviser> _observableCollection;


        public UnderviserViewmodelCollectionRediger()
        {
            CreateObservableCollection();
        }


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
                OnPropertyChanged("Seleceted item er opdateret");
            }
        }

        //propperty der skal bindes til listviewets ItemsSource
        public ObservableCollection<Model.Underviser> Collection
        {
            get { return _observableCollection; }
        }


        // skal bindes til details viewet på rediger siden
        public string Name { get { return _ItemIsSeleceted.Navn; } set { _ItemIsSeleceted.Navn = value; } }
        public string Email { get { return _ItemIsSeleceted.Email; } set { _ItemIsSeleceted.Email = value; } }
        public string Adresse { get { return _ItemIsSeleceted.Addresse; } set { _ItemIsSeleceted.Addresse = value; } }
        public string Tlf { get { return _ItemIsSeleceted.Tlf; } set { _ItemIsSeleceted.Tlf = value; } }


    }

    //    public class UnderviserViewmodelCollectionRediger
    //    {
    //        public UnderviserCatalog _underviserCatalog;

    //        public ObservableCollection<Model.Underviser> CreateObservableCollection()
    //        {
    //            var Collection = new ObservableCollection<Model.Underviser>();
    //            foreach (var item in _underviserCatalog)
    //            {
    //                Collection.Add(item);
    //            }
    //            return Collection;
    //        }
    //    }

}
