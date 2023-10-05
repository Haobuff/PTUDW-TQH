using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? parentId {  get; set; }
        public int? Order {  get; set; }
        [Required]
        public string MetaDess {  get; set; }

        [Required]
        public string MetaKey { get; set; }
    

        public DateTime CreatteAt { get; set; }
        public int? CreateBy { get; set; }
        public int UpdatteBy { get; set; }
        public DateTime UpdatteAt { get; set; }
        public int Status { get; set; }

    }
}
