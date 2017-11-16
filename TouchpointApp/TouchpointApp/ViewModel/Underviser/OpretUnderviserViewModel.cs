namespace TouchpointApp.ViewModel.Underviser
{
    class OpretUnderviserViewModel
    {
        private Model.Underviser _underviserReferance;

        public OpretUnderviserViewModel()
        {
                
        }

        public string Navn
        {
            get { return _underviserReferance.Navn; }
            set { _underviserReferance.Navn = value; }
        }
        public string Addresse { get; set; }
        public string Email { get; set; }
    }
}
