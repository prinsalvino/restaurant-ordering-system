using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using RestaurantModel;

namespace Restaurant_DAL
{
    public class OrderItem_DAO : Base
    {
        public List<OrderItem> GetUnReadyFoodItemsOrderByTakenTime()
        {
            string query = @" select m.Name,i.Quantity,i.Comment,s.State, FORMAT (o.TakenAt, 'hh:mm:ss') as ordertime,se.TableId, o.Id as OrderID,i.Id as ItemID  from Orders o 
								join OrderItems i on o.Id=i.OrderId
								join OrderState s on s.Id=i.StateId
								join MenuItems m on m.Id=i.MenuItemId
								join Dishes d on m.Id=d.Id
								join Sessions se on se.Id=o.SessionId where i.StateId!=3 and i.stateid != 4
                                order by  FORMAT (o.TakenAt, 'hh:mm:ss') ";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_OrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetUnReadyDrinkItemsOrderByTakenTime()
        {
            string query = @"select m.Name,i.Quantity,i.Comment,s.State, FORMAT (o.TakenAt, 'hh:mm:ss') as ordertime,se.TableId, o.Id as OrderID,i.Id as ItemID  from Orders o 
								join OrderItems i on o.Id=i.OrderId
								join OrderState s on s.Id=i.StateId
								join MenuItems m on m.Id=i.MenuItemId
								join Drinks d on m.Id=d.Id
								join Sessions se on se.Id=o.SessionId where i.StateId!=3 and i.stateid != 4
                                order by  FORMAT (o.TakenAt, 'hh:mm:ss') ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_OrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

		public void PushOrderItem(OrderItem orderItem)
		{
			string query = "INSERT INTO OrderItems " +
				$"VALUES ({orderItem.OrderId}, {orderItem.MenuItem.Id}, {(int)orderItem.Status}, {orderItem.Amount}, '{orderItem.Comment}');";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			ExecuteEditQuery(query, sqlParameters);
		}

		private List<OrderItem> ReadTables_OrderItems(DataTable dataTable)
        {
            List<OrderItem> OrderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Name = (string)dr["Name"]
                };

                OrderItem OrderItem = new OrderItem()
                {
                    MenuItem = menuItem,
                    Amount = (int)dr["Quantity"],
                    Comment = (string)dr["Comment"],
                    Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Convert.ToString(dr["State"])),
                    Ordertime = (string)dr["ordertime"],
                    TableNumber = (int)dr["TableId"],
                    OrderId = (int)dr["OrderID"],
                    Id = (int)dr["ItemID"],
                    
                };
                OrderItems.Add(OrderItem);
            }
            return OrderItems;
        }
  //*******************updates only state of one item not the whole oorder
        public void UpdateOrdersItemsState(OrderItem orderItem, OrderStatus newState) //MarkAsProccessing
        {
            string query = @"update OrderItems set  StateId=@StateId where Id=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@StateId", SqlDbType.Int) { Value = (int)newState };
            sqlParameters[1] = new SqlParameter("@Id", SqlDbType.Int) { Value = orderItem.Id };
            ExecuteEditQuery(query, sqlParameters);
        }

        //********************************** end kitchen overview code

        public List<OrderItem> GetOrderItemReady()
        {
            string query = "SELECT OI.Id, m.Name,OI.StateId,s.TableId,OI.Quantity " +
                "FROM MenuItems AS M JOIN OrderItems as OI on OI.MenuItemId = m.Id " +
                "JOIN Orders AS O on OI.OrderId = o.Id " +
                "JOIN Sessions AS S ON O.SessionId = S.Id " +
                "WHERE OI.StateId = 3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Name = (String)dr["Name"]
                };

                OrderItem orderItem = new OrderItem()
                {
                    MenuItem = menuItem,
                    TableNumber = (int)dr["tableid"],
                    Status = (OrderStatus)dr["StateId"],
                    Amount = (int)dr["Quantity"],
                    Id = (int)dr["Id"]
                };

                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public void UpdateStatus(OrderItem orderItem)
        {
            string query = ($"UPDATE OrderItems SET StateId = {(int)orderItem.Status} where id = {orderItem.Id}");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

     
    }
}
