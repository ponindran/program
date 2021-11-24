using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class categoryrepository : Icategoryrepository
    {

        private readonly DapperContext _context;
        public categoryrepository(DapperContext context)
        {
            _context = context;
        }

        public void Insertdata(category catentity)
        {
            throw new NotImplementedException();
        }

        public void updatedata(int id, category catentity )
        {

            var updateQuery = "update quantity set Code=" + catentity.Code + " , cName=" + catentity.cName + "where Id=" + id + " ";
            using (var connection = _context.CreatecategoryConnection())
            {
                var companies = connection.Query(updateQuery);

            }
        }
    }
}
