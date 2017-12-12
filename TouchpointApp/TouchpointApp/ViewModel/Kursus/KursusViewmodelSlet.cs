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
            private Model.Kursus _itemIsSeleceted;

            public KursusViewmodelSlet()
            {
                CreateObservableCollection();
                SletCommand = new RelayCommand(DeleteCommand, () => { return _itemIsSeleceted != null; });
            }

            public RelayCommand SletCommand { get; set; }


            //Skal lave vores katalog om til en obserablecollection, som vi kan bind vores listviews ItemsSource til. 
            public ObservableCollection<Model.Kursus> CreateObservableCollection()
            {
                //Der oprettes et ObservableCollection 
                var Collection = new ObservableCollection<Model.Kursus>();

                // UnderviserCatalog.Instance().Getlist   --> UnderviserCatalog.Instance(), because we allready have an instandse of UnderviserCatalog
                // it will return the objenct instead and therefore we can call .getlist.
                foreach (var item in KursusCatalog.Instance().Getlist)
                {
                    Collection.Add(item);
                }
                return Collection;
            }

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

            //propperty der skal bindes til listviewets ItemsSource
            public ObservableCollection<Model.Kursus> Collection
            {
                get { return CreateObservableCollection(); }
            }

            public void DeleteCommand()
            {
                KursusCatalog.Instance().Getlist.Remove(_itemIsSeleceted);
                OnPropertyChanged(nameof(Collection));
            }
        }
    }

