using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson3_ORM_BookManagement.Models
{
    [Table("RoomTypes_BIT240041")]
    public class RoomType_BIT240041
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên loại phòng không được để trống.")]
        [Display(Name = "Tên loại phòng")]
        public string Name { get; set; }

        // Mối quan hệ 1-Nhiều: Một loại phòng có thể có nhiều phòng
        public virtual ICollection<Room_BIT240041> Rooms { get; set; }
    }
}