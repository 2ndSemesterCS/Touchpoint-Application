using System;
using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class KursusData : ViewModelBase
    {
        #region Instance fields
        private string _titel;
        private string _varighed;
        private double _pris;
        private string _sprog;
        private string _beskrivelse;
        private double _depositum;
        private string _dato;
        private string _tidspunkt;
        private int _underviserKey;
        private int _undervisningsStedKey;
        #endregion

        #region Constructor
        public KursusData()
        {

        }
        #endregion

        #region Properties
        public string Titel { get { return _titel; } set { _titel = value; OnPropertyChanged("titel"); } }
        public string Dato { get { return _dato; } set {_dato = value; OnPropertyChanged("dato"); } }
        public string Tidspunkt { get { return _tidspunkt; } set { _tidspunkt = value; OnPropertyChanged("tidspunkt"); } }
        public string Varighed { get { return _varighed; } set {_varighed = value; OnPropertyChanged("varighed"); } }
        public double Pris { get { return _pris; } set {_pris = value; OnPropertyChanged("pris"); } }
        public string Sprog { get { return _sprog; } set {_sprog = value; OnPropertyChanged("sprog"); } }
        public string Beskrivelse { get { return _beskrivelse; } set {_beskrivelse = value; OnPropertyChanged("beskrivelse"); } }
        public double Depositum { get { return _depositum; } set {_depositum = value; OnPropertyChanged("depositum"); } }
        public int UnderviserKey { get { return _underviserKey; } set { _underviserKey = value; OnPropertyChanged("underviser"); } }
        public int UndervisningsstedKey { get { return _undervisningsStedKey; } set { _undervisningsStedKey = value; OnPropertyChanged("undervisningssted"); } }
        #endregion
    }
}