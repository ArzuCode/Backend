

using Amado.Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amado.Core.Entities
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Product code is required!")]
        [MaxLength(20,ErrorMessage = "The product code cannot exceed 20 characters!")]
        public string ProductCode { get; set; }

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

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int? BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public virtual List<ProductImage> ProductImages { get; set; }

    }
}
