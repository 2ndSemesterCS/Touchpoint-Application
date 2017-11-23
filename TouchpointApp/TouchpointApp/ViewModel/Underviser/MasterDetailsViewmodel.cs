using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsViewModel.Implementation;
using ViewModel.Interfaces;

namespace TouchpointApp.ViewModel.Underviser
{
    class MasterDetailsViewmodel : MasterDetailsViewModelCRUD<Model.Underviser, UnderviserViewModel, Model.Underviser>

    {
        public MasterDetailsViewmodel()
            : base(new ViewmodelFactory()
        {
        }

    }
}
