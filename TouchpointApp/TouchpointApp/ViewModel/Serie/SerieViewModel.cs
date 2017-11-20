using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.ViewModel.Serie
{
    public class SerieViewModel : ViewModelBase
    {
        #region Instance Fields
        private string _beskrivelse;

        private int _serieId;

        private Model.Kursus _kursus;

        #endregion

        #region Properties
        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set
            {
                _beskrivelse = value;
                OnPropertyChanged("Beskrivelse");
            }
        }
        public int SerieID
        {
            get { return _serieId; }
            set
            {
                _serieId = value;
                OnPropertyChanged("SerieID");
            }
        }
        public Model.Kursus Kursus
        {
            get { return _kursus; }
            set
            {
                _kursus = value;
                OnPropertyChanged("Kursus");
            }

            #endregion
        }
    }
}
