using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Logic
{
    public class Payment_Service
    {
        Payment_DAO paymentDao = new Payment_DAO();

        public void SavePaidOrder(Payment payment, Session session)
        {
            paymentDao.SavePaidOrder(payment, session);
      
        }
      
        public List<OrderItem> GetOrderItems(Session session)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            return orderItems = paymentDao.GetOrderItems(session);
        }
    }
}
