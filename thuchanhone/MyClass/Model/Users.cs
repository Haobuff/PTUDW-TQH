using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]


        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]

        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Img { get; set; }

        public int? CreateBy { get; set; }

        //

    }
    }
