namespace TouchpointApp.Model
{
    public class Kursus
    {
        #region Instance Fields
        private string _titel;
        private string _dato;
        private string _tidspunkt;
        private string _varighed;
        private double _pris;

        private Underviser _underviser;
        private Undervisningssted _undervisningssted;
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

        public Underviser Underviser
        {
            get { return _underviser; }
            set { _underviser = value; }
        }

        public Undervisningssted Undervisningssted
        {
            get { return _undervisningssted; }
            set { _undervisningssted = value; }
        }
        #endregion

        #region Constructor
        public Kursus(string titel, string dato, string tidspunkt, string varighed, double pris, Underviser underviser, Undervisningssted undervisningssted)
        {
            _titel = titel;
            _dato = dato;
            _tidspunkt = tidspunkt;
            _varighed = varighed;
            _pris = pris;
            _underviser = underviser;
            _undervisningssted = undervisningssted;
        }
        #endregion  
    }
}