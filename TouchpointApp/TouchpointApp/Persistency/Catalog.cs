using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchpointApp.Web;

namespace TouchpointApp.Persistency
{
    public class Catalog<T>
        where T : class 
    {
        private IDictionary<int, T> _coll;
        private IDataSource<T> _source;

        public Catalog(IDictionary<int, T> coll, IDataSource<T> source)
        {
            _coll = coll;
            _source = source;
        }

        public void Create(T obj)
        {
            _source.Create(obj);
            
            //TODO: Return key from _source and use in Coll.

            _coll.Add(2,obj);
            
        }

        public void Read(int key)
        {
            
            _source.Read(key);
        }

        public void Update()
        {
            
        }

        public void Delete(int key)
        {
            _coll.Remove(key);
            _source.Delete(key);
        }

    }
}
