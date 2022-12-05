using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPractice1.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Departments = new HashSet<Department>();
        }

        [NotMapped]
        private string _image;

        public int Id { get; set; }
        public string EquipmentName { get; set; } = null!;
        public int EquipmentCount { get; set; }
        public string EquipmentImage { get => _image; set => _image = value; }
        public string? EquipmentDescription { get; set; }

        [NotMapped]
        public string ImagePath => $"..\\Resources\\Equipment\\{_image}";

        public virtual ICollection<Department> Departments { get; set; }
    }
}
