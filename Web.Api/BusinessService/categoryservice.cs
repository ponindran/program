using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web.Api.BusinessService
{
    public class categoryservice : Icategoryservice
    {
        private readonly Icategoryservice categoryRepository;

        public categoryservice(Icategoryservice catRepository)
        {
            categoryRepository = catRepository;
        }
        public void Inserdata(category catdto)
        {

            var entity = new Web.Api.Entity.category();

            entity.Id = catdto.Id;
            entity.Code = catdto.Code;
            entity.cName = catdto.cName;

            categoryRepository.Insertdata(entity);

        }

        public void Insertdata(category catdto)
        {
            throw new NotImplementedException();
        }
    }
}
