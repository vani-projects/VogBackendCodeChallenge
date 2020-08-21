using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Data
{
    public class EmployeeDBRepository:IEmployeeRepository
    {
        public EmployeeDBRepository()
        {
            //DB Connection Initialization
        }

        public void Delete(int employeeId)
        {
            // Implement DB delete
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            // Implement DB select all
            throw new NotImplementedException();
        }

        public Employee GetById(int employeeId)
        {
            // Implement DB select
            throw new NotImplementedException();
        }

        public void Insert(Employee employee)
        {
            // Implement DB Insert
            throw new NotImplementedException();
        }

        public void Save()
        {
            // Implement DB Update
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            // Implement DB Update
            throw new NotImplementedException();
        }
    }
}
