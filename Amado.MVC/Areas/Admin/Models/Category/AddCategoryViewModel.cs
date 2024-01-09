using System.ComponentModel.DataAnnotations;

namespace Amado.MVC.Areas.Admin.Models.Category
{
    public class AddCategoryViewModel
    {
        [Required(ErrorMessage = "Category name is required!")]
        [MaxLength(50, ErrorMessage = "Category name cannot exceed 50 characters!")]
        public string CategoryName { get; set; }
    }
}
