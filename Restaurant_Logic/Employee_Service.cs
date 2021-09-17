using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant_Logic
{
    public class Employee_Service
    {
        Employee_DAO employee_db = new Employee_DAO();
        public Employee GetCurrentEmployee(Login login)
        {
            Employee employee = employee_db.GetCurrentEmployee(login);
            return employee;
        }
    }
}
