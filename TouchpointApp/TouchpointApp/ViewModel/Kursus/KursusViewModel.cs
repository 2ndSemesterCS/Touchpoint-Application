using TouchpointApp.Command;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;


namespace TouchpointApp.ViewModel.Kursus
{
    public class KursusViewModel : ViewModelBase
    {
        private KursusCatalog _kursusCatalog;
        private KursusData _kursusData;

        public KursusViewModel()
        {
           _kursusCatalog = new KursusCatalog();
           _kursusData = new KursusData();
           OpretNytKursusCommand = new RelayCommand(OpretNytKursus);
        }

        public KursusData kursusData { get { return _kursusData; } set { _kursusData = value; } }
        public RelayCommand OpretNytKursusCommand { get; set; }



        public void OpretNytKursus()
        {
            _kursusCatalog.OpretKursus(_kursusData.Titel, _kursusData.Dato, _kursusData.Tidspunkt, _kursusData.Varighed, _kursusData.Pris, _kursusData.Sprog, _kursusData.Beskrivelse, _kursusData.Depositum, _kursusData.Underviser, _kursusData.Undervisningssted);
        }
    }
}
