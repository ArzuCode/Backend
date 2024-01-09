
using Amado.Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amado.Core.Entities
{
    public class ProductImage : BaseEntity
    {
        [Required(ErrorMessage = "Product photo link is mandatory!")]
        [MaxLength(500, ErrorMessage = "Product photo link length cannot be more than 500 characters!")]
        public string Url { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
