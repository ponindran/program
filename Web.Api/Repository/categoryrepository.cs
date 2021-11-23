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

            var insertQuery = "Insert into category (Id,Code,cName) values(@Id,@Code,@cName)";
            using (var connection = _context.CreatecategoryConnection())
            {
                var companies = connection.Query(insertQuery, new { id = catentity.Id, Code = catentity.Code, cName = catentity.cName });

            }
        }
    }
}
