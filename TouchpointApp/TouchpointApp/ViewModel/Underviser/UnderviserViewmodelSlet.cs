using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserViewmodelSlet : ViewModelBase
    {
        private Model.Underviser _ItemIsSeleceted;
        private ObservableCollection<Model.Underviser> _observableCollection;

        private UnderviserCatalog _catalog = UnderviserCatalog.Instance();


        public UnderviserViewmodelSlet()
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

        private bool CanDelete()
        {
            if (_catalog.Getlist.Count < 0)
            {
                throw new Exception();
            }
            return true;
        }

        private void DeleteCommand()
        {
            _catalog.Getlist.Remove;
        }
    }
}
