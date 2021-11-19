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
        private readonly string _connectionStringproduct;

        private readonly string _connectionStringScale;
        private readonly string _connectionStringStudentmark;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
            //sacle database configuration
            _connectionStringScale = _configuration.GetConnectionString("SqlConnectionScale");
            _connectionStringStudentmark = _configuration.GetConnectionString("SqlConnectionStudentmark");
            _connectionStringproduct = _configuration.GetConnectionString("SqlConnectionproduct");
        }
       
        
        public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);

        public IDbConnection CreateLocationConnection()
        {
            return new SqlConnection(_connectionStringScale);
        }

        public IDbConnection createStudentMarkconnection() 
        {
            return new SqlConnection(_connectionStringStudentmark);
        }
        public IDbConnection CreateproductConnection()
       => new SqlConnection(_connectionStringproduct);
    }
}
