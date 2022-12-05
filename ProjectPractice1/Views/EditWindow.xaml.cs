using ProjectPractice1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectPractice1.Views
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private int EmployeeId;
        public EditWindow(int tabId, int employeeId)
        {
            InitializeComponent();

            TabControl1.SelectedIndex = tabId;
            EmployeeId = employeeId;
            SetTextBoxes();
        }

        private void SetTextBoxes()
        {
            Employee employee = new ApplicationDbContext().Employees.Where(e => e.Id == EmployeeId).Single();

            TB_FirstName.Text = employee.FirstName;
            TB_LastName.Text = employee.LastName;
            TB_MiddleName.Text = employee.MiddleName;
            TB_Age.Text = Convert.ToString(employee.Age);
            TB_Expirience.Text = Convert.ToString(employee.Expirience);
            TB_PostId.Text = Convert.ToString(employee.PostId);
            TB_DepartmentId.Text = Convert.ToString(employee.DepartmentId);
        }

        private void ButtonAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();

            if (TB_FirstName.Text != "" || TB_LastName.Text != "" || TB_MiddleName.Text != "" || TB_Age.Text != "" || TB_Expirience.Text != "" || TB_PostId.Text != "" || TB_DepartmentId.Text != "")
            {
                employee.FirstName = TB_FirstName.Text;
                employee.LastName = TB_LastName.Text;
                employee.MiddleName = TB_MiddleName.Text;
                employee.Age = Convert.ToInt32(TB_Age.Text);
                employee.Expirience = Convert.ToInt32(TB_Expirience.Text);
                employee.PostId = Convert.ToInt32(TB_PostId.Text);
                employee.DepartmentId = Convert.ToInt32(TB_DepartmentId.Text);
            }
            else
            {
                MessageBox.Show("Не все данные введены");
                return;
            }
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        private void ButtonSaveEmployee_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
