using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(ControlContext context) : base(context) { }

        public CustomerRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
