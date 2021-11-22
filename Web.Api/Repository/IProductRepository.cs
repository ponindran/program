using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public interface IProductRepository
    {
        public void Insertdata(Product proEntity);
    }
}
