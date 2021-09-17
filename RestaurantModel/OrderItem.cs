using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class OrderItem
    {
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public string Comment { get; set; }
        public OrderStatus Status { get; set; }
        public int TableNumber { get; set; }
        public string Ordertime { get; set; }
        public int OrderId { get; set; }
        public int Id { get; set; }
        public Category Category { get; set; }
        public MenuItem MenuItem { get; set; }

        public OrderItem()
        {

        }
    }
}
