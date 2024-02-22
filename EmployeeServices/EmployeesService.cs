using EmployeeRepository.Interface;
using EmployeeServices.Interface;
using Optevus.WebAPI.Models;

namespace EmployeeServices
{
    public class EmployeesService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employees>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }

        public async Task<Employees> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task AddEmployeeAsync(Employees newEmployee)
        {
            await _employeeRepository.AddEmployeeAsync(newEmployee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task UpdateEmployeeAsync(Employees updatedEmployee)
        {
            await _employeeRepository.UpdateEmployeeAsync(updatedEmployee);
        }
    }
}
