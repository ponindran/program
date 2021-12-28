using Twinkle.Models;
using Twinkle.Mvc.BusinessService.Contract;
using Twinkle.Mvc.Repository.Contracts;
using Store.Twinkle.BaseService;

namespace Twinkle.Mvc.BusinessService
{
    public class ProductService : BaseService<ProductInfo> , IProductService
    {

        private readonly IProductInfoRepository _productInfoRepository;

        public ProductService(IProductInfoRepository productInfoRepository) : base(productInfoRepository)
        {
            _productInfoRepository = productInfoRepository;
        }

    }
}
