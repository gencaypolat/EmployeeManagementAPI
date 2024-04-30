using EmployeeManagementAPI.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Core.ServiceContracts
{
    public interface IEmployeesService
    {
        /// <summary>
        /// Creates a new Employee object
        /// </summary>
        /// <param name="employeeCreateRequest"> 
        /// <returns></returns>
        Task<EmployeeAddResponse> AddEmployee(EmployeeAddRequest employeeAddRequest)
        {

            return null;
        }
    }
}
