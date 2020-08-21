using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Data;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public IEnumerable<Employee> GetEmployeesForDepartment(int id)
        {
            return _employeeRepository.GetAll().Where(x => x.DepartmentId == id);
        }

        public IList<Employee> ListAll()
        {
            return _employeeRepository.GetAll().ToList();
        }
    }
}
