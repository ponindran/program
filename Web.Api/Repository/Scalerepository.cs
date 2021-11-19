using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public class Scalerepository: IScalerepository 
    {
        public void Insertdata(Scale sclEntity) 
        {
            var InsertData = "insert into Scale values ("+Scale.Id+") ";

        }

    }
}
