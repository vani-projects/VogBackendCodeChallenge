using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Data
{
    public class EmployeeInMemoryRepository:IEmployeeRepository
    {
        private static List<Employee> _employees;

        public EmployeeInMemoryRepository()
        {
            //Hardcoded Initialization
            _employees = new List<Employee>
            {
                new Employee{Id = 1,FisrtName ="Vani",LastName="Joshi",JobTitle="Software Developer",MailingAddress="8000 WentWorth Dr",DepartmentId=1 },
                new Employee{Id=2,FisrtName ="Shravani",LastName="Thimanadoddi",JobTitle="Jr.Software Developer", MailingAddress="5000 WentWorth Dr",DepartmentId=1},
                new Employee{Id=3,FisrtName="John",LastName="William",JobTitle="Solutions Architect",MailingAddress="202 Aspen",DepartmentId=2}
            };
        }

        public void Delete(int employeeId)
        {
            _employees.RemoveAll(e => e.Id == employeeId);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(int employeeId)
        {
            return _employees.First(e => e.Id == employeeId);
        }

        public void Insert(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Save()
        {
            //Do nothing for in-memory repository
        }

        public void Update(Employee employee)
        {
            Employee existingEmplyee = _employees.First(e => e.Id == employee.Id);
            existingEmplyee = employee;
        }
    }
}
