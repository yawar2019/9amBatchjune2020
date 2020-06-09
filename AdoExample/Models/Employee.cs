using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoExample.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

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
    }
}