using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrudOpWithGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DataSet ds;
       

        public void Fill_grid()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=cdac20;Integrated Security=True;Pooling=False";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from employee";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

             ds = new DataSet();
            da.Fill(ds,"Emp");

            dataGridView.ItemsSource = ds.Tables["Emp"].DefaultView;
            cn.Close();
            

        }
        
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=cdac20;Integrated Security=True;Pooling=False";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into employee values(@empId,@Name,@Salary,@deptId)";

                cmd.Parameters.AddWithValue("@empId", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@deptId", txtDeptId.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");
                cn.Close();
                Fill_grid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cell_content_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
          
        }
    }
}
