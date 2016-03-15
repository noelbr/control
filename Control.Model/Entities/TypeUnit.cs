using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Model.Entities
{
    public class TypeUnit : IEntity 
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Sign { get; set; }
    }
}
