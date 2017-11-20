using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.ViewModel.Kursist
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields
        private Model.Kursist _kursist;
        #endregion

        #region Properties
        public string Email
        {
            get { return _kursist.EMail; }
            set { _kursist.EMail = value; OnPropertyChanged("Email opdateret"); }
        }

        public string Telefon
        {
            get { return _kursist.Tlf; }
            set { _kursist.Tlf = value; OnPropertyChanged("Telefon opdateret"); }
        }

        public string Navn
        {
            get { return _kursist.Navn; }
            set { _kursist.Navn = value; OnPropertyChanged("Navn opdateret"); }
        }

        #endregion

    }
}
