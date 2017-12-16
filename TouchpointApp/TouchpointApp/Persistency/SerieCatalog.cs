using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
   public class SerieCatalog : Catalog<Serie>
    {
        #region Instance fields
        private static SerieCatalog _SerieCatalog;

        #endregion

        public static SerieCatalog Instance()
        {
            if (_SerieCatalog == null)
            {
                _SerieCatalog = new SerieCatalog("http://touchpointdbwebservice.azurewebsites.net");
            }
            return _SerieCatalog;
        }

        #region Constructor
        private SerieCatalog(string url) : base(url, "Series")
        {

        }
        #endregion

        #region Metode
        

        public void Create(List<Kursus> kursusSerie, string beskrivelse)
        {
            Create(new Serie(kursusSerie, beskrivelse));
        }
        #endregion
    }
}
