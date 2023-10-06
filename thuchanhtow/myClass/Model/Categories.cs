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

        [Display(Name = "Tên loại hàng")]
        [Required] 
        public string Name { get; set; }

        [Display(Name = "Tên rút gọn")]
        public string Slug { get; set; }

        [Display(Name = "Cấp cha")]
        public int? Parentld { get; set; }

        [Display(Name = "Sắp xếp")]
        public int? Order { get; set; }
        [Required]
        [Display(Name = "Mô tả")]
        public string MetaDess {  get; set; }

        [Required]
        [Display(Name = "Từ khóa")]
        public string MetaKey { get; set; }

        [Required]
        [Display(Name = "Người tạo")]
        public int CreatedBy {  get; set; }

        [Required]
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Display(Name = "Người cập nhập")]
        public int UpdateBy {  get; set; }

        [Required]
        [Display(Name = "Ngày cập  nhập")]
        public DateTime UpdatedAt { get; set;}
        [Required]
        [Display(Name = "Trạng Thái")]
        public int Status {  get; set; }

       
    }
}
