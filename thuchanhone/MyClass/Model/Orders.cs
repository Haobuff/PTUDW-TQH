using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId  { get; set; }
        [Required]
        public string RêciverAdress { get; set; }

        [Required]
        public string ReeciverEmail {  get; set; }
        [Required]
        public string ReeciverPhone { get; set; }

        public string Note { get; set; }

        public DateTime CreatteAt { get; set; }   
        public int UpdatteBy { get; set; }   
        public DateTime UpdatteAt { get; set; }
        public int Status { get; set; }
    }
}
