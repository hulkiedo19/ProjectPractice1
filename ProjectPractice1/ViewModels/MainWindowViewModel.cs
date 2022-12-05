using Microsoft.EntityFrameworkCore;
using ProjectPractice1.Models;
using ProjectPractice1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectPractice1.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private List<Employee> _employees = new List<Employee>();
        private List<Department> _departments = new List<Department>();
        private List<Equipment> _equipments = new List<Equipment>();
        private List<Post> _posts = new List<Post>();

        private int _selectedIndexEmployee;

        public List<Employee> Employees
        {
            get => _employees;
            set => Set(ref _employees, value, nameof(Employees));
        }
        public List<Department> Departments
        {
            get => _departments;
            set => Set(ref _departments, value, nameof(Departments));
        }
        public List<Equipment> Equipments
        {
            get => _equipments;
            set => Set(ref _equipments, value, nameof(Equipments));
        }
        public List<Post> Posts
        {
            get => _posts;
            set => Set(ref _posts, value, nameof(Posts));
        }
        public int SelectedIndexEmployee
        {
            get => _selectedIndexEmployee;
            set => Set(ref _selectedIndexEmployee, value, nameof(SelectedIndexEmployee));
        }

        public MainWindowViewModel()
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                Employees = context.Employees
                    .Include(e => e.Post)
                    .Include(e => e.Department)
                    .ToList();
                Departments = context.Departments
                    .Include(d => d.Equipment)
                    .ToList();
                Equipments = context.Equipment
                    .ToList();
                Posts = context.Posts
                    .Include(p => p.Employees)
                    .ToList();
            }
        }

        public void OpenEditWindow(int tabId)
        {
            int EmployeeId = Employees.ElementAt(SelectedIndexEmployee).Id;

            EditWindow window = new EditWindow(tabId, EmployeeId);
            window.ShowDialog();
        }
    }
}
