﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClass.Model
{
    [Table("Orderdetails")]
    public class Orderdetails
    {
        [Key]
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Qty {  get; set; }
        public decimal Amount { get; set; }


    }
}