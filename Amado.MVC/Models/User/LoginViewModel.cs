

using Amado.Common.Validators;
using System.ComponentModel.DataAnnotations;

namespace Amado.MVC.Models.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email address is required!")]
        [MaxLength(50, ErrorMessage = "Email cannot exceed 50 characters!")]
        [EmailAddress(ErrorMessage = "It must comply with the email address format!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [Password(ErrorMessage = "Your password must contain at least one uppercase letter, one lowercase letter and one number, and must also be at least 8 characters!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
