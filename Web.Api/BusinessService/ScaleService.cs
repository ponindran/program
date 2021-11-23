using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Repository;

namespace Web.Api.BusinessService
{
    public class ScaleService : IScaleService
    {
        private readonly IScalerepository _sclrepository;  
        public ScaleService(IScalerepository sclrepository)
        {
            _sclrepository = sclrepository;
        }
       public void InsertData(Scale sclDTO)
        {
            var Entity = new Web.Api.Entity.Scale();
            Entity.Id   = sclDTO.Id;
            Entity.code = sclDTO.code;
            Entity.name = sclDTO.name;
            // 
            _sclrepository.Insertdata(Entity);


        }
    }
}
