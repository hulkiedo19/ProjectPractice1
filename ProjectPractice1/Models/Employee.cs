using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPractice1.Models
{
    public partial class Employee
    {
        [NotMapped]
        private string _photo;

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string Photo { get => _photo; set => _photo = value; }
        public int Age { get; set; }
        public int Expirience { get; set; }
        public int? PostId { get; set; }
        public int? DepartmentId { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName} {MiddleName}";

        [NotMapped]
        public string PhotoPath => $"..\\Resources\\Employee\\{_photo}";

        public virtual Department? Department { get; set; }
        public virtual Post? Post { get; set; }
    }
}
