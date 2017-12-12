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
    private List<Undervisningssted> _usl;
    private static UndervisningsstedCatalog _UndervisningsstedCatalog;
    #endregion

    private UndervisningsstedCatalog()
    {

        _usl = new List<Undervisningssted>();
        _usl.Add(new Undervisningssted("Lokale 207", "Hovedvejen 172, 2600 Glostrup"));  //Hard coded objeket. 
    }

    public static UndervisningsstedCatalog Instance()
    {
        if (_UndervisningsstedCatalog == null)
        {
            _UndervisningsstedCatalog = new UndervisningsstedCatalog();

        }
        return _UndervisningsstedCatalog;
    }
 
    public List<Undervisningssted> Getlist
    {
        get { return _usl; }
        set { _usl = value; }
    }

    public List<Undervisningssted> All
    { get; set; }


    #region Metoder

    public void OpretUndervisningssted(string lokale, string adresse)
    {
        Undervisningssted undervisningssted = new Undervisningssted(lokale, adresse);
        _usl.Add(undervisningssted);
    }
    #endregion

}



