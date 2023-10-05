using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Links")]
    public class Menus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TableId { get; set; }
        public string TyPeMenu { get; set; }
        public int ParentID { get; set; }
        public string Type { get; set; }
    }
}
