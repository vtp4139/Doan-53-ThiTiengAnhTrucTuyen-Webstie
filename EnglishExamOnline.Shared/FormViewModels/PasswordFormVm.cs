using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishExamOnline.Shared.FormViewModels
{
    public class PasswordFormVm
    {
        public string userId { get; set; }

        [Display(Name = "Mật khẩu cũ")]
        [Required(ErrorMessage = "Không chừa trống mật khẩu cũ.")]
        public string oldPassword { get; set; }

        [Display(Name = "Mật khẩu mới")]
        [Required(ErrorMessage = "Nhập mật khẩu mới!")]
        [StringLength(200, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 kí tự!")]
        public string newPassword { get; set; }
    }
}
