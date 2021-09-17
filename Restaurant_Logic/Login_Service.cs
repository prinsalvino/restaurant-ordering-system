using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Restaurant_Logic
{
    public class Login_Service
    {
        private Login_DAO login_db = new Login_DAO();

        public Employee GetEmployee(string username,string password)
        {
            try
            {
                Employee employee = login_db.GetEmployee(username,password);
                return employee;
            }
            catch (Exception e)
            {
                ErrorLogging(e);
                return null;
            }
        }
        private static void ErrorLogging(Exception e)
        {
			Debug.WriteLine("=============Error Logging ===========");
			Debug.WriteLine("===========Start============= " + DateTime.Now);
			Debug.WriteLine("Error Message: " + e.Message);
			Debug.WriteLine("Stack Trace: " + e.StackTrace);
			Debug.WriteLine("===========End============= " + DateTime.Now + "\n");
        }
    }
}
