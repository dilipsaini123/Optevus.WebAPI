using Optevus.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServices.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employees>> GetEmployeesAsync();
        Task<Employees> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(Employees newEmployee);
        Task DeleteEmployeeAsync(int id);
        Task UpdateEmployeeAsync(Employees updatedEmployee);
    }
}
