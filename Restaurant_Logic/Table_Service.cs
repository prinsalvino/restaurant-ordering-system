using Restaurant_DAL;
using RestaurantModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant_Logic
{
    public class Table_Service
    {
        Table_DAO table_DAO;
   
        public Table_Service()
        {
            table_DAO = new Table_DAO();
        }

        public List<Table> GetTables()
        {
            try
            {
                List<Table> tables = table_DAO.GetTables();
                return tables;
            }
            catch (Exception )
            {
                return null;
            }
        }
        public void UpdateStatus(Table table)
        {
            table_DAO.UpdateTable(table);
        }
    }
}
