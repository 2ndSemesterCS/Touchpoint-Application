using System.Collections.Generic;
using System.Linq;
using TouchpointApp.Model;
using TouchpointApp.Web;

namespace TouchpointApp.Persistency
{
    public class Catalog<T> where T : class, IKey 
    {
        private Dictionary<int, T> _coll;
        private WebAPISource<T> _source;

        public Catalog(string url, string apiid)
        {
            _coll = new Dictionary<int, T>();
            _source = new WebAPISource<T>(url, apiid);
        }

        public List<T> All
        {
            get { return _coll.Values.ToList(); }
        }

        public async void Create(T obj)
        {
            int key = await _source.Create(obj);
            obj.Key = key;
            _coll.Add(key, obj);
        }

        public async void Delete(int key)
        {
            _coll.Remove(key);
            await _source.Delete(key);
        }

    }
}
