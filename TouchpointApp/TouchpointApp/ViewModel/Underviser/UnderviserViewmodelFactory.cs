using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Implementation;
using TouchpointApp.Views.Undervisningssted;

namespace TouchpointApp.ViewModel.Underviser
{
    class UnderviserViewmodelFactory : FactoryBase<Model.Underviser, UnderviserViewModel> 
    {
        public override Model.Underviser CreateDomainObject(UnderviserViewModel tObj)
        {
            return new Model.Underviser(tObj.Navn, tObj.Adresse, tObj.Email, tObj.Tlf);
        }
    }
}
