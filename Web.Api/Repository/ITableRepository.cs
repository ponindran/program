﻿using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api
{
    public interface ITableRepository
    {
        public Task<IEnumerable<Table>> GetCompanies();

        public Task<bool> InterData(UserDetail entity);
    }
}
