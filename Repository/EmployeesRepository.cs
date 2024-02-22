using EmployeeRepository.DataEmployee;
using EmployeeRepository.Interface;
using Microsoft.EntityFrameworkCore;
using Optevus.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository
{
    public class EmployeesRepository :IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;

        public EmployeesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employees>> GetEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employees> GetEmployeeByIdAsync(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddEmployeeAsync(Employees newEmployee)
        {
            _dbContext.Employees.Add(newEmployee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateEmployeeAsync(Employees updatedEmployee)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Age = updatedEmployee.Age;
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
