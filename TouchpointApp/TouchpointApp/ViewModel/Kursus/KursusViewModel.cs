using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Kursus
{
    public class KursusViewModel : ViewModelBase
    {

        private KursusCatalog _kc;
        private KursusData _nytKursus;

        #region Properties

        public KursusData NytKursus
        {
            get { return _nytKursus; }
            set { }
        }

        #endregion

        #region Commands

        public RelayCommand OpretNytKursusCommand { get; set; }

        #endregion

        #region Constructor
        public KursusViewModel()
        {
            _kc = new KursusCatalog();
            _nytKursus = new KursusData();
            OpretNytKursusCommand = new RelayCommand(OpretNytKursus);
        }
        #endregion

        #region Metoder

        private void OpretNytKursus()
        {
            _kc.OpretKursus(_nytKursus.KursusTitel, _nytKursus.KursusDato, _nytKursus.KursusTidspunkt, _nytKursus.KursusVarighed, _nytKursus.KursusPris, _nytKursus.KursusUnderviser, _nytKursus.KursusUndervisningssted, _nytKursus.Sprog, _nytKursus.Beskrivelse, _nytKursus.Depositum);

        }

        #endregion


    }
}
