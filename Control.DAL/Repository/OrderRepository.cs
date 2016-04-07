using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(ControlContext context) : base(context) { }

        public OrderRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
