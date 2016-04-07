using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class TypeUnitRepository : Repository<TypeUnit>
    {
        public TypeUnitRepository(ControlContext context) : base(context) { }

        public TypeUnitRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
