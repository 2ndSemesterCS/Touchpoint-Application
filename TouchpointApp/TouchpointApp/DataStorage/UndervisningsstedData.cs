using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.ViewModel;

namespace TouchpointApp.DataStorage
{
    public class UndervisningsStedData : ViewModelBase
    {
        private string _adresse;
        private string _lokale;

        

        public string Adresse
        {
            get { return _adresse; } set { _adresse = value; OnPropertyChanged("Adresse"); }
        }

        public string Lokale
        {
            get { return _lokale; } set { _lokale = value; OnPropertyChanged("Lokale"); }
        }
    }
}
