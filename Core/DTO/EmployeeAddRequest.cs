using EmployeeManagementAPI.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Core.DTO
{
    public class EmployeeAddRequest
    {
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public TitleNames TitleName { get; set; }
        public int DepartmentId { get; set; }
        public int? ManagerId { get; set; }
    }
}
