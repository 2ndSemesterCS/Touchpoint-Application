
using DataTransformation.Implementation;
using TouchpointApp.Command;
using TouchpointApp.Persistency;
using TouchpointApp.Model;
using TouchpointApp.ViewModel;
using TouchpointApp.Views;
using ViewModel.Implementation;

namespace TouchpointApp.ViewModel 
{
    public class UnderviserViewModel : TransformedBase<Model.Underviser>
    {
        private string _navn;
        private string _Adresse;
        private string _email;
        private string _tlf;

        public override void SetValuesFromObject(Model.Underviser obj)
        {
            _navn = obj.Navn;
            _Adresse = obj.Addresse;
            _email = obj.Email;
            _tlf = obj.Tlf;

        }
   
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _Adresse; }
            set { _Adresse = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

    }
}
