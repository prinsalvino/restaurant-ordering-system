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
	public class Order_DAO : Base
	{
		public int GetLastID()
		{
			string query = "SELECT TOP 1 Id FROM Orders ORDER BY ID DESC";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadId(ExecuteSelectQuery(query, sqlParameters));
		}

		public List<Order> GetOrders()
		{
			string query = "SELECT Id, TakenAt, Status FROM [Orders]";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		public void PushOrder(Order order)
		{
			string query = "INSERT INTO Orders " +
				$"VALUES ({order.SessionId}, '{order.TakenAt}');";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			ExecuteEditQuery(query, sqlParameters);
		}

		private List<Order> ReadTables(DataTable dataTable)
		{
			List<Order> orders = new List<Order>();

			foreach (DataRow dr in dataTable.Rows)
			{
				Order order = new Order()
				{
					Id = (int)dr["Id"],
					TakenAt = (DateTime)dr["TakenAt"],
				};
				orders.Add(order);
			}
			return orders;
		}

		private int ReadId(DataTable dataTable)
		{
			int id = 0;

			foreach (DataRow dr in dataTable.Rows)
			{
				id = (int)dr["Id"];
			}

			return id;
		}
	}
}
