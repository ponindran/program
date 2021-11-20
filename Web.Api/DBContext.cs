using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly string _connectionStringvaccine;


        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
            _connectionString = _configuration.GetConnectionString("SqlConnectionvaccine");

        }
               public IDbConnection CreateConnection()
 => new SqlConnection(_connectionString);

        public IDbConnection CreateConnectionvaccine()
             => new SqlConnection(_connectionStringvaccine);











    }
}
