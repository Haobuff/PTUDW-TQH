﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClass.Model
{
    [Table("Links")]
    public class Links
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Slug {  get; set; }
        public int? Tableld { get; set; }
        public string Type {  get; set; }

    }
}
