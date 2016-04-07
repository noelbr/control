using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Model.Entities
{
    [DataContract]
    public class Vendor : IEntity
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal PercentCommission { get; set; }
        public bool  Active { get; set; }
    }
}
