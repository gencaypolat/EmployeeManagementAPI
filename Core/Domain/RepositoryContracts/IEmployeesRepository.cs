using EmployeeManagementAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Core.Domain.RepositoryContracts
{
    public interface IEmployeesRepository
    {
        /// <summary>
        /// Adds a new employee object to the data store
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<Employee> AddEmployee(Employee employee);

        
        /// <summary>
        /// Returns all the employee objects in the data store
        /// </summary>
        /// <returns></returns>
        Task<List<Employee>> GetAllEmployees();

        
        /// <summary>
        /// Updates the employee object in the data store
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<Employee> UpdateEmployee(Employee employee);
    }
}
