using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("ToPics")]
    public class ToPics
    {
        [Key]
        public int Id { get; set; }
        [Required]


        public string Name { get; set; }
        public string URL { get; set; }

        public string Img { get; set; }
        public string Slug { get; set; }

        public int? Order { get; set; }
        public string FullName { get; set; }
        public string Phoine { get; set; }
        public string Email { get; set; }
        public string UrlAite { get; set; }
        [Required]
        public string MetaDesc { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
    }
}
