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

                connection.Query(insertQuery, new { id = proEntity.Id, name = proEntity.productName, price = proEntity.price });

            }

            //var result = SelectALLProduct();
        }

       /* private object SelectALLProduct()
        {
            throw new NotImplementedException();
        }

        public void InsertData(Product proEntity)
        {n
            throw new NotImplementedException()
        }*/

        public IEnumerable<Product> SelectALLProduct()
        {
            var selectQuery = "Select * from product";
            var product = new List<Product>();
            using (var connection = _context.CreateproductConnection())
            {
                //Executing the SQL query using the DB Connection
                 product=connection.Query<Product>(selectQuery).ToList();

            }
            return product;

        }
        public Product Updatedata(int id, Product proEntity)
        {
            try
            {

                var insertQuery = "Update product set productName='" + proEntity.productName + "',price='" + proEntity.price + "' where id=" + id + "";

                using (var connection = _context.CreateproductConnection())
                {

                    connection.Query(insertQuery);

                }

                var result = SelectALLProduct();

                var updatedRecord = result.ToList().FirstOrDefault(x => x.Id == id);



                return updatedRecord;

            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public void deletedata(int id)
        {

            var insertQuery = "delete from product where id=" + id + "";

            using (var connection = _context.CreateproductConnection())
            {

                connection.Query(insertQuery);

            }

        }

       
    }
}
