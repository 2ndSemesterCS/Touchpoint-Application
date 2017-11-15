namespace TouchpointApp.Model
{
    public class Kursist
    {
        // Instance Fields

        private int _id;
        private string _navn;
        private string _eMail;
        private string _by;
        private string _land;

        // Properties

        public int ID { get; set; }
        public string Navn { get; set; }
        public string EMail { get; set; }
        public string By { get; set; }
        public string Land { get; set; }

        // Constructor

        public Kursist(int id, string navn, string email, string by, string land)
        {
            id = _id;
            navn = _navn;
            email = _eMail;
            by = _by;
            land = _land;
        }
    }
}