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
    public class Employee_DAO : Base
    {
        public Employee GetCurrentEmployee(Login login)
        {
            string query = $"SELECT name,number,RoleID FROM Employees WHERE Number = {login.EmployeeNumber}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private Employee ReadTables(DataTable dataTable)
        {
            Employee employee = new Employee();
            foreach (DataRow dr in dataTable.Rows)
            {
                employee.Name = (String)dr["Name"];
                employee.Number = (int)dr["Number"];
                employee.Role = (EmployeeRole)dr["RoleID"];                         
            }
            return employee;
        }
    }
}
