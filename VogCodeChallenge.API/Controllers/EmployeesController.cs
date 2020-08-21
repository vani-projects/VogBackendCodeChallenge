using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        //GET /api/employees
        [HttpGet("/api/employees")] //path parameters
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        [HttpGet("/api/employees/department/{departmentId}")]
        public IEnumerable<Employee> GetEmployeesForDepartment(int departmentId)
        {
            return _employeeService.GetEmployeesForDepartment(departmentId);
        }
    }
}
