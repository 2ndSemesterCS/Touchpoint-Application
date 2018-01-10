using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class KursistCatalog : Catalog<Kursist>
    {

        #region Instance Field
        private static KursistCatalog _kursistCatalog;
        #endregion

        #region Constructor

        public KursistCatalog(string url) : base(url, "Kursists")
        {

        }
        #endregion

        #region SingleTon
        public static KursistCatalog Instance()
        {
            if(_kursistCatalog == null)
            {
                _kursistCatalog = new KursistCatalog("http://touchpointdbwebservice.azurewebsites.net");
            }
            return _kursistCatalog;
        }
        #endregion

        #region Metode
        public void OpretKursist(string navn, string adresse, string email, string tlf, string land, string by)
        {
            //foreach (var item in All)
            //{
            //    if (item.EMail == email)
            //    {
            //        throw new ArgumentException("Email eksisterer allerede i systemet");
            //    }
            //}
            Create(new Kursist(navn, email, by, land, adresse, tlf));
        }
     
        #endregion
    }
}