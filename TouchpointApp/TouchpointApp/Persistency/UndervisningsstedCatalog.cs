using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;
using TouchpointApp.Persistency;

public class UndervisningsstedCatalog : Catalog<Undervisningssted>
{
    #region Instance Fields
    private List<Undervisningssted> _usl;
    private static UndervisningsstedCatalog _UndervisningsstedCatalog;
    #endregion

    #region Constructor
    private UndervisningsstedCatalog(string url) : base(url, "Undervisningssted")
    {

        
    }
    #endregion

    #region Singleton
    public static UndervisningsstedCatalog Instance()
    {
        if (_UndervisningsstedCatalog == null)
        {
            _UndervisningsstedCatalog = new UndervisningsstedCatalog("http://touchpointdbwebservice.azurewebsites.net/");

        }
        return _UndervisningsstedCatalog;
    }
    #endregion




    #region Metoder

    public void OpretUndervisningssted(string lokale, string adresse)
    {
       Create(new Undervisningssted(lokale, adresse));
    }
    #endregion

}



