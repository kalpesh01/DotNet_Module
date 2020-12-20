using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {

            List<Employee> objEmpList = new List<Employee>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False"; 

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee";


            SqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {

                objEmpList.Add(new Employee { empid= Convert.ToInt32( dr["empid"]),empName=(string)(dr["empName"]),empSalary=Convert.ToDecimal( dr["empSalary"]),deptId= Convert.ToInt32( dr["deptId"])});

            }

          
            dr.Close();
            cn.Close();

           

            return View(objEmpList);

            return View();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee where empid = @empid";
            cmd.Parameters.AddWithValue("@empid", id);

            SqlDataReader dr = cmd.ExecuteReader();


            Employee objEmp = new Employee();


            while (dr.Read())
            {

                objEmp.empid = Convert.ToInt32(dr["empid"]);
                objEmp.empName = (string)(dr["empName"]);
                objEmp.empSalary = Convert.ToDecimal(dr["empSalary"]);
                objEmp.deptId = Convert.ToInt32(dr["deptId"]);
            }
            

            dr.Close();
            cn.Close();
            return View(objEmp);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee objEmp)
        {
            try
            {
                // TODO: Add insert logic here
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = "insert into employee values(@empid,@empName,@empSalary,@deptId)";

                cmdInsert.Parameters.AddWithValue("@empid", objEmp.empid);
                cmdInsert.Parameters.AddWithValue("@empName", objEmp.empName);
                cmdInsert.Parameters.AddWithValue("@empSalary", objEmp.empSalary);
                cmdInsert.Parameters.AddWithValue("@deptId", objEmp.deptId);

               

                cmdInsert.ExecuteNonQuery();
                //da.InsertCommand = cmdInsert;
               
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee where empid = @empid";
            cmd.Parameters.AddWithValue("@empid", id);

            SqlDataReader dr = cmd.ExecuteReader();


            Employee objEmp = new Employee();


            while (dr.Read())
            {

                objEmp.empid = Convert.ToInt32(dr["empid"]);
                objEmp.empName = (string)(dr["empName"]);
                objEmp.empSalary = Convert.ToDecimal(dr["empSalary"]);
                objEmp.deptId = Convert.ToInt32(dr["deptId"]);
            }


            dr.Close();
            cn.Close();
            return View(objEmp);
          
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee objEmp)
        {
            try
            {
                // TODO: Add insert logic here
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = "update employee set empName =@empName, empSalary= @empSalary, deptId = @deptId where empid =@empid";

                cmdUpdate.Parameters.AddWithValue("@empName", objEmp.empName);
                cmdUpdate.Parameters.AddWithValue("@empSalary", objEmp.empSalary);
                cmdUpdate.Parameters.AddWithValue("@deptId", objEmp.deptId);
                cmdUpdate.Parameters.AddWithValue("@empid", id);


                cmdUpdate.ExecuteNonQuery();
                //da.InsertCommand = cmdInsert;

                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee where empid = @empid";
            cmd.Parameters.AddWithValue("@empid", id);

            SqlDataReader dr = cmd.ExecuteReader();


            Employee objEmp = new Employee();


            while (dr.Read())
            {

                objEmp.empid = Convert.ToInt32(dr["empid"]);
                objEmp.empName = (string)(dr["empName"]);
                objEmp.empSalary = Convert.ToDecimal(dr["empSalary"]);
                objEmp.deptId = Convert.ToInt32(dr["deptId"]);
            }


            dr.Close();
            cn.Close();
            return View(objEmp);
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee objEmp)
        {
            try
            {
                // TODO: Add insert logic here
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = cn;
                cmdDelete.CommandType = CommandType.Text;
                cmdDelete.CommandText = "delete from employee  where empid =@empid";


                cmdDelete.Parameters.AddWithValue("@empid", id);


                cmdDelete.ExecuteNonQuery();
                //da.InsertCommand = cmdInsert;

                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }
    }
}
