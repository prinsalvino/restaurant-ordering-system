using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using RestaurantModel;

namespace Restaurant_DAL
{
    public class Login_DAO : Base
    {
        public Employee GetEmployee(string username,string password)
        {
            string query = $"SELECT E.Name,E.Number,E.RoleId FROM Credentials AS C JOIN Employees AS E ON C.EmployeeNumber = E.Number " +
                $"WHERE Username LIKE '{username}' AND Password LIKE '{password}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadTables(DataTable dataTable)
        {
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {
                employee.Name = (String)dr["Name"];
                employee.Role = (EmployeeRole)(dr["RoleId"]);
                employee.Number = (int)dr["Number"];
            }
            return employee;
        }
    }
}
