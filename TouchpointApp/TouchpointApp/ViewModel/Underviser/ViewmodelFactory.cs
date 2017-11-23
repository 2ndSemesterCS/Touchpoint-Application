using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ViewModel.Implementation;

namespace TouchpointApp.ViewModel.Underviser
{
    class ViewmodelFactory : ViewModelFactoryBase<Model.Underviser, UnderviserViewModel>
    {
        public override IDataWrapper<UnderviserViewModel> CreateDetailsViewModel(UnderviserViewModel obj)
        {
            return new UnderviserDetailsViewmodel(obj);
        }

        public override IDataWrapper<UnderviserViewModel> CreateItemViewModel(UnderviserViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
