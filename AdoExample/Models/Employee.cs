using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoExample.Models
{
    public class Employee
    {
        [Display(Name ="Id")]
        public int EmpId { get; set; }
        [Display(Name ="Name")]
        public string EmpName { get; set; }
        [Display(Name = "Salary")]

        public int EmpSalary { get; set; }

    }

    public class Employeeinfo
    {
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<Employee> getEmployee() {

            List<Employee> objlist = new List<Employee>();
            SqlCommand cmd = new SqlCommand("sp_employee",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Employee obj = new Employee();
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName =Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                objlist.Add(obj);
            }
            return objlist;
        }

        public int SaveEmployee(Employee obj)
        {
            SqlCommand cmd = new SqlCommand("spr_insertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public  Employee  getEmployeeById(int? Id)
        {

            Employee  obj  = new  Employee ();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", Id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                 
            }
            return obj;
        }
        

            public int UpdateEmployee(Employee obj)
        {
            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", obj.EmpId);
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        

        public int DeleteEmployee(int? Id)
        {
            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", Id);
             
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}