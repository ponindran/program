using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Repository;

namespace Web.Api.BusinessService
{
    public class Productservice : IProductService
    {
        private readonly IProductRepository productrepository;

        public Productservice(IProductRepository proRepository)
        {
            productrepository = proRepository;
        }
        public void InserData(Product prodto)
        {
            
            var entity = new Web.Api.Entity.Product();

            entity.Id = prodto.Id;
            entity.productName = prodto.productName;
            entity.price = prodto.price;

            productrepository.Insertdata(entity);

        }


    }
}
