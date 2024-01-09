

using Amado.Common.Validators;
using System.ComponentModel.DataAnnotations;

namespace Amado.MVC.Models.User
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is mandatory!")]
        [MaxLength(100, ErrorMessage = "The name cannot be more than 100 characters!")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is mandatory!")]
        [MaxLength(200, ErrorMessage = "Surname cannot be more than 200 characters!")]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required!")]
        [MaxLength(50, ErrorMessage = "Email cannot exceed 50 characters!")]
        [EmailAddress(ErrorMessage = "It must comply with the email address format!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [Password(ErrorMessage = "Your password must contain at least one uppercase letter, one lowercase letter and one number, and must also be at least 8 characters!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password verification is required!")]
        [Compare("Password", ErrorMessage = "Password and verification must match each other!")]
        [Display(Name = "password again")]
        public string ConfirmPassword { get; set; }
    }
}
