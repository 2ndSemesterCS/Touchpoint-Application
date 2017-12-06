using TouchpointApp.DataStorage;
using TouchpointApp.Persistency;
using TouchpointApp.Command;
using System.Windows.Input;

namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserViewmodel
    {
        private UnderviserData _underviserData;
        private UnderviserCatalog _underviserCatalog;
        private UnderviserSource _source;
        private RelayCommand _loadCommand;
        private RelayCommand _saveCommand;

        public UnderviserViewmodel()
        {
            _underviserCatalog = new UnderviserCatalog();
            _underviserData = new UnderviserData();
            OpretNyUnderviserCommand = new RelayCommand(OpretNyUnderviser);
            _loadCommand = new RelayCommand(Load);
            _saveCommand = new RelayCommand(Save);
        }

        public RelayCommand OpretNyUnderviserCommand { get; set; }
        public ICommand LoadCommand { get { return _loadCommand; } }
        public ICommand SaveCommand { get { return _saveCommand; } }


        public UnderviserData UnderviserData { get { return _underviserData; } set { _underviserData = value; } }

        public void OpretNyUnderviser()
        {
            _underviserCatalog.OpretKursus(_underviserData.Navn, _underviserData.Adresse, _underviserData.Email, _underviserData.Tlf);
        }

        private async void Load()
        {
            await _source.Load(_underviserCatalog);
        }

        private async void Save()
        {
            await _source.Save(_underviserCatalog);
        }
    }
}
