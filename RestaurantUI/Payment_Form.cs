
using Restaurant_Logic;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_UI
{
    partial class Payment_Form : Form
    {
        Table_Form table_Form;
        Payment payment;
        Session session;
        Payment_Service payment_Service = new Payment_Service();
        public Payment_Form(Table_Form table_Form, Session session)
        {
            InitializeComponent();
            payment = new Payment(session);
            this.table_Form = table_Form;
            this.session = session;
            Tiptxt_bx.Visible = true;
        }
        private void Payment_Form_Load(object sender, EventArgs e)
        {
            Table_Numberlbl.Text = session.Table.Number.ToString();
            DisplayOrderItems();
            Tax_txt_bx.Text = string.Format("{0:c}", payment.Tax);
            Total_txt_bx.Text = string.Format("{0:c}", payment.Total);
        }
        private void DisplayOrderItems()
        {
            List<OrderItem> orderItems = payment_Service.GetOrderItems(session);
            foreach (OrderItem item in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.MenuItem.Name);
                listViewItem.SubItems.Add(item.Category.ToString());
                listViewItem.SubItems.Add(item.Amount.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.Tag = item;
                OrdersListView.Items.Add(listViewItem);
            }
            payment.CalculateVAT_TotalPrice(orderItems);
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel.", "Confirm cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                table_Form.Show(); //go to table view
            }
        }
        private PaymentMethod SelectPaymentMethod()
        {
            PaymentMethod paymentMethod = 0;
            if (PinRadiobtn.Checked == true)
            {
                paymentMethod = PaymentMethod.Pin;
            }
            else if (creditCardRdbtn.Checked == true)
            {
                paymentMethod = PaymentMethod.CreditCard;
            }
            else if (cashRadiobtn.Checked == true)
            {
                paymentMethod = PaymentMethod.Cash;
            }
            return paymentMethod;
        }
        // process payment 
        private void PayOrderbtn_Click(object sender, EventArgs e)
        {
            payment.PaymentMethod = SelectPaymentMethod();
            
            if (OrdersListView.Items.Count == 0)
            {
                MessageBox.Show("Place an order first.", "There is no order to pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (payment.PaymentMethod == 0)
            {
                MessageBox.Show("Please select payment method.", "Payment method is not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to make a payment.", "Confirm payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    SavePaidOrderItems();
                    PaymentConfirmation();
                }
            }
        }
        //save paid order to database
        private void SavePaidOrderItems()
        {
            string comments = commentstxt_box.Text;
            Session_Service session_Service = new Session_Service();

            if (!String.IsNullOrEmpty(commentstxt_box.Text))
            {
                session_Service.SaveComments(session, comments);
            }
            session.Table.Status = TableStatus.Available;
            session_Service.UpdateTablePayment(session);     // end session
            payment_Service.SavePaidOrder(payment, session);  // save order details
        }
        private void PaymentConfirmation()
        {
            MessageBox.Show(" Payment successful.", "Payment recieved", MessageBoxButtons.OK, MessageBoxIcon.None);
            table_Form.Show(); // back to table view
        }
        private void Tiptxt_bx_TextChanged(object sender, EventArgs e)
        {
            Tiptxt_bx.Text = Tiptxt_bx.Text.Trim();
            try
            {
                if (Tiptxt_bx.Text == "")
                {
                    payment.Tip = 0;
                }
                else
                {
                    payment.Tip = Decimal.Parse(Tiptxt_bx.Text);
                }
                decimal totalPrice = payment.Tip + payment.Total;
                Total_txt_bx.Text = string.Format("{0:C}", totalPrice);
            }
            catch (Exception m)
            {
                MessageBox.Show("Enter numbers only" + m.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PinRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            AddTip_lbl.Visible = true;
            Tiptxt_bx.Visible = true;
        }

        private void CreditCardRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            AddTip_lbl.Visible = true;
            Tiptxt_bx.Visible = true;
        }

        private void CashRadiobtn_CheckedChanged(object sender, EventArgs e)
        {
            AddTip_lbl.Visible = false;
            Tiptxt_bx.Visible = false;
            Tiptxt_bx.Text = "";
        }
    }
}

    
 


