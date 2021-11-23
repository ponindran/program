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
            var insertQuery = "insert into StudentMark(id,name,subject,mark,result) values (@studententity.Id,@studententity.name ,@studententity.subject,@studententity.mark,@studententity.result);
            using (var connection = _context.createStudentMarkconnection())
            {

                connection.Query(insertQuery);
            }


        }
    } 
}
