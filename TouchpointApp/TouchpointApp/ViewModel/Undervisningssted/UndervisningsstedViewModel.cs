using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    public class UndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields
        private UndervisningsStedData _undervisningsstedData;
        private UndervisningsstedCatalog _undervisningsstedCatalog;
        private RelayCommand _loadCommand;
        private RelayCommand _saveCommand;

        #endregion

        public UndervisningsstedViewModel()
        {
            _undervisningsstedCatalog = UndervisningsstedCatalog.Instance();
            _undervisningsstedData = new UndervisningsStedData();
            OpretNytUndervisningsstedCommand = new RelayCommand(OpretNytUndervisningssted); 
        }

        public RelayCommand OpretNytUndervisningsstedCommand { get; set; }
        public UndervisningsStedData UndervisningsStedData { get { return _undervisningsstedData; } set { _undervisningsstedData = value; } }


        public ObservableCollection<Model.Undervisningssted> CreateObservableCollection()
        {
            var Collection = new ObservableCollection<Model.Undervisningssted>();
            foreach (var item in UndervisningsstedCatalog.Instance().Getlist)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Undervisningssted> Collection
        {
            get { return CreateObservableCollection(); }
        }

        public void OpretNytUndervisningssted()
        {
            _undervisningsstedCatalog.OpretUndervisningssted(_undervisningsstedData.Lokale, _undervisningsstedData.Adresse);
            OnPropertyChanged(nameof(Collection));
        }


      
      
    }
}
