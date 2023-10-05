using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CatID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Detail { get; set; }
        public string Img { get; set; }

        public decimal price { get; set; }
        public decimal SalePrice { get; set; }
        public int Qty { get; set; }

        [Required]

        public string MeraDess { get; set; }
        [Required]
        public string Merakey { get; set; }
        public int CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
    }
}
