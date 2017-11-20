namespace TouchpointApp.ViewModel.Underviser
{
    public class UnderviserViewModel : ViewModelBase
    {
        #region Instandsfields
        //Referance to our underviser class, need it for our propperties in the viewmodel.
        private Model.Underviser _underviser;
        #endregion

        #region Propperties For Navn, Addresse, Email Og Id 

        // The id, is not changeable (thats why we only have a get) 
        public int Id
        {
            get { return _underviser.UnderviserId; }
        }
        public string Navn
        {
            get { return _underviser.Navn; }
            set
            {
                _underviser.Navn = value;
                OnPropertyChanged("Navn opdateret");
            }
        }

        public string Addresse
        {
            get { return _underviser.Addresse; }
            set
            {
                _underviser.Addresse = value;
                OnPropertyChanged("Addresse opdateret");
            }
        }
        public string Email
        {
            get { return _underviser.Email; }
            set
            {
                _underviser.Email = value;
                OnPropertyChanged("Email opdateret");
            }
        }
        #endregion

        public void OpretUnderviser()
        {
          
        }



    }
}
