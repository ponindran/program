using Dapper;
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
    } 
}
