﻿using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Repository;

namespace Web.Api.BusinessService
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository employeeRepository; 

        public EmployeeService(IEmployeeRepository empRepository)
        {
            employeeRepository = empRepository;
        }
        public void InserData(Employee empdto)
        {
            //TOD : Add your Business Logic

            //Converting the DTO employee object into ENtity Employee  object
            var entity = new Web.Api.Entity.Employee();

            entity.Id = empdto.Id;
            entity.Name = empdto.Name;
            entity.Email = empdto.Email;
            entity.Age = empdto.Age;

            //Calling the employee Repository to insert the employee data
            employeeRepository.InsertData(entity);
            
        }
    }
}
