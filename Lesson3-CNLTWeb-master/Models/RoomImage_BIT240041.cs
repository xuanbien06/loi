using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson3_ORM_BookManagement.Models
{
    [Table("RoomImages_BIT240041")]
    public class RoomImage_BIT240041
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Đường dẫn ảnh không được để trống.")]
        [Url(ErrorMessage = "Đường dẫn ảnh phải là một URL hợp lệ.")]
        [Display(Name = "Đường dẫn ảnh")]
        public string ImageUrl { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public bool IsThumbnail { get; set; }

        [Required]
        public int RoomId { get; set; }

        // Khai báo khóa ngoại ánh xạ với RoomId
        [ForeignKey("RoomId")]
        public virtual Room_BIT240041 Room { get; set; }
    }
}