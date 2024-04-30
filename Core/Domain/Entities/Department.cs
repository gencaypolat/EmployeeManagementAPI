using EmployeeManagementAPI.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Core.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public DepartmentNames DepartmentName { get; set; }
        public int DepartmentManagerId { get; set; }
        
        // Lokasyon ilişkisi (Many-to-Many)
        //public virtual ICollection<Location> Locations { get; set; }


        // Employee ilişkisi (One-To-Many)
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
