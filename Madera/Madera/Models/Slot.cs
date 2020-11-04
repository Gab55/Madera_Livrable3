﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Madera.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public string LibelleSlot { get; set; }

        [ForeignKey("ModuleID")]
        public virtual Module module { get; set; }
    }
}
