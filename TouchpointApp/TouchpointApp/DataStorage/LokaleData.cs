using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class LokaleData : ViewModelBase
    {
        #region Instance Field
        private string _navn;
        #endregion

        #region Constructor
        public LokaleData()
        {

        }
        #endregion

        #region Property
        public string Navn { get { return _navn; } set { _navn = value; OnPropertyChanged("navn"); } }
        #endregion
    }
}
