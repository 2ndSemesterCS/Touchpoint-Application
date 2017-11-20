using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.ViewModel
{
    public class KursusViewModel : ViewModelBase
    {
        #region Instance Fields
        private string _kursusTitel;
        private string _kursusDato;
        private string _kursusTidspunkt;
        private string _kursusVarighed;

        private double _kursusPris;

        private Model.Underviser _kursusUnderviser;
        private Model.Undervisningssted _kursusUndervisningssted;
        #endregion  

        #region Properties
        public string KursusTitel
        {
            get { return _kursusTitel; }
            set
            {
                _kursusTitel = value;
                OnPropertyChanged("KursusTitel");
            }
        }
        public string KursusDato
        {
            get { return _kursusDato; }
            set
            {
                _kursusDato = value;
                OnPropertyChanged("KursusDato");
            }
        }
        public string KursusTidspunkt
        {
            get { return _kursusTidspunkt; }
            set
            {
                _kursusTidspunkt = value;
                OnPropertyChanged("KursusTitel");
            }
        }
        public string KursusVarighed
        {
            get { return _kursusVarighed; }
            set
            {
                _kursusVarighed = value;
                OnPropertyChanged("KursusVarighed");
            }
        }
        public double KursusPris
        {
            get { return _kursusPris; }
            set
            {
                _kursusPris = value;
                OnPropertyChanged("KursusPris");
            }
        }
        public Model.Underviser KursusUnderviser
        {
            get { return _kursusUnderviser; }
            set
            {
                _kursusUnderviser = value;
                OnPropertyChanged("KursusUnderviser");
            }
        }
        public Model.Undervisningssted KursusUndervisningssted
        {
            get { return _kursusUndervisningssted; }
            set
            {
                _kursusUndervisningssted = value;
                OnPropertyChanged("KursusUndervisningssted");
            }
        }
        #endregion 
    }
}
