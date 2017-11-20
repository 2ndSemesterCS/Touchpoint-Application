using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.UndervisningsstedViewModel
{
    public class UndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields

        private UndervisningsstedCatalog _uc;

        private Lokale _lokale;
        private string _adresse;
        #endregion

        public Lokale Lokale
        {
            get { return _lokale; }
            set
            {
                _lokale = value;
                OnPropertyChanged("Lokale");
            }
        }

        public string Adresse
        {
            get { return _adresse; }
            set
            {
                _adresse = value;
                OnPropertyChanged("Adresse");
            }
        }

        public void OpretNytUndervisningssted()
        {
            _uc.OpretUndervisningssted(_adresse, _lokale);
        }

    }
}
