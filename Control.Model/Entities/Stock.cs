﻿using System;
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
    public class Stock : IEntity
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
    }
}