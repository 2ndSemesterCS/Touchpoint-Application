using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TouchpointApp.ViewModel.Kursist
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields

        private KursistCatalog _kursistCatalog;
        private KursistData _kd;
        #endregion

        #region Constructor
        public KursistViewModel()
        {
            _kursistCatalog = KursistCatalog.Instance();
            if (_kursistCatalog.All.Count == 0)
            {
                _kursistCatalog.Load();
            }

            _kd = new KursistData();
            OpretNyKursistCommand = new RelayCommand(OpretNyKursist);
        }
        #endregion

        #region ObservableCollection
        public ObservableCollection<Model.Kursist> CreateObservableCollection()
        {
   
            var Collection = new ObservableCollection<Model.Kursist>();
            foreach (var item in _kursistCatalog.All)
            {
                Collection.Add(item);
            }
            return Collection;
        }

        public ObservableCollection<Model.Kursist> Collection
        {
            get { return CreateObservableCollection(); }
        }
        #endregion

        #region Commands
        public RelayCommand OpretNyKursistCommand { get; set; }

        public KursistData KursistData { get { return _kd; } set {value = _kd; } }
        #endregion

        #region Metoder
        public void OpretNyKursist()
        {
            _kursistCatalog.Create(new Model.Kursist(_kd.Navn, _kd.Adresse, _kd.Email, _kd.Tlf, _kd.Land, _kd.By));
            OnPropertyChanged(nameof(Collection));
        }
        #endregion
    }
}
