using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Restaurant_Logic
{
    public class MenuItem_Service
    {
        MenuItem_DAO menuItem_DAO = new MenuItem_DAO();

	

		public List<MenuItem> GetMenuItems()
        {
			try
			{
				List<MenuItem> menuitems = menuItem_DAO.GetMenuItems();
                return menuitems;
			}
            catch (Exception e)
            {
                ErrorLogging(e);

                return null;
            }
		}

		public List<MenuItem> GetMenuItemsByCategory(Category category)
		{
			try
			{
				List<MenuItem> menuitems = menuItem_DAO.GetMenuItemsByCategory(category);
				return menuitems;
			}
			catch (Exception e)
			{
				ErrorLogging(e);

				return null;
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
