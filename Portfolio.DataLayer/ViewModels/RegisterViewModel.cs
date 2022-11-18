using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DataLayer.ViewModels
{
    public class RegisterViewModel
    {
        [Key]
        [Required]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required]
        [StringLength(100,ErrorMessage = "بیشتر از 100 نمی شود")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confrim Password")]
        [Compare("Password", ErrorMessage = "باید با رمز عبور برابر باشد")]
        public string ConfrimPassword { get; set; }

    }
}
