using TouchpointApp.Persistency;
using TouchpointApp.Model;

namespace TouchpointApp.DataStorage
{
    public class KursusData
    {
        #region Instance Fields

        private string _kursusTitel;
        private string _kursusDato;
        private string _kursusTidspunkt;
        private string _kursusVarighed;
        private string _kursusSprog;
        private string _beskrivelse;

        private double _depositum;
        private double _kursusPris;

        private Underviser _kursusUnderviser;
        private Undervisningssted _kursusUndervisningssted;

        #endregion

        #region Properties

        public string KursusTitel
        {
            get { return _kursusTitel; }
            set
            {
                _kursusTitel = value;
            }
        }
        public string KursusDato
        {
            get { return _kursusDato; }
            set
            {
                _kursusDato = value;
            }
        }
        public string KursusTidspunkt
        {
            get { return _kursusTidspunkt; }
            set
            {
                _kursusTidspunkt = value;
            }
        }
        public string KursusVarighed
        {
            get { return _kursusVarighed; }
            set
            {
                _kursusVarighed = value;
            }
        }
        public double KursusPris
        {
            get { return _kursusPris; }
            set
            {
                _kursusPris = value;
            }
        }
        public Model.Underviser KursusUnderviser
        {
            get { return _kursusUnderviser; }
            set
            {
                _kursusUnderviser = value;
            }
        }
        public Model.Undervisningssted KursusUndervisningssted
        {
            get { return _kursusUndervisningssted; }
            set
            {
                _kursusUndervisningssted = value;
            }
        }

        public string Sprog
        {
            get { return _kursusSprog; }
            set
            {
                _kursusSprog = value;
            }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set
            {
                _beskrivelse = value;
            }
        }

        public double Depositum
        {
            get { return _depositum; }
            set
            {
                _depositum = value;
            }
        }

        #endregion

    }
}