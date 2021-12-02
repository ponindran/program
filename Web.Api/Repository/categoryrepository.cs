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
            var insertquery = "INSERT INTO "
  

            throw new NotImplementedException();
        }

        public IEnumerable<category> selectData()
        {
            var selectQuerey = "select * from category";
            using (var connection = _context.CreateLocationConnection())
            {
               var result= connection.Query<category>(selectQuerey).ToList();

            }
                throw new NotImplementedException();
        }
    }
}
    

