using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.ViewModel.LokaleViewModel
{
    public class LokaleViewModel : ViewModelBase
    {

        #region Instance Fields
        private string _navn;
        private int _lokaleId;
        #endregion

        #region Properties
        public string Navn
        {
            get { return _navn; }
            set
            {
                _navn = value;
                OnPropertyChanged("Lokale navn");
            }
        }

        public int LokaleId
        {
            get { return _lokaleId; }
            set
            {
                _lokaleId = value;
                OnPropertyChanged("Lokale ID");
            }
        }

        #endregion



    }
}
