using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ControlContext context) : base(context) { }

        public ProductRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
