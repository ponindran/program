using Store.Twinkle.BaseModel;

namespace Twinkle.Models.ViewModels
{
    public class ProductInfoVM : BaseModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
