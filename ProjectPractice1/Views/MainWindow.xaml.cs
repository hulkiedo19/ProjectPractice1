using ProjectPractice1.ViewModels;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel? _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = (MainWindowViewModel)DataContext;
        }

        private void ListViewEquipment_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (_viewModel != null)
                _viewModel.OpenEditWindow(TabControl1.SelectedIndex);
        }

        private void ListViewDepartment_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (_viewModel != null)
                _viewModel.OpenEditWindow(TabControl1.SelectedIndex);
        }

        private void ListViewEmployee_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (_viewModel != null)
                _viewModel.OpenEditWindow(TabControl1.SelectedIndex);
        }

        private void ListViewPost_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (_viewModel != null)
                _viewModel.OpenEditWindow(TabControl1.SelectedIndex);
        }
    }
}
