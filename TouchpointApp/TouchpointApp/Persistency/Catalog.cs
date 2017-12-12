using System.Collections.Generic;
using TouchpointApp.Web;

namespace TouchpointApp.Persistency
{
    public class Catalog<T> where T : class 
    {
        private List<T> _coll;
        private WebAPISource<T> _source;

        public Catalog(List<T> coll, WebAPISource<T> source)
        {
            _coll = coll;
            _source = source;
        }

         

    }
}
