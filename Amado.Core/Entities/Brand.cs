

using Amado.Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Amado.Core.Entities
{
    public class Brand : BaseEntity
    {
        [Required(ErrorMessage = "Brand name is mandatory!")]
        [MaxLength(50, ErrorMessage = "Brand name cannot exceed 50 characters!")]
        public string BrandName { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
