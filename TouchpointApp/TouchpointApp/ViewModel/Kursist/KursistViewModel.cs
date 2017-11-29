using TouchpointApp.Command;
using TouchpointApp.Persistency;
using TouchpointApp.Model;
using TouchpointApp.DataStorage;

namespace TouchpointApp.ViewModel.Kursist
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields

        private KursistCatalog _kc;
        private KursistData _kd;

        #endregion

        #region Commands
        public RelayCommand OpretNyKursistCommand { get; set; }

        public KursistData KursistData { get { return _kd; } set { _kd = value; } }
        #endregion

        #region Constructor

        public KursistViewModel()
        {
            _kc = new KursistCatalog();
            _kd = new KursistData();

            OpretNyKursistCommand = new RelayCommand(OpretNyKursist);
        }
        #endregion

        #region Metoder

        public void OpretNyKursist()
        {
            _kc.OpretKursist(_kd.Navn,_kd.Email,_kd.Tlf, _kd.Adresse, _kd.By, _kd.Land);
        }

        #endregion
    }
}
