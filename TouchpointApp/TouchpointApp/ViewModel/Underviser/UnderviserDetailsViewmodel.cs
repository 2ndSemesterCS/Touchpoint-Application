using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Implementation;

namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserDetailsViewmodel : DetailsViewModelBase<UnderviserViewModel>
    {
        public UnderviserDetailsViewmodel(UnderviserViewModel obj) : base(obj)
        {
        }
        public string Navn
        {
            get { return DataObject.Navn; }
            set
            {
                DataObject.Navn = value;
                OnPropertyChanged();
            }
        }

        public string Adresse
        {
            get { return DataObject.Adresse; }
            set
            {
                DataObject.Adresse = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value; 
                OnPropertyChanged();
            }
        }
        public string Tlf
        {
            get { return DataObject.Tlf; }
            set
            {
                DataObject.Tlf = value;
                OnPropertyChanged();
            }
        }
    }
}
