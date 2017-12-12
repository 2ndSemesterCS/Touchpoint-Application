using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.PersistencyInterfaces;
using TouchpointApp.Web;

namespace TouchpointApp.Persistency
{
    public class Catalog
    {
        private List<int> _coll;
        //private IDataSource _source;

        public Catalog(List<int> coll /*,IDataSource source*/)
        {
            _coll = coll;
            //_source = source;
        }
        
    }
}
