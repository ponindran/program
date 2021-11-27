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
            throw new NotImplementedException();
        }

       

            }
        }
    

