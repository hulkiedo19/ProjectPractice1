using System;
using System.Collections.Generic;

namespace ProjectPractice1.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string DepartmentBuild { get; set; } = null!;
        public int DepartmentNumber { get; set; }
        public int DepartmentMaxEmployees { get; set; }
        public int DepartmentRooms { get; set; }
        public int? EquipmentId { get; set; }

        public virtual Equipment? Equipment { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
