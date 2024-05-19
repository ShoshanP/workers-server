using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Core.Models;
using Worker.Core.Repositories;
using Worker.Core.Services;

namespace Worker.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> AddAsync(Employee employee)
        {
            return await _employeeRepository.AddAsync(employee);
        }

        public async Task DeleteAsync(int id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

        public async Task<List<Employee>> GetAllAsync()
        {
           return await _employeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
           return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task<Employee> UpdateAsync(Employee employee)
                  {
          return await _employeeRepository.UpdateAsync(employee);
        }
    }
}
