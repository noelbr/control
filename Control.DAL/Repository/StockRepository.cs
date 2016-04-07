using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class StockRepository : Repository<Stock>
    {
        public StockRepository(ControlContext context) : base(context) { }

        public StockRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
