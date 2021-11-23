using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class ProductRespository : IProductRepository
    {
        private readonly DapperContext _context;
        public ProductRespository(DapperContext context)
        {
            _context = context;
        }
         public void Insertdata(Product proEntity)
        {
            
            var insertQuery = "Insert into product (Id,productName,price) values(@id,@name,@price)";

            using (var connection = _context.CreateproductConnection())
            {

                connection.Query(insertQuery, new { id = proEntity.Id,name=proEntity.productName,price=proEntity.price });
                
            }

            //var result = SelectALLProduct();
        }

       /* private object SelectALLProduct()
        {
            throw new NotImplementedException();
        }

        public void Insertdata(Product proEntity)
        {
            throw new NotImplementedException();
        }*/
    }
}
