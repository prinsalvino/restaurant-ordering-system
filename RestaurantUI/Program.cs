using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Logic;
using RestaurantModel;

namespace Restaurant_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Employee emp = new Employee();
            //emp.Role = "Chef";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Employee emp = new Employee();
            Application.Run(new Login_Form());
        }
    }
}
