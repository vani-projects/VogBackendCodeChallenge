using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int employeeId);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int employeeId);
        void Save();
    }
}
