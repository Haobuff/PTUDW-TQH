using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Contacts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ỦeId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Detail { get; set; }

        public DateTime CreateAt { get; set; }
        public int? UpdateBy { get; set; }
        
        public DateTime UpadateAt { get; set; }
    public int Status { get; set; }
    }
}
