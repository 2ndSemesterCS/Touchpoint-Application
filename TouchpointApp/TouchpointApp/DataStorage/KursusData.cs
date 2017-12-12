using System;
using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class KursusData : ViewModelBase
    { 
        private string _titel;
        private string _varighed;
        private double _pris;
        private string _sprog;
        private string _beskrivelse;
        private double _depositum;
        private DateTime _dato;
        private DateTime _tidspunkt;

        private Model.Underviser _underviser;
        private Model.Undervisningssted _undervisningssted;

        

        #region Constructor
        public KursusData()
        {

        }
        #endregion

        #region Properties





        public string Titel { get { return _titel; } set { _titel = value; OnPropertyChanged("titel"); } }

        public DateTime Dato { get { return _dato; } set {_dato = value; OnPropertyChanged("dato"); } }
        public DateTime Tidspunkt { get { return _tidspunkt; } set { _tidspunkt = value; OnPropertyChanged("tidspunkt"); } }

        public string Varighed { get { return _varighed; } set {_varighed = value; OnPropertyChanged("varighed"); } }
        public double Pris { get { return _pris; } set {_pris = value; OnPropertyChanged("pris"); } }
        public string Sprog { get { return _sprog; } set {_sprog = value; OnPropertyChanged("sprog"); } }
        public string Beskrivelse { get { return _beskrivelse; } set {_beskrivelse = value; OnPropertyChanged("beskrivelse"); } }
        public double Depositum { get { return _depositum; } set {_depositum = value; OnPropertyChanged("depositum"); } }
        public Model.Underviser Underviser { get { return _underviser; } set {_underviser = value; OnPropertyChanged("underviser"); } }
        public Model.Undervisningssted Undervisningssted { get { return _undervisningssted; } set {_undervisningssted = value; OnPropertyChanged("undervisningssted"); } }
        #endregion
    }
}