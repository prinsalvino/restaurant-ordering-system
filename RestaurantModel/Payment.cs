using System;
using System.Collections.Generic;

namespace RestaurantModel
{
    public class Payment 
    {
        public DateTime Date = DateTime.Now;

        public Decimal Total { get; set; }
        public Decimal Tip { get; set; }
        public Decimal Tax { get; set; }

        public PaymentMethod PaymentMethod;
        Session session;
        public Payment( Session session)
        {
            this.session = session;
        }


        public void CalculateVAT_TotalPrice(List<OrderItem> orders)
        {
            decimal taxPerItem;
            decimal totalTax = 0;
            decimal totalPrice = 0;

            foreach (OrderItem item in orders)
            {
  
                if (item.Category == Category.Alcoholic)
                {
                    taxPerItem = (item.Price * Convert.ToDecimal(0.21));
                }
                else
                {
                    taxPerItem = ((item.Price) * Convert.ToDecimal(0.06));
                }
                totalTax += taxPerItem;
                totalPrice += (item.Price + taxPerItem);
            }
            Total = totalPrice;
            Tax = totalTax;

        }
    }
}


                



