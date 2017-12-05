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
        private UnderviserCatalog underviserCatalog;
        private Model.Underviser _ItemIsSeleceted;
        private ObservableCollection<Model.Underviser> observableCollection;

        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Underviser> CreateObservableCollection()
        {
            //Der oprettes et ObservableCollection 
            var Collection = new ObservableCollection<Model.Underviser>();

            foreach (var item in underviserCatalog.Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Underviser SelectedItemListview
        {
            get { return _ItemIsSeleceted; }
            set { _ItemIsSeleceted = value; }
        }

        // skal bindes til details viewet på rediger siden
        public string Name { get { return _ItemIsSeleceted.Navn; } set { _ItemIsSeleceted.Navn = value; } }
        public string Email { get { return _ItemIsSeleceted.Email; } set { _ItemIsSeleceted.Email = value; } }
        public string Adresse { get { return _ItemIsSeleceted.Addresse; } set { _ItemIsSeleceted.Addresse = value; } }
        public string Tlf { get { return _ItemIsSeleceted.Tlf; } set { _ItemIsSeleceted.Tlf = value; } }


    }
}
