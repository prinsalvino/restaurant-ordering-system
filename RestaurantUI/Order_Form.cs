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
    public partial class Order_Form : Form
    {
        List<RestaurantModel.MenuItem> menuItems = new List<RestaurantModel.MenuItem>();
        Table_Form table_Form;
        Session currentSession;

        public Order_Form( Table_Form table_Form, Session session)
        {
            InitializeComponent();
			Initialize(table_Form, session);
		}

        void Initialize(Table_Form table_Form, Session session)
        {
			this.table_Form = table_Form;
			currentSession = session;
		}
       
        private void Order_Form_Load(object sender, EventArgs e)
        {
            lblNumber.Text = $"Table {currentSession.Table.Number}";

			//ListView Setups
			lvMenuItems.Columns.Add("Name", 150, HorizontalAlignment.Left);
			lvMenuItems.Columns.Add("Price", 45, HorizontalAlignment.Left);
			lvMenuItems.Columns.Add("Stock", 45, HorizontalAlignment.Left);

			lvOrderItems.Columns.Add("Name", 150, HorizontalAlignment.Left);
			lvOrderItems.Columns.Add("Price", 50, HorizontalAlignment.Left);
			lvOrderItems.Columns.Add("Amount", 50, HorizontalAlignment.Left);


			MenuItem_Service menuItem_Service = new MenuItem_Service();
			List<RestaurantModel.MenuItem> menuItems = menuItem_Service.GetMenuItems();

			UpdateMenuItemListView(menuItems);
		}

		private void BtnOrder_Click(object sender, EventArgs e)
		{
			if(lvOrderItems.Items.Count != 0)
			{
				Order order = new Order(DateTime.Now);

				foreach (ListViewItem lvi in lvOrderItems.Items)
				{
					order.OrderItems.Add((OrderItem)lvi.Tag);
				}

				order.SessionId = currentSession.Id;

				//Push to database
				Order_Service order_Service = new Order_Service();
				OrderItem_Service orderItem_Service = new OrderItem_Service();

				order_Service.PushOrder(order);

				foreach(OrderItem orderItem in order.OrderItems)
				{
					orderItem.OrderId = order.Id;
				}

				orderItem_Service.PushOrderItems(order.OrderItems);

				lvOrderItems.Items.Clear();
			} else {
				MessageBox.Show("Please add an OrderItem to the OrderItem list first.", "OrderItems list empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
      
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in lvMenuItems.SelectedItems)
			{
				RestaurantModel.MenuItem menuItem = (RestaurantModel.MenuItem)lvi.Tag;

				//Check if MenuItem is already in OrderItem list.
				foreach(ListViewItem orderLvi in lvOrderItems.Items)
				{
					OrderItem orderItem = (OrderItem)orderLvi.Tag;
					if (menuItem == orderItem.MenuItem)
					{
						return;
					}
				}
				//Add Item to OrderItem list.
				OrderItem newOrderItem = new OrderItem
				{
					Amount = 1,
					MenuItem = menuItem,
					Status = OrderStatus.Waiting
				};

				ListViewItem lviNew = new ListViewItem(newOrderItem.MenuItem.Name);
				lviNew.SubItems.Add(newOrderItem.MenuItem.Price.ToString());
				lviNew.SubItems.Add(newOrderItem.Amount.ToString());
				lviNew.Tag = newOrderItem;

				lvOrderItems.Items.Add(lviNew);
			}
		}

		private void BtnRemove_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				lvOrderItems.Items.Remove(lvi);
			}
		}

		private void BtnChangeStatus_Click(object sender, EventArgs e)
		{
            table_Form.ChangeStatusForOrder();
            this.Hide();
		}

		private void BtnPay_Click(object sender, EventArgs e)
		{
            Payment_Form form = new Payment_Form(table_Form, currentSession);
            form.Show();
            Hide();
		}

		private void TxtComment_Leave(object sender, EventArgs e)
		{
			foreach(ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				OrderItem orderItem = (OrderItem)lvi.Tag;

				orderItem.Comment = txtComment.Text;
			}
		}

		private void LvOrderItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if(lvOrderItems.SelectedItems.Count == 1)
			{
				OrderItem orderItem = (OrderItem)lvOrderItems.SelectedItems[0].Tag;

				txtComment.Text = orderItem.Comment;
				nudQuantity.Value = orderItem.Amount;
			} else {
				txtComment.Text = "";
				nudQuantity.Value = 0;
			}
		}

		private void NudQuantity_ValueChanged(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				OrderItem orderItem = (OrderItem)lvi.Tag;

				orderItem.Amount = (int)nudQuantity.Value;

				lvi.SubItems[2].Text = orderItem.Amount.ToString();
			}
		}

		private void NudQuantity_Leave(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in lvOrderItems.SelectedItems)
			{
				OrderItem orderItem = (OrderItem)lvi.Tag;

				orderItem.Amount = (int)nudQuantity.Value;

				if(orderItem.Amount <= 0)
				{
					lvOrderItems.Items.Remove(lvi);
				}
			}
		}

		private void RdoButtons_Changed(object sender, EventArgs e)
		{
			MenuItem_Service menuItem_Service = new MenuItem_Service();

			List<RestaurantModel.MenuItem> menuItems;

			lvMenuItems.Items.Clear();

			if (rdoAll.Checked)
			{
				menuItems = menuItem_Service.GetMenuItems();

				UpdateMenuItemListView(menuItems);
			}
			else if(rdoLunch.Checked)
			{
				UpdateMenuItemListView(menuItem_Service.GetMenuItemsByCategory(Category.Lunch));
			}
			else if(rdoDinner.Checked)
			{
				UpdateMenuItemListView(menuItems = menuItem_Service.GetMenuItemsByCategory(Category.Dinner));
			}
			else if(rdoDrinks.Checked)
			{
				UpdateMenuItemListView(menuItem_Service.GetMenuItemsByCategory(Category.Beverage));
			}
			else if (rdoAlcoholic.Checked)
			{
				UpdateMenuItemListView(menuItem_Service.GetMenuItemsByCategory(Category.Alcoholic));
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lvOrderItems.Items.Clear();
		}

		private void Order_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(lvOrderItems.Items.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit? The ordering progress will be lost.", "Discarding OrderItems", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

				e.Cancel = (dialogResult == DialogResult.No);
			}
		}


		//TOOLS

		private void UpdateMenuItemListView(List<RestaurantModel.MenuItem> menuItems)
		{
			lvMenuItems.Items.Clear();

			foreach (RestaurantModel.MenuItem menuItem in menuItems)
			{
				ListViewItem lvi = new ListViewItem(menuItem.Name);
				lvi.SubItems.Add(menuItem.Price.ToString());
				lvi.SubItems.Add(menuItem.Stock.ToString());
				lvi.Tag = menuItem;
				lvMenuItems.Items.Add(lvi);
			}
		}

        private void BtnTableView_Click(object sender, EventArgs e)
        {
            Hide();
            table_Form.Show();
        }
    }
}
