﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Staff")]
    public class Staff
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
}
