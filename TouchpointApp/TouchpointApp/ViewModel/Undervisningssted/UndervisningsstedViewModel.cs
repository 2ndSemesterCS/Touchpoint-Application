using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    public class UndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields

        private UndervisningsstedCatalog _uc;

        private string _tlf;
        private string _email;
        private string _adresse;
        #endregion
        public string Tlf
        {
            get { return _tlf; }
            set
            {
                _tlf = value;
                OnPropertyChanged("Telefon");
            }

        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
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
            _uc.OpretUndervisningssted(_tlf, _email, _adresse);
        }

    }
}
