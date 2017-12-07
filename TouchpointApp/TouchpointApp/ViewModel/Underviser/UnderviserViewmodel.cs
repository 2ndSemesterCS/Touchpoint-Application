using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using TouchpointApp.Web;
using System.Windows.Input;


namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserViewmodel
    {
        private UnderviserData _underviserData;
        private UnderviserCatalog _underviserCatalog;
        private RelayCommand _loadCommand;
        private RelayCommand _saveCommand;

        public UnderviserViewmodel()
        {
            //singelton method is used. 
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
