using EmployeeManagementAPI.Core.Domain.RepositoryContracts;
using EmployeeManagementAPI.Core.DTO;
using EmployeeManagementAPI.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Core.Services
{
    public class EmployeeServices : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeeServices(IEmployeesRepository employeesRepository) 
        {
            _employeesRepository = employeesRepository;
        }

        public async Task<EmployeeAddResponse> AddEmployee(EmployeeAddRequest employeeAddRequest)
        {
            return null;
        } 

    }
}
