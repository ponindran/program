using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;
using Dapper;

namespace Web.Api.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly DapperContext _context;
        public EmployeeRepository(DapperContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empEntity"></param>
        public void InsertData(Employee empEntity)
        {
            
            var insertQuery = "Insert into employee values("+ empEntity.Id + ",'"+empEntity.Name+"','"+empEntity.Age+"','"+empEntity.Email+"')";
            //Establish the DB Connection
            using (var connection = _context.CreateConnection())
            {
                //Executing the SQL query using the DB Connection
                var companies =  connection.Query(insertQuery);
                
            }

            var result = SelectALLEmployee();
        }
         

        public IEnumerable<Employee> SelectALLEmployee()
        {
            var selectQuery = "Select * from employee";

            using (var connection = _context.CreateConnection())
            {
                //Executing the SQL query using the DB Connection
                var employees = connection.Query<Employee>(selectQuery);
                 
            }


            throw new NotImplementedException();
        }
    }
}
