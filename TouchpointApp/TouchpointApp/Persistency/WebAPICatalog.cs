using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;
using TouchpointApp.Web;


namespace TouchpointApp.Persistency
{
    public class WebAPICatalog<T> : Catalog<T> where T : class, IKey
    {
        public WebAPICatalog(string url, string apiID)
            : base(url, apiID)
        {
        }
    }
}
