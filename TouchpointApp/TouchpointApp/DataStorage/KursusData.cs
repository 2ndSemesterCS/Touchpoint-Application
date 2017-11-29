using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage 
{
    public class KursusData : ViewModelBase
    {
        private string _titel;
        private string _dato;
        private string _tidspunkt;
        private string _varighed;
        private double _pris;
        private string _sprog;
        private string _beskrivelse;
        private double _depositum;

        private Model.Underviser _underviser;
        private Model.Undervisningssted _undervisningssted;

        public KursusData()
        {

        }

        public string Titel { get { return _titel; } set { value = _titel; OnPropertyChanged("titel");}}
        public string Dato { get { return _dato; } set { value = _dato; OnPropertyChanged("dato");}}
        public string Tidspunkt { get { return _tidspunkt; } set { value = _tidspunkt; OnPropertyChanged("tidspunkt");}}
        public string Varighed { get { return _varighed; } set { value = _varighed; OnPropertyChanged("varighed");}}
        public double Pris { get { return _pris; } set { value = _pris; OnPropertyChanged("pris");}}
        public string Sprog { get { return _sprog;} set { value = _sprog; OnPropertyChanged("sprog");}}
        public string Beskrivelse { get { return _beskrivelse; } set { value = _beskrivelse; OnPropertyChanged("beskrivelse");}}
        public double Depositum { get { return _depositum; } set { value = _depositum; OnPropertyChanged("depositum"); } }
        public Model.Underviser Underviser { get { return _underviser; } set { value = _underviser; OnPropertyChanged("underviser");}}
        public Model.Undervisningssted Undervisningssted { get { return _undervisningssted; } set { value = _undervisningssted; OnPropertyChanged("undervisningssted");}}
    }
}