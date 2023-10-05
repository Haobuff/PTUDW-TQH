using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Posts")]
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int? TopID { get; set; }
        [Required]
        public string Title { get; set; }

        public string Slug { get; set; }
        public string Detail { get; set; }
        
        public string Img { get; set; }



        public string PosstType { get; set; }
        [Required]
        public string MetaDe { get; set; }
        public DateTime CreatteBy { get; set; }
        public int? CreateBy { get; set; }
        public int UpdatteBy { get; set; }
        public DateTime UpdatteAt { get; set; }
        public int Status { get; set; }

    }
}
