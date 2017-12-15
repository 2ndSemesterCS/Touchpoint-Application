using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TouchpointApp.Command;
using TouchpointApp.Persistency;


namespace TouchpointApp.ViewModel.Kursus
{
    public class KursusViewmodelSlet : ViewModelBase
    {
        #region Instance fields
        private Model.Kursus _itemIsSeleceted;
        private KursusCatalog _kursusCatalog;
        #endregion

        #region Constructor
        public KursusViewmodelSlet()
            {
            _kursusCatalog = KursusCatalog.Instance();
             SletCommand = new RelayCommand(DeleteCommand, () => { return _itemIsSeleceted != null; });

            if (_kursusCatalog.All.Count == 0)
            {
                _kursusCatalog.Load();
            }
            CreateObservableCollection();
        }
        #endregion

        #region Commands
        public RelayCommand SletCommand { get; set; }
        #endregion

        #region ObservableCollections
        //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
        public ObservableCollection<Model.Kursus> CreateObservableCollection()
            {
                //Der oprettes et ObservableCollection 
                var Collection = new ObservableCollection<Model.Kursus>();

                // UnderviserCatalog.Instance().Getlist   --> UnderviserCatalog.Instance(), because we allready have an instandse of UnderviserCatalog
                // it will return the objenct instead and therefore we can call .getlist.
                foreach (var item in KursusCatalog.Instance().All)
                {
                    Collection.Add(item);
                }
                return Collection;
            }
        public ObservableCollection<Model.Kursus> Collection
        {
            get { return CreateObservableCollection(); }
        }
        #endregion

        #region Property
        //Propperti til at binde listviewets isSeleceted propperty til. 
        public Model.Kursus SelectedItem
            {
                get { return _itemIsSeleceted; }
                set
            {
                _itemIsSeleceted = value;
                SletCommand.RaiseCanExecuteChanged();
                OnPropertyChanged();
            }
            }
        #endregion

        #region SletMetode
        public void DeleteCommand()
            {
               _kursusCatalog.Delete(_itemIsSeleceted.Key);
                OnPropertyChanged(nameof(Collection));
            }
        }
    #endregion
}

