using System.ComponentModel;

namespace EnglishExamOnline.Backend.Models
{
    public enum ContestStateEnum
    {
        [Description("Mở đăng ký")]
        RegistOpen = 0,
        [Description("Đóng đăng ký")]
        RegistClose = 1,
        [Description("Đang diễn ra")]
        Contesting = 2,
        [Description("Đã kết thúc")]
        Close = 3,
    }
}
