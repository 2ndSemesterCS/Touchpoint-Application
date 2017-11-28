namespace TouchpointApp.DataStorage
{
    public class UndervisningsstedData
    {
        #region Instance Fields
        private string _lokale;
        private string _adresse;
        #endregion

        #region properties
        public string Lokale
        {
            get { return _lokale; }
            set { _lokale = value;}
        }


        public string Adresse
        {
            get { return _adresse; }
            set
            { _adresse = value;}
        }
        #endregion
    }
}