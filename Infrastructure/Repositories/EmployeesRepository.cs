using EmployeeManagementAPI.Core.Domain.Entities;
using EmployeeManagementAPI.Core.Domain.RepositoryContracts;
using EmployeeManagementAPI.Infrastructure.DbContextNameSpace;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Infrastructure.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        
        public EmployeesRepository(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Add(employee);
            _applicationDbContext.SaveChangesAsync();

            return employee;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _applicationDbContext.Employees.Include("Department").ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            Employee? matchingEmployee = await _applicationDbContext.Employees.FirstOrDefaultAsync(temp => temp.Id == employee.Id);

            if (matchingEmployee != null)
            {
                return employee;
            }

            matchingEmployee.FirstName = employee.FirstName;
            matchingEmployee.LastName = employee.LastName;
            matchingEmployee.Email = employee.Email;
            matchingEmployee.Phone = employee.Phone;
            
            
            return employee;
        }
    }
}
