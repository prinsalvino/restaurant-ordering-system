using RestaurantModel;
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

namespace Restaurant_UI
{
    public partial class Kitchen_Form : Form
    {
        OrderItem_Service Logic = new OrderItem_Service();
        List<OrderItem> Orders;
        Employee CurrentEmployee;
        Login_Form login_Form;

        public Kitchen_Form(Employee employee,Login_Form login_Form)
        {
            InitializeComponent();
            DesignGridView();
            this.CurrentEmployee = employee; // get the current Employee
            this.login_Form = login_Form;
            this.Text = "Welcome   " + CurrentEmployee.Name;
            LoadAndDisplayData(CurrentEmployee);// load Data
        }
        private void Kitchen_Form_Load(object sender, EventArgs e)
        {
            dgviewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// make the column adjust to fit the content 
            lbl_Datetime.Text = "Current time : " + DateTime.Now.ToString("h:mm:ss tt");
            timerRefresh.Enabled = true;
            timerRefresh.Interval = 20000;//refresh every 20 seconds 
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadAndDisplayData(CurrentEmployee);
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            login_Form.Show();// exit and go to the default form (login form)
            this.Close();
        }

        private void dgviewOrders_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void btn_PrepareMany_Click(object sender, EventArgs e)
        {
            List<OrderItem> Items = new List<OrderItem>();// to remove later 
            foreach (DataGridViewRow row in dgviewOrders.SelectedRows)
            {
                if (row.Index >= 0)
                {
                    OrderItem currentObject = (OrderItem)row.Tag;
                    if (currentObject != null)
                        Items.Add(currentObject);// get the Object
                }
            }
            if (Items.Count>0)
            {
                if (MessageBox.Show("Are you sure you want to mark this orders as : Ready ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    foreach (OrderItem  item in Items)
                    {
                        Logic.MarkAsReady(item, OrderStatus.Ready);
                        Orders.Remove(item);
                    }
                    // LoadAndDisplayData(CurrentEmployee);
                    FillinGridView();
                  //  MessageBox.Show(Items.Count + " Items were marked as ready");
                }
                else
                    MessageBox.Show("Operation was aborted ");
            }
            else
            {
                MessageBox.Show("please select an item");
            }
        }

        private void DisplayData()
        {
            try
            {
                OrderItem orderItem=null;
                foreach (DataGridViewRow row in dgviewOrders.Rows)
                {
                    if (row.Index >= 0)
                    {
                        orderItem = (OrderItem)row.Tag;
                        if (orderItem.Status == OrderStatus.Waiting)
                            row.DefaultCellStyle.BackColor = Color.Red;
                        else if (orderItem.Status == OrderStatus.Processing)
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        else if (orderItem.Status == OrderStatus.Ready)
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            } catch (Exception)  { }

        }
        private void DesignGridView()
        {
            dgviewOrders.Columns.Add("Name", "Name");
            dgviewOrders.Columns.Add("Quantity", "Quantity");
            dgviewOrders.Columns.Add("Comment", "Comment");
            dgviewOrders.Columns.Add("Status", "State");
            dgviewOrders.Columns.Add("takenAt", "Taken At");
            dgviewOrders.Columns.Add("TableNumber", "Table Number");
        }
        private void FillinGridView()
        {
            dgviewOrders.Rows.Clear();
            foreach (OrderItem item in Orders)
            {
                int row = dgviewOrders.Rows.Add();
                dgviewOrders.Rows[row].Cells["Name"].Value = item.MenuItem.Name;
                dgviewOrders.Rows[row].Cells["Quantity"].Value = item.Amount;
                dgviewOrders.Rows[row].Cells["Comment"].Value = item.Comment;
                dgviewOrders.Rows[row].Cells["Status"].Value = item.Status;
                dgviewOrders.Rows[row].Cells["takenAt"].Value = item.Ordertime;
                dgviewOrders.Rows[row].Cells["TableNumber"].Value = item.TableNumber;
                dgviewOrders.Rows[row].Tag = item;
            }
            DisplayData();// for refrech
        }
        private void LoadAndDisplayData(Employee CurrentEmp)
        {
            if (CurrentEmp.Role == EmployeeRole.Chef)
            {
                Orders = Logic.GetUnReadyFoodItemsOrderByTakenTimeDesc();
            }
            else if (CurrentEmp.Role == EmployeeRole.Barman)
            {
                Orders = Logic.GetUnReadyDrinkItemsOrderByTakenTime();
            }
            FillinGridView();
            DisplayData();
        }
     
    }
}
