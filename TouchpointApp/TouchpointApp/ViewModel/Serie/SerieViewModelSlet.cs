using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Serie
{
    class SerieViewModelSlet
    {
        public class KursusViewmodelSlet : ViewModelBase
        {
            #region Instance fields
            private Model.Serie _itemIsSeleceted;
            #endregion

            #region Constructor
            public KursusViewmodelSlet()
            {
                CreateObservableCollection();
                SletCommand = new RelayCommand(DeleteCommand, () => { return _itemIsSeleceted != null; });
            }
            #endregion

            #region Commands
            public RelayCommand SletCommand { get; set; }
            #endregion

            #region ObservableCollections
            //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
            public ObservableCollection<Model.Serie> CreateObservableCollection()
            {
                var Collection = new ObservableCollection<Model.Serie>();
                foreach (var item in SerieCatalog.Instance().GetList)
                {
                    Collection.Add(item);
                }
                return Collection;
            }
            public ObservableCollection<Model.Serie> Collection
            {
                get { return CreateObservableCollection(); }
            }
            #endregion

            #region Property
            //Propperti til at binde listviewets isSeleceted propperty til. 
            public Model.Serie SelectedItem
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
                SerieCatalog.Instance().GetList.Remove(_itemIsSeleceted);
                OnPropertyChanged(nameof(Collection));
            }
        }
        #endregion
    }
}
