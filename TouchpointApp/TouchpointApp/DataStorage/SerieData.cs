using TouchpointApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchpointApp.DataStorage
{
    public class SerieData : ViewModelBase
    {
        #region Instance Fields
        private string _beskrivelse;
        private List<Model.Kursus> _kursusSerie;
        #endregion

        #region Constructor
        public SerieData()
        {

        }
        #endregion

        #region Properties
        public string Beskrivelse { get { return _beskrivelse; } set { _beskrivelse = value; OnPropertyChanged("beskrivelse");}}
        public List<Model.Kursus> KursusSerie { get { return _kursusSerie; } set { _kursusSerie = value; OnPropertyChanged("kursusserie");}}
        #endregion
    }
}