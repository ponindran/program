using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.BusinessService
{
    public interface Icategoryservice
    {
        public void Insertdata(category catdto);
       public IEnumerable Selectdata(category catDTO);
        public void Updatedata(category catDTO);

    }
}
