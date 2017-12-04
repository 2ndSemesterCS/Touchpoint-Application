using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Persistency;
using TouchpointApp.DataStorage;
using TouchpointApp.Command;
using TouchpointApp.ViewModel.Undervisningssted;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    public class UndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields
        private UndervisningsStedData _undervisningsstedData;
        private UndervisningsstedCatalog _undervisningsstedCatalog;

        #endregion

        public UndervisningsstedViewModel()
        {
            _undervisningsstedCatalog = new UndervisningsstedCatalog();
            _undervisningsstedData = new UndervisningsStedData();
            OpretNytUndervisningsstedCommand = new RelayCommand(OpretNytUndervisningssted); 
        }
        public RelayCommand OpretNytUndervisningsstedCommand { get; set; }
        public UndervisningsStedData GetUndervisningsStedData { get { return _undervisningsstedData; } set { _undervisningsstedData = value; } }



        public void OpretNytUndervisningssted()
        {
            _undervisningsstedCatalog.OpretUndervisningssted(_undervisningsstedData.Adresse, _undervisningsstedData.Lokale);
        }

    }
}
