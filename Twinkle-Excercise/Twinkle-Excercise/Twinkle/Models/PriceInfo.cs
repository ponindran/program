using Store.Infrastructure.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Twinkle.Models
{
    
    public class PriceInfo : BaseEntity
    {
        [Key,ForeignKey("ProductInfo")]
        public int ProductId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public double Price { get; set; }

        public virtual ProductInfo ProductInfo { get; set; }

    }
}
