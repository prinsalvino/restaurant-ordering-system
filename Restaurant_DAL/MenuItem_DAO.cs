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
    public class MenuItem_DAO : Base
    {
        public List<MenuItem> GetMenuItems()
        {
            string query = "SELECT Id, Name, Price, Stock, CategoryId FROM MenuItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

		public List<MenuItem> GetMenuItemsByCategory(Category category)
		{
			string query = "SELECT Id, Name, Price, Stock, CategoryId " +
				"FROM MenuItems " +
				$"WHERE CategoryId = {(int)category}";
			SqlParameter[] sqlParameters = new SqlParameter[0];
			return ReadTables(ExecuteSelectQuery(query, sqlParameters));
		}

		private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Id = (int)dr["Id"],
                    Name = (String)(dr["Name"]),
                    Price = (decimal)dr["Price"],
                    Stock = (int)dr["Stock"],
					Category = (Category)dr["CategoryId"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
        
    }
}
