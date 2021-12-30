using Microsoft.EntityFrameworkCore;
using Store.Twinkle.BaseModel;
using Store.Twinkle.BaseRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twinkle.Data;
using Twinkle.Models;

namespace Twinkle.Mvc.Repository
{
    public class ProductInfoRepository : BaseRepository<ProductInfo>, Contracts.IProductInfoRepository
    {
        public ProductInfoRepository(ApplicationDbContext saContext) : base(saContext)
        {


        }

        public override IQueryable<ProductInfo> FindAll()
        {
            return this._context.Set<ProductInfo>().Include(price=> price.PriceInfo).AsNoTracking();
        }
    }
}
