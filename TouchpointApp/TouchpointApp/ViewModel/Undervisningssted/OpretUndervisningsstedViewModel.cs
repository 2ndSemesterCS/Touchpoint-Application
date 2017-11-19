using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.ViewModel.Undervisningssted
{
    class OpretUndervisningsstedViewModel : ViewModelBase
    {

        #region Instance Fields
        public string _tlf;
        public string _email;
        public string _adresse;
        public int _undervisningsstedID;
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

        public int UndervisningsstedID
        {
            get { return _undervisningsstedID; }
            set
            {
                _undervisningsstedID = value;
                OnPropertyChanged("UndervisningsstedID");
            }
        }
    }
}
