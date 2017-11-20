using TouchpointApp.Command;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.KursusViewModel
{
    public class KursusViewModel : ViewModelBase
    {
        #region Instance Fields

        private KursusCatalog _kc;

        private string _kursusTitel;
        private string _kursusDato;
        private string _kursusTidspunkt;
        private string _kursusVarighed;
        private string _kursusSprog;
        private string _beskrivelse;

        private double _depositum;
        private double _kursusPris;

        private Model.Underviser _kursusUnderviser;
        private Model.Undervisningssted _kursusUndervisningssted;
        #endregion  

        #region Properties
        public string KursusTitel
        {
            get { return _kursusTitel; }
            set
            {
                _kursusTitel = value;
                OnPropertyChanged("KursusTitel");
            }
        }
        public string KursusDato
        {
            get { return _kursusDato; }
            set
            {
                _kursusDato = value;
                OnPropertyChanged("KursusDato");
            }
        }
        public string KursusTidspunkt
        {
            get { return _kursusTidspunkt; }
            set
            {
                _kursusTidspunkt = value;
                OnPropertyChanged("KursusTitel");
            }
        }
        public string KursusVarighed
        {
            get { return _kursusVarighed; }
            set
            {
                _kursusVarighed = value;
                OnPropertyChanged("KursusVarighed");
            }
        }
        public double KursusPris
        {
            get { return _kursusPris; }
            set
            {
                _kursusPris = value;
                OnPropertyChanged("KursusPris");
            }
        }
        public Model.Underviser KursusUnderviser
        {
            get { return _kursusUnderviser; }
            set
            {
                _kursusUnderviser = value;
                OnPropertyChanged("KursusUnderviser");
            }
        }
        public Model.Undervisningssted KursusUndervisningssted
        {
            get { return _kursusUndervisningssted; }
            set
            {
                _kursusUndervisningssted = value;
                OnPropertyChanged("KursusUndervisningssted");
            }
        }

        public string Sprog
        {
            get { return _kursusSprog; }
            set
            {
                _kursusSprog = value;
                OnPropertyChanged("KursusSprog");
            }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set
            {
                _beskrivelse = value;
                OnPropertyChanged("Beskrivelse");
            }
        }

        public double Depositum
        {
            get { return _depositum; }
            set
            {
                _depositum = value;
                OnPropertyChanged("Depositum");
            }
        }
        #endregion

        #region Commands

        public RelayCommand OpretNytKursusCommand { get; set; }

        #endregion

        #region Constructor
        public KursusViewModel()
        {
            _kc = new KursusCatalog();
            OpretNytKursusCommand = new RelayCommand(OpretNytKursus);
        }
        #endregion

        #region Metoder

        private void OpretNytKursus()
        {
            _kc.OpretKursus(_kursusTitel, _kursusDato, _kursusTidspunkt, _kursusVarighed, _kursusPris, _kursusUnderviser, _kursusUndervisningssted, _kursusSprog, _beskrivelse, _depositum);

        }

        #endregion


    }
}
