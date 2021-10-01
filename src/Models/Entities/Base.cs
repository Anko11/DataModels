﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public abstract class Base
    {
        [Key]
        public Guid Id { get; }
        [MaxLength(25)]
        public String Name { get; set; }
    }
   
}
