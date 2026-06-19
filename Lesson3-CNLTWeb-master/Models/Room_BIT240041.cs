using Lesson3_CNLTWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson3_ORM_BookManagement.Models
{
    [Table("Rooms_BIT240041")]
    public class Room_BIT240041
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên phòng không được để trống.")]
        [Display(Name = "Tên phòng")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá thuê không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá thuê phải lớn hơn 0.")]
        [Display(Name = "Giá thuê (VND)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Diện tích không được để trống.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Diện tích phải lớn hơn 0.")]
        [Display(Name = "Diện tích (m²)")]
        public double Area { get; set; }

        [Required(ErrorMessage = "Trạng thái phòng không được để trống.")]
        [Display(Name = "Còn phòng")]
        public bool IsAvailable { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại phòng.")]
        [Display(Name = "Loại phòng")]
        public int RoomTypeId { get; set; }

        // Khai báo khóa ngoại ánh xạ với RoomTypeId
        [ForeignKey("RoomTypeId")]
        public virtual RoomType_BIT240041 RoomType { get; set; }

        // Mối quan hệ 1-Nhiều: Một phòng có nhiều ảnh
        public virtual ICollection<RoomImage_BIT240041> RoomImages { get; set; }
    }
}