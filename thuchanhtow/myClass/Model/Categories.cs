using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? Parentld { get; set; }
        public int? Order { get; set; }
        [Required]
        public string MetaDess {  get; set; }
        [Required]
        public string MetaKey { get; set; }
        public int CreatedBy {  get; set; }
     
        public DateTime CreatedAt { get; set; }
        public int UpdateBy {  get; set; }

        public DateTime UpdatedAt { get; set;}
        public int Status {  get; set; }


    }
}
