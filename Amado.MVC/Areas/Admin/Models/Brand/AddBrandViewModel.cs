

using System.ComponentModel.DataAnnotations;

namespace Amado.MVC.Areas.Admin.Models.Brand
{
    public class AddBrandViewModel
    {
        [Required(ErrorMessage = "Category name is required!")]
        [MaxLength(50, ErrorMessage = "Category name cannot exceed 50 characters!")]
        public string BrandName { get; set; }
    }
}
