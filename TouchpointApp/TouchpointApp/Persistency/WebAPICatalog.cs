using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Web;


namespace TouchpointApp.Persistency
{
    public class WebAPICatalog<T> : Catalog<T>
        where T : class
    {
        public WebAPICatalog(string URL, string apiID)
            : base(new Dictionary<int, T>(), new WebAPISource<T>(URL, apiID))
        {

        }
    }
}
