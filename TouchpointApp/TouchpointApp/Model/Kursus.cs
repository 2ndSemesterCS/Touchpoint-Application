using System;
namespace TouchpointApp.Model
   
{
    public class Kursus : IKey
    {
        #region Instance Fields
        private string _titel;
        private string _dato;
        private string _tidspunkt;
        private string _varighed;
        private double _pris;
        private string _sprog;
        private string _beskrivelse;
        private double _depositum;

        private int _underviserKey;
        private int _undervisningsstedKey;

        private int _KursusID;
        #endregion

        #region Properties
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public string Tidspunkt
        {
            get { return _tidspunkt; }
            set { _tidspunkt = value; }
        }

        public string Varighed
        {
            get { return _varighed; }
            set { _varighed = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public int UnderviserKey
        {
            get { return _underviserKey; }
            set { _underviserKey = value; }
        }
      
        public string Sprog
        {
            get { return _sprog; }
            set { _sprog = value; }
        }
        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }
        public double Depositum
        {
            get { return _depositum; }
            set { _depositum = value; }
        }
        public int UndervisningsstedKey
        {
            get { return _underviserKey; }
            set { _underviserKey = value; }
        }
        public int Key
        {
            get { return _KursusID; }
            set { _KursusID = value; }
        }
        public int KursusID
        {
            get { return _KursusID; }
            set { _KursusID = value; }
        }
        #endregion

        #region Constructor
        public Kursus(string titel, string dato, string tidspunkt, string varighed, 
            double pris, string sprog, string beskrivelse, double depositum, int underviser, int undervisningssted)
        {
            //if (String.IsNullOrEmpty(titel)|| String.IsNullOrEmpty(varighed) || String.IsNullOrEmpty(sprog) 
            //    || String.IsNullOrEmpty(beskrivelse) || pris < 0 || underviser == null 
            //    || undervisningssted == null || depositum < 0)
            //{ 
            //    throw new ArgumentException("Information mangler");
            //}
            _titel = titel;
            _dato = dato;
            _tidspunkt = tidspunkt;
            _varighed = varighed;
            _pris = pris;
            _underviserKey = underviser;
            _undervisningsstedKey = undervisningssted;
            _sprog = sprog;
            _beskrivelse = beskrivelse;
            _depositum = depositum;

        }
        #endregion

        //public void KunTalIPris(double pris)
        //{
        //    int value;
        //    if(!int.TryParse(pris, out value))
        //    {

        //    }
        //}

        #region Metode
        public override string ToString()
        {
            return $"{_titel}";
        }
        #endregion

        
    }
}