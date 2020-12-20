using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for employee3.xaml
    /// </summary>
    public partial class employee3 : Window
    {
        public employee3()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            //  cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText  = "insert into employee values(@empid,@empName,@empSalary,@deptId)";

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertEmployee";

            cmd.Parameters.AddWithValue("@empid",txtEmpId.Text);
            cmd.Parameters.AddWithValue("@empName", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@empSalary", txtEmpSalary.Text);
            cmd.Parameters.AddWithValue("@deptId", txtEmpDeptId.Text);

            try
            {
                cmd.ExecuteNonQuery();

                txtEmpId.Text = "";
                txtEmpName.Text = "";
                txtEmpSalary.Text = "";
                txtEmpDeptId.Text = "";

                MessageBox.Show("Record Inserted Successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "update employee set empName=@empName,empSalary=@empSalary,deptId=@deptId where empid=@empid";

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "UpdateEmployee";

            cmd.Parameters.AddWithValue("@empid", txtEmpId.Text);
            cmd.Parameters.AddWithValue("@empName", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@empSalary", txtEmpSalary.Text);
            cmd.Parameters.AddWithValue("@deptId", txtEmpDeptId.Text);
           

            try
            {
                cmd.ExecuteNonQuery();

                txtEmpId.Text = "";
                txtEmpName.Text = "";
                txtEmpSalary.Text = "";
                txtEmpDeptId.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from employee where empid=@empid";

            cmd.Parameters.AddWithValue("@empid", txtEmpId.Text);

            try
            {
                cmd.ExecuteNonQuery();

                txtEmpId.Text = "";
                txtEmpName.Text = "";
                txtEmpSalary.Text = "";
                txtEmpDeptId.Text = "";
                MessageBox.Show("record deleted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select empid,empName,empSalary,deptId from employee";
            MessageBox.Show(cmd.ExecuteScalar().ToString());
            cn.Close();
        }
    }
}
