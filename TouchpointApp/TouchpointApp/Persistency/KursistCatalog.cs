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

     
    }
}