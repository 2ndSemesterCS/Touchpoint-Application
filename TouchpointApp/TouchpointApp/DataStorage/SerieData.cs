using TouchpointApp.Persistency;
using TouchpointApp.Model;

namespace TouchpointApp.DataStorage
{
    public class SerieData
    {
        #region Instance fields
        private string _beskrivelse;

        private Kursus _kursus;
        #endregion

        #region Propperties
        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set
            {
                _beskrivelse = value;

            }
        }

        public Model.Kursus Kursus
        {
            get { return _kursus; }
            set
            {
                _kursus = value;

            }
            #endregion
        }
    }
}