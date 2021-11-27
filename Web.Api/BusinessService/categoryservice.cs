﻿using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Repository;


namespace Web.Api.BusinessService 
{
    public class categoryservice : Icategoryservice
    {
        private readonly Icategoryrepository categoryRepository;

        public categoryservice(Icategoryrepository catRepository)
        {
            categoryRepository = catRepository;
        }

        public void Insertdata(category catdto)
        {
            var entity = new Web.Api.Entity.category();

            entity.Id = catdto.Id;
            entity.Code = catdto.Code;
            entity.cName = catdto.cName;

            categoryRepository.Insertdata(entity);
        }

        public void Selectdata(category catdto)
        {
            var entity = new Web.Api.Entity.category();

            entity.Id = catdto.Id;
            entity.Code = catdto.Code;
            entity.cName = catdto.cName;

            categoryRepository.Insertdata(entity);
        }
     

        public void Updatedata(category catDTO)
        {
            throw new NotImplementedException();
        }


        public void Selectdata(category catDTO)
        {
            throw new NotImplementedException();
        }

    }
}
