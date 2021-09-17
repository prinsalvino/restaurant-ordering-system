using RestaurantModel;
using Restaurant_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_UI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();         
        }
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //Get Current Employee
            Login_Service Login_Service = new Login_Service();
            Employee currentemployee = Login_Service.GetEmployee(txtusername.Text, txtpassword.Text);

            //Hide login form
            if (currentemployee.Role == EmployeeRole.Chef || currentemployee.Role == EmployeeRole.Barman)
            {
                //Display Kitchen UI
                Kitchen_Form kitchen_Form = new Kitchen_Form(currentemployee,this);
                kitchen_Form.Show();
                this.Hide();
            }
            else if (currentemployee.Role == EmployeeRole.Waiter)
            {
                //Display WaiterUI
                Table_Form table_Form = new Table_Form(currentemployee, this);
                table_Form.Show();
                this.Hide();
            }
            else
            {
                //Show Message Box
                string message = "Wrong Username / Password";
                string title = "Enter valid login credentials";
                MessageBox.Show(message, title);
            }
            //ClearingTextBox for logging in after logging out
            txtusername.Text = "";
            txtpassword.Text = "";
        }
        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
