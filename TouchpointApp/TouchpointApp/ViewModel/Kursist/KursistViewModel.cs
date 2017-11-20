using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;
using TouchpointApp.Model;
using TouchpointApp.Persistency;

namespace TouchpointApp.ViewModel.KursistViewModel
{
    public class KursistViewModel : ViewModelBase
    {
        #region Instance Fields

        private KursistCatalog _kursistCatalog;
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

        #region Commands
        public RelayCommand OpretNyKursistCommand { get; set; }
        #endregion

        #region Constructor

        public KursistViewModel()
        {
            _kursistCatalog = new KursistCatalog();
            OpretNyKursistCommand = new RelayCommand(OpretNyKursist);
        }
        #endregion

        #region Metoder

        public void OpretNyKursist()
        {
            _kursistCatalog.OpretKursist(Navn, Email, _kursist.By, _kursist.Land, _kursist.Adresse, Telefon);
        }

        #endregion
    }
}
