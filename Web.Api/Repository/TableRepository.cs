using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class TableRepository : ITableRepository
    {
        private readonly DapperContext _context;
        public TableRepository(DapperContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Table>> GetCompanies()
        {
            var query = "select * from [dbo].[Table]";
            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Table>(query);
                return companies.ToList();
            }
        }
    }
}
