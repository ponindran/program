using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class Scalerepository: IScalerepository 
    {
        private readonly DapperContext _context;
        public Scalerepository(DapperContext context) 
        {
            _context = context;
        }

        public void Insertdata(Scale sclEntity) 
        {
            var insertQuery = "insert into Scale values ("+sclEntity.Id+",'"+sclEntity.code+"','"+sclEntity.name+"') ";
            using (var connection = _context.CreateConnection()) 
            {
                
                 connection.Query(insertQuery);
            }

        }
        public Scale UpdateData(int id ,Scale sclEntity)
        {
            var insertQuery = "update Quantity set code="+sclEntity.code+",name="+sclEntity.name+" where id="+id+"";
            using (var connection = _context.CreateScaleConnection())
            {

                connection.Query(insertQuery);
            }
            var allresult= SelectALLQuantity();
            var firstResult = allresult.ToList().FirstOrDefault(x => x.Id == id);

            return firstResult;
        }
        public void DeleteData(int id) 
        {
            var insertQuery = "delete from Quantity where id=" + id + "";
            using (var connection = _context.CreateScaleConnection())
            {

                connection.Query(insertQuery);
            }

        }

        public IEnumerable<Scale> SelectALLQuantity()
        {
            var selectQuery = "Select * from Quantity";

            var quantity = new List<Scale>();
            using (var connection = _context.CreateScaleConnection())
            {
                //Executing the SQL query using the DB Connection
                 quantity = connection.Query<Scale>(selectQuery).ToList();

            }
            return quantity;
        }

        }
}
