using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModel;
using Restaurant_Logic;
using Restaurant_DAL;

namespace Restaurant_Logic
{
    public class OrderItems_Service
    {
        OrderItem_DAO orderItem_DAO = new OrderItem_DAO();
        Order_DAO Order_DAO = new Order_DAO();
        List<KitchenOrderItems> orderItems = new List<KitchenOrderItems>();
        //****************************************************************
        public List<KitchenOrderItems> GetFoodOrders(int OrderID)
        {
            return orderItems = orderItem_DAO.GetFoodItems(OrderID);
        }
        public List<KitchenOrderItems> GetDrinksOrders(int OrderID)
        {
            return orderItems = orderItem_DAO.GetDrinkItems(OrderID);
        }
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            return orders = orderItem_DAO.GetOrders();
        }
        public void UpdateOrderItemState(int orderItem, OrderState newSatate)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newSatate);
        }
        public void MarkAsRaady(int orderItem, OrderState newSatate)
        {
            orderItem_DAO.UpdateOrdersItemsState(orderItem, newSatate);
        }
    }
}
