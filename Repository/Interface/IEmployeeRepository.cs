using Optevus.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository.Interface
{
    public interface IEmployeeRepository
    {
        Task<List<Employees>> GetEmployeesAsync();
        Task<Employees> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(Employees newEmployee);
        Task DeleteEmployeeAsync(int id);
        Task UpdateEmployeeAsync(Employees updatedEmployee);
    }
}
