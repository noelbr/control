using Control.DAL.Data;
using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.DAL.Repository
{
    public class CountryRepository : Repository<Country>
    {
        public CountryRepository(ControlContext context) : base(context) { }

        public CountryRepository()
        {
            base.Context = new ControlContext();
        }
    }
}
