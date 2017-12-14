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
        #region Instance fields
        private Model.Kursist _ItemIsSeleceted;
        #endregion

        #region Slet Metode
        public KursistViewmodelSlet()
        {
            KursistCatalog.Instance().Load();
            CreateObservableCollection();
            SletCommand = new RelayCommand(DeleteCommand, () => { return _ItemIsSeleceted != null; });
        }
        public void DeleteCommand()
        {
            KursistCatalog.Instance().All.Remove(_ItemIsSeleceted);
            OnPropertyChanged(nameof(Collection));
        }
        #endregion

        #region Commands
        public RelayCommand SletCommand { get; set; }
        public ObservableCollection<Model.Kursist> Collection
        {
            get { return CreateObservableCollection(); }
        }
        #endregion

        #region SelectedItemListView
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
        #endregion

        #region ObservableCollection
        public ObservableCollection<Model.Kursist> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Kursist>();
            foreach (var item in KursistCatalog.Instance().All)
            {
                Collection.Add(item);
            }
            return Collection;
        }
        #endregion

    }
}
