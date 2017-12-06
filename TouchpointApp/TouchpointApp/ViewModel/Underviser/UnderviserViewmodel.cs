using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.ViewModel.Underviser;

namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserViewmodel
    {
        private UnderviserData _underviserData;
        private UnderviserCatalog _underviserCatalog;

        public UnderviserViewmodel()
        {
            //singelton methon is used. 
            _underviserCatalog = UnderviserCatalog.Instance();
            _underviserData = new UnderviserData();
            OpretNyUnderviserCommand = new RelayCommand(OpretNyUnderviser);
        }

        //Propperty with type relaycommand, so we can bind our creat method to a buttom. 
        public RelayCommand OpretNyUnderviserCommand { get; set; }
        public UnderviserData UnderviserData { get { return _underviserData; } set { _underviserData = value; } }

        public void OpretNyUnderviser()
        {
            _underviserCatalog.OpretUnderviser(_underviserData.Navn, _underviserData.Adresse, _underviserData.Email, _underviserData.Tlf);
        }
    }
}
