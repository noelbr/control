using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class StorageRepository : Repository<Storage>
    {
        public StorageRepository(ControlContext context) : base(context) { }

        public StorageRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
