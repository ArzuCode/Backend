
using System.ComponentModel.DataAnnotations;

namespace Amado.MVC.Areas.Admin.Models.Product
{
    public class UpdateProductViewModel
    {
       
        [Required(ErrorMessage = "Product price is mandatory!")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Product name is required!")]
        [MaxLength(50, ErrorMessage = "The product code cannot exceed 50 characters!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Information about stock availability is mandatory!")]
        public bool StockShortage { get; set; }

        [Required(ErrorMessage = "Product description is mandatory!")]
        [MaxLength(500, ErrorMessage = "Product description cannot exceed 500 characters!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Specifying the unit is mandatory!")]
        [MaxLength(20, ErrorMessage = "Unit cannot exceed 20 characters!")]
        public string UnitInfo { get; set; }

        [Required(ErrorMessage = "Category selection is mandatory!")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Brand selection is mandatory!")]
        public int BrandId { get; set; }
        public bool IsActive { get; set; }
    }
}
