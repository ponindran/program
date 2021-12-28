using Store.Infrastructure.BaseEntity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Twinkle.Models
{
    public class ProductInfo : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual PriceInfo PriceInfo { get; set; }
    }
}
