using System.ComponentModel.DataAnnotations;

namespace Portfolio.DataLayer.ViewModels
{
    public class PersonalViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(20, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(20, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        public int Age { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(2000, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string Bio { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(250, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string Address { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(70, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string Email { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string Instagram { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        public string Twitter { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0} می باشد")]
        public string Github { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        public string Linkedin { get; set; }

        [Required(ErrorMessage = "وارد کردن این فیلد اجباری است")]
        public string Telegram { get; set; }
    }
}