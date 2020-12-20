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
using System.Windows.Shapes;

namespace WPFapp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        DataSet ds;
        

       
        private void btnDisp_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from employee";
            //MessageBox.Show(cmd.ExecuteScalar().ToString());
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            ds = new DataSet();
            da.Fill(ds, "Ems");

            cmd.CommandText = "select * from dept";
            da.Fill(ds, "dpt");     //even do not  open the connection fill work because when Fill calls then its wutomatically opens and close the connection

            DataColumn[] arrCols = new DataColumn[1];

            arrCols[0] = ds.Tables["Ems"].Columns["empid"];

            //primary key validation
            ds.Tables["Ems"].PrimaryKey = arrCols;


            //ForeignKey Validation
            ds.Relations.Add(ds.Tables["dpt"].Columns["deptId"], ds.Tables["Ems"].Columns["deptId"]);

            //Column level Constraints
            ds.Tables["dpt"].Columns["deptId"].AutoIncrement = true;

            dgEms.ItemsSource = ds.Tables["Ems"].DefaultView;
           // dgEms.ItemsSource = ds.Tables["dpt"].DefaultView;
            cn.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = System.Data.CommandType.Text;
            cmdUpdate.CommandText = "update employee set empName = @empName, empSalary = @empSalary,deptId = @deptId where empid=@empid ";

            //SqlParameter p = new SqlParameter();
            //p.ParameterName = "@empName";
            //p.SourceColumn = "empName";
            //p.SourceVersion = DataRowVersion.Current;

            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName="@empName",SourceColumn="empName",SourceVersion=DataRowVersion.Current});
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empSalary", SourceColumn = "empSalary", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@deptId", SourceColumn = "deptId", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Original });
            //whetevar giving in where cluase must be origin

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into employee values(@empid,@empName,@empSalary,@deptId)";


            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empName", SourceColumn = "empName", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empSalary", SourceColumn = "empSalary", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@deptId", SourceColumn = "deptId", SourceVersion = DataRowVersion.Current });
           


            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.UpdateCommand = cmdUpdate;
            da1.InsertCommand = cmdInsert;
            da1.Update(ds,"Ems");

            MessageBox.Show("Data Updated");
            cn.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();


            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = System.Data.CommandType.Text;
            cmdUpdate.CommandText = "update employee set empName = @empName, empSalary = @empSalary,deptId = @deptId where empid=@empid ";

            //SqlParameter p = new SqlParameter();
            //p.ParameterName = "@empName";
            //p.SourceColumn = "empName";
            //p.SourceVersion = DataRowVersion.Current;

            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empName", SourceColumn = "empName", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empSalary", SourceColumn = "empSalary", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@deptId", SourceColumn = "deptId", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Original });
            //whetevar giving in where cluase must be origin

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into employee values( @empid,@empName,@empSalary,@deptId ";


            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empName", SourceColumn = "empName", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empSalary", SourceColumn = "empSalary", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@deptId", SourceColumn = "deptId", SourceVersion = DataRowVersion.Current });



            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.UpdateCommand = cmdUpdate;
            da1.InsertCommand = cmdInsert;

            //DataSet ds2= 

            da1.Update(ds, "Ems");
            ds.AcceptChanges();
            MessageBox.Show("Data Updated");
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ds.RejectChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //DataView dv = new DataView(ds.Tables["Ems"]);
            //dv.RowFilter = "deptId=";
            //dgEms.ItemsSource = dv;

            ds.Tables["Ems"].DefaultView.RowFilter = "deptId=" + txtDeptId.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //ds.GetXml();
            //ds.GetXmlSchema();

            ds.WriteXmlSchema("a.xsd");
            ds.WriteXml("a.xml",XmlWriteMode.DiffGram);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ds = new DataSet();
            ds.ReadXmlSchema("a.xsd");
            ds.ReadXml("a.xml",XmlReadMode.DiffGram);
            dgEms.ItemsSource = ds.Tables["Ems"].DefaultView;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();


            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = cn;
            cmdUpdate.CommandType = System.Data.CommandType.Text;
            cmdUpdate.CommandText = "update employee set empName = @empName, empSalary = @empSalary,deptId = @deptId where empid=@empid ";

            //SqlParameter p = new SqlParameter();
            //p.ParameterName = "@empName";
            //p.SourceColumn = "empName";
            //p.SourceVersion = DataRowVersion.Current;

            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empName", SourceColumn = "empName", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empSalary", SourceColumn = "empSalary", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@deptId", SourceColumn = "deptId", SourceVersion = DataRowVersion.Current });
            cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Original });
            //whetevar giving in where cluase must be origin

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into employee values( @empid,@empName,@empSalary,@deptId ";


            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empid", SourceColumn = "empid", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empName", SourceColumn = "empName", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@empSalary", SourceColumn = "empSalary", SourceVersion = DataRowVersion.Current });
            cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@deptId", SourceColumn = "deptId", SourceVersion = DataRowVersion.Current });



            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.UpdateCommand = cmdUpdate;
            da1.InsertCommand = cmdInsert;

            DataSet ds2 = ds.GetChanges();

            da1.Update(ds2, "Ems");
            
            MessageBox.Show("Data Updated");
        }
    }
}
