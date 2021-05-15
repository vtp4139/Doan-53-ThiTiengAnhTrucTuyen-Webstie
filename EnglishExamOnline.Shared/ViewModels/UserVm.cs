using System;
using System.ComponentModel.DataAnnotations;

namespace EnglishExamOnline.Shared.ViewModels
{
    public class UserVm
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Không bỏ trống họ tên!")]
        public string Fullname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không khả dụng!")]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        public string? LockEnd { get; set; }
    }
}
