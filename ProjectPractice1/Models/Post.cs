using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPractice1.Models
{
    public partial class Post
    {
        public Post()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string PostName { get; set; } = null!;
        public string? PostDescription { get; set; }

        [NotMapped]
        public int PostEmployeeCount => Employees.Count;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
