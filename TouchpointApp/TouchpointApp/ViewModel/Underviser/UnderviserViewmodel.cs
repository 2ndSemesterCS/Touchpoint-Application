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
        public UnderviserData _underviserData;
        public UnderviserCatalog _underviserCatalog;

        public UnderviserViewmodel()
        {
            _underviserCatalog = new UnderviserCatalog();
            _underviserData = new UnderviserData();
            OpretNyUnderviserCommand = new RelayCommand(OpretNyUnderviser);
        }

        public RelayCommand OpretNyUnderviserCommand { get; set; }
        public UnderviserData UnderviserData { get { return _underviserData; } set { _underviserData = value; } }

        public void OpretNyUnderviser()
        {
            _underviserCatalog.OpretKursus(_underviserData.Navn, _underviserData.Adresse, _underviserData.Email, _underviserData.Tlf);
        }
    }
}
