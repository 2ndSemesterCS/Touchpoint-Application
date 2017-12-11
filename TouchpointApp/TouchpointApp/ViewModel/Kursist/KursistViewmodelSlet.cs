using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Kursist
{
    class KursistViewmodelSlet : ViewModelBase
    {
        private Model.Kursist _ItemIsSeleceted;

        public KursistViewmodelSlet()
        {
            CreateObservableCollection();
            SletCommand = new RelayCommand(DeleteCommand, () => { return _ItemIsSeleceted != null; });
        }

        public RelayCommand SletCommand { get; set; }

        
        public ObservableCollection<Model.Kursist> CreateObservableCollection()
        {
         
            var Collection = new ObservableCollection<Model.Kursist>();

       
            foreach (var item in KursistCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public Model.Kursist SelectedItemListview
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
        public ObservableCollection<Model.Kursist> Collection
        {
            get { return CreateObservableCollection(); }
        }

        public void DeleteCommand()
        {
            KursistCatalog.Instance().Getlist.Remove(_ItemIsSeleceted);
            OnPropertyChanged(nameof(Collection));
        }
    }
}
