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
    public class OrderItem_Service
    {
        OrderItem_DAO orderItem_DAO = new OrderItem_DAO();
        List<OrderItem> orderItems = new List<OrderItem>();
        public List<OrderItem> GetUnReadyFoodItemsOrderByTakenTimeDesc()
        {
            return orderItems = orderItem_DAO.GetUnReadyFoodItemsOrderByTakenTime();
        }
        public List<OrderItem> GetUnReadyDrinkItemsOrderByTakenTime()
        {
            return orderItems = orderItem_DAO.GetUnReadyDrinkItemsOrderByTakenTime();
        }
		public void PushOrder(OrderItem orderItem)
		{
			try
			{
				orderItem_DAO.PushOrderItem(orderItem);
			}
			catch (Exception e)
			{
				ErrorLogging(e);
			}
		}

		public void PushOrderItems(List<OrderItem> orderItems)
		{
			try
			{
				foreach (OrderItem orderItem in orderItems)
				{
					orderItem_DAO.PushOrderItem(orderItem);
				}
			}
			catch (Exception e)
			{
				ErrorLogging(e);
			}
		}
        public void MarkAsReady(OrderItem orderItem, OrderStatus newState)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newState);
        }
        public List<OrderItem> GetOrderItemReady()
        {
            return orderItems = orderItem_DAO.GetOrderItemReady();
        }
        public void UpdateStatus(OrderItem orderItem)
        {
            orderItem_DAO.UpdateStatus(orderItem);
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
