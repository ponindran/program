using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class Scalerepository: IScalerepository 
    {
        private readonly DapperContext _context;
        public Scalerepository(DapperContext context) 
        {
            _context = context;
        }

        public void Insertdata(Scale sclEntity) 
        {
            var insertQuery = "insert into Scale values ("+sclEntity.Id+",'"+sclEntity.code+"','"+sclEntity.name+"') ";
            using (var connection = _context.createStudentMarkconnection()) 
            {
                
                 connection.Query(insertQuery);
            }

        }

    }
}
