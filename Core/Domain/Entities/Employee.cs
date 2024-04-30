using EmployeeManagementAPI.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Core.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public TitleNames TitleName { get; set; }

        // Departman ilişkisi
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        
        // Yönetici ilişkisi
        public int? ManagerId { get; set; }
        public Employee? Manager { get; set; }

        // Unvan ilişkisi (bir employee'nin birden fazla title değiştirme hareketi)
        
        //public ICollection<TitleChange> TitleChanges { get; set; }
    }
}
