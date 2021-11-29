using Dapper;
using System.Collections.Generic;
using System.Linq;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class StudentMarkrepository : IStudentmarkrepository
    {

        private readonly DapperContext _context;
        public StudentMarkrepository(DapperContext context)
        {
            _context = context;
        }

        public void Insertdata(StudentMarkEntity studententity)
        {
            var insertQuery = "insert into StudentMark(id,name,subject,mark,result) values (@Id,@name ,@subject,@mark,@result)";
            using (var connection = _context.createStudentMarkconnection())
            {

                connection.Query(insertQuery, new { Id = studententity.Id, name = studententity.name, subject = studententity.subject, mark = studententity.mark, result = studententity.result });
            }


        }

        public IEnumerable<StudentMarkEntity> selectALLQuantity()
        {
            var selectQuery = "select * from StudentMark";
            var StudentMark = new List<StudentMarkEntity>();
            using (var connection = _context.createStudentMarkconnection())
            {
                //Executing the SQL query using the DB connection
                StudentMark = connection.Query<StudentMarkEntity>(selectQuery).ToList();
            }
            return StudentMark;
            //throw new System.NotImplementedException();
        }
        
    } 
}
