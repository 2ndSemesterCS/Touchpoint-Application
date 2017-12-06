using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Model;

namespace TouchpointApp.Persistency
{
    public class UnderviserSource
    {
        private FilePersistency<Underviser> _filePersistor;

        public UnderviserSource()
        {
            _filePersistor = new FilePersistency<Underviser>();
        }

        public async Task Load(UnderviserCatalog model)
        {
            List<Underviser> underviserList = await _filePersistor.Load();
            foreach(Underviser u in underviserList)
            {
                model.Getlist.Add(u);
            }
        }

        public async Task Save(UnderviserCatalog model)
        {
            await _filePersistor.Save(model.All);
        }
    }
}
