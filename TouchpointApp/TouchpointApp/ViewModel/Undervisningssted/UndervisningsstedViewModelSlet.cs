using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    class UndervisningsstedViewModelSlet :ViewModelBase
    {
        private Model.Undervisningssted _ItemIsSeleceted;

        public UndervisningsstedViewModelSlet()
        {
            CreateObservableCollection();
            SletCommand = new RelayCommand(DeleteCommand, () => { return _ItemIsSeleceted != null; });
        }

        public RelayCommand SletCommand { get; set; }


        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Undervisningssted> CreateObservableCollection()
        {
            //Der oprettes et ObservableCollection 
            var Collection = new ObservableCollection<Model.Undervisningssted>();

            // UnderviserCatalog.Instance().Getlist   --> UnderviserCatalog.Instance(), because we allready have an instandse of UnderviserCatalog
            // it will return the objenct instead and therefore we can call .getlist.
            foreach (var item in UndervisningsstedCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Undervisningssted SelectedItemListview
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
        public ObservableCollection<Model.Undervisningssted> Collection
        {
            get { return CreateObservableCollection(); }
        }

        public void DeleteCommand()
        {
            UndervisningsstedCatalog.Instance().Getlist.Remove(_ItemIsSeleceted);
            OnPropertyChanged(nameof(Collection));
        }
    }
}

