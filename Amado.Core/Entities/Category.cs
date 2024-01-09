using Amado.Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Amado.Core.Entities
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Category name is required!")]
        [MaxLength(50, ErrorMessage = "Category name cannot exceed 50 characters!")]
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
