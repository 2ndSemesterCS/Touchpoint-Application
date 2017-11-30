using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;


namespace TouchpointApp.ViewModel.Kursus
{
    public class KursusViewModel : ViewModelBase
    {
        #region Instance Fields

        private KursusCatalog _kursusCatalog;
        private KursusData _kursusData;

        #endregion  

        #region Properties
       
        public KursusData kursusData { get {return _kursusData; } set { _kursusData = value; } }
        public RelayCommand OpretNytKursusCommand { get; set; }
        #endregion

        #region Constructor
        public KursusViewModel()
        {
           _kursusCatalog = new KursusCatalog();
           _kursusData = new KursusData();
           OpretNytKursusCommand = new RelayCommand(OpretNytKursus);
        }
        #endregion

        #region Metoder

        public void OpretNytKursus()
        {
            _kursusCatalog.OpretKursus(_kursusData.Titel, _kursusData.Dato, _kursusData.Tidspunkt, _kursusData.Varighed, _kursusData.Pris,_kursusData.Underviser, _kursusData.Undervisningssted, _kursusData.Sprog, _kursusData.Beskrivelse, _kursusData.Depositum);

        }

        #endregion


    }
}
