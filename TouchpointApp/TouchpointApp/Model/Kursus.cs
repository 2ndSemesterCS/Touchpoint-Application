namespace TouchpointApp.Model
{
    public class Kursus
    {
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
            Titel = titel;
            Dato = dato;
            Tidspunkt = tidspunkt;
            Varighed = varighed;
            Pris = pris;
            Underviser = underviser;
            Undervisningssted = undervisningssted;
        }

    }
}