﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entity;

namespace Web.Api.Repository
{
    public interface IEmployeeRepository
    {

        public void InsertData(Employee empEntity);

        public IEnumerable<Employee> SelectALLEmployee();
    }
}