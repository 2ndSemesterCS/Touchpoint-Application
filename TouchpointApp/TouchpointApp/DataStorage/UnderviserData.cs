namespace TouchpointApp.DataStorage
{
    public class UnderviserData
    {
        private string _navn;
        private string _addresse;
        private string _email;
        private string _tlf;

        public UnderviserData()
        {

        }

        public string Navn { get { return _navn; } set { _navn = value; } }
        public string Adresse { get { return _addresse; } set { _addresse = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Tlf { get { return _email; } set { _email = value; } }


    }
}