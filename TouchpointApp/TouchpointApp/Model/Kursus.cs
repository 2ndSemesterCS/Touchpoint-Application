namespace TouchpointApp.Model
{
    public class Kursus
    {
        // Instance Fields
        private string _titel;
        private string _dato;
        private string _tidspunkt;
        private string _varighed;

        private double _pris;

        private Underviser _underviser;
        private Undervisningssted _undervisningssted;


        // Properties
        public string Titel { get; set; }
        public string Dato { get; set; }
        public string Tidspunkt { get; set; }
        public string Varighed { get; set; }

        public double Pris { get; set; }

        public Underviser Underviser { get; set; }
        public Undervisningssted Undervisningssted { get; set; }

        // Constructor
        public Kursus(string titel, string dato, string tidspunkt, string varighed, double pris, Underviser underviser, Undervisningssted undervisningssted)
        {
            titel = _titel;
            dato = _dato;
            tidspunkt = _tidspunkt;
            varighed = _varighed;
            pris = _pris;
            underviser = _underviser;
            undervisningssted = _undervisningssted;
        }

    }
}