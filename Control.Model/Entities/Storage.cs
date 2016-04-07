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
    public class Storage : IEntity
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        //Forgein Keys
        public int? ProductID { get; set; }
        
        [ForeignKey("Id Produto")]
        public virtual Product ProductUnit { get; set; }

        public int? TypeUnitID { get; set; }
        public virtual Unit TypeUnit { get; set; }

        public decimal Quantity { get; set; }
    }
}
