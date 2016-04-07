using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class VendorRepository : Repository<Vendor>
    {
        public VendorRepository(ControlContext context) : base(context) { }

        public VendorRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
