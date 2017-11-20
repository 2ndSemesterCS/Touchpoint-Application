using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.ViewModel.Kursist
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields
        private Model.Kursisten _kursist;
        #endregion

        #region Properties
        public int KursistId
        {
            get { return _kursist.KursistId; }
        }

        public string Email
        {
            get { return _kursist.Email; }
            set { _kursist.Email = value; OnPropertyChanged("Email opdateret"); }
        }

        public string Telefon
        {
            get { return _kursist.Telefon; }
            set { _kursist.Telefon = value; OnPropertyChanged("Telefon opdateret"); }
        }

        public string Navn
        {
            get { return _kursist.Navn; }
            set { _kursist.Navn = value; OnPropertyChanged("Navn opdateret"); }
        }

        #endregion

    }
}
