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
using WPFapp1.mydatasetTableAdapters;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }


        mydataset ds;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ds = new mydataset();
            deptTableAdapter daDeps = new deptTableAdapter();
            daDeps.Fill(ds.dept);

            employeeTableAdapter daEmps = new employeeTableAdapter();
            daEmps.Fill(ds.employee);

            dgEmps.ItemsSource = ds.employee.DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            employeeTableAdapter daEmps = new employeeTableAdapter();
            daEmps.Update(ds.employee);
        }

        private void winMain4_Loaded(object sender, RoutedEventArgs e)
        {
            ds = new mydataset();
            deptTableAdapter daDeps = new deptTableAdapter();
            daDeps.Fill(ds.dept);

            employeeTableAdapter daEmps = new employeeTableAdapter();
            daEmps.Fill(ds.employee);

            dgEmps.ItemsSource = ds.employee.DefaultView;
        }
    }
}
