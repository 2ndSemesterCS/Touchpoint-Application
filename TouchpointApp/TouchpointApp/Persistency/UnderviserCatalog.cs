using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransformation.Interfaces;
using ExtensionsModel.Implementation;
using TouchpointApp.Model;
using TouchpointApp.Views;

namespace TouchpointApp.Persistency
{
    public class UnderviserCatalog : FilePersistableCatalogNoDTO<Underviser, UnderviserView>
    {
        public UnderviserCatalog(IFactory<Underviser, UnderviserView> vmFactory) : base(vmFactory)
        {
        }
    }
}
