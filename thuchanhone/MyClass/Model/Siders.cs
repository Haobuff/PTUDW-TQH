using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Siders")]
    public class Siders
    {
        [Key]
        public int Id { get; set; }
        [Required]
      

        public string Name { get; set; }
        public string URL { get; set; }

  public string Img { get; set; }
        public int? Order { get; set; }

        public string Position { get; set; }
        public int CreateBy { get; set;}

        public DateTime CreateAt { get; set; }

        public int? UpdateBy { get; set; }
      
       
        
    }
}
