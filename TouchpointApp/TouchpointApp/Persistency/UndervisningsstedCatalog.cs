using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;


public class UndervisningsstedCatalog
{
    #region Instance Fields
    private List<Undervisningssted> __usl;
    private static UndervisningsstedCatalog _UndervisningsstedCatalog;
    #endregion

    private UndervisningsstedCatalog()
    {

        __usl = new List<Undervisningssted>();
    }

    public static UndervisningsstedCatalog Instance()
    {
        if (_UndervisningsstedCatalog == null)
        {
            _UndervisningsstedCatalog = new UndervisningsstedCatalog();

        }
        return _UndervisningsstedCatalog;
    }
    #region Constructor
 
    #endregion
    public List<Undervisningssted> Getlist
    {
        get { return __usl; }
        set { __usl = value; }
    }

    public List<Undervisningssted> All
    { get; set; }


    #region Metoder

    public void OpretUndervisningssted(string lokale, string adresse)
    {
        Undervisningssted undervisningssted = new Undervisningssted(lokale, adresse);
        __usl.Add(undervisningssted);
    }
    #endregion

}



