using System;
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
        #region Instance fields
        private Model.Underviser _ItemIsSeleceted;
        #endregion

        #region Constructor
        public UnderviserViewmodelSlet()
        {
            CreateObservableCollection();
            SletCommand = new RelayCommand(DeleteCommand, ()=> { return _ItemIsSeleceted != null; });
        }
        #endregion

        #region Command
        public RelayCommand SletCommand { get; set; }
        #endregion

        #region ObservableCollection
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
        public ObservableCollection<Model.Underviser> Collection
        {
            get { return CreateObservableCollection(); }
        }

        #endregion

        #region Property
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
        #endregion

        #region Command
        //propperty der skal bindes til listviewets ItemsSource
        public void DeleteCommand()
        {
            UnderviserCatalog.Instance().Getlist.Remove(_ItemIsSeleceted);
            OnPropertyChanged(nameof(Collection));
        }
        #endregion
    }
}
 