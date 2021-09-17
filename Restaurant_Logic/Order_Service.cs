using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Restaurant_Logic
{
    public class Order_Service
    {
        Order_DAO order_DAO = new Order_DAO();

		public Order_DAO Order_DAO
		{
			get => default;
			set
			{
			}
		}

		public void AssignID(Order order)
		{
			order.Id = order_DAO.GetLastID();
		}

		public List<Order> GetOrder()
        {
            try
            {
                List<Order> orders = order_DAO.GetOrders();
                return orders;
            }
            catch (Exception e)
            {
                ErrorLogging(e);

                return null;
            }
        }

		public void PushOrder(Order order)
		{
			try
			{
				order_DAO.PushOrder(order);
				AssignID(order);
			}
			catch (Exception e)
			{
				ErrorLogging(e);
			}
		}

		public void PushOrders(List<Order> orders)
		{
			try
			{
				foreach(Order order in orders)
				{
					order_DAO.PushOrder(order);
				}
			}
			catch (Exception e)
			{
				ErrorLogging(e);
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
