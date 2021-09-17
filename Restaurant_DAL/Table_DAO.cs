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
    public class Table_DAO : Base
    {
        public List<Table> GetTables()
        {
            //
            string query = "SELECT Number, StatusID FROM [Tables]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {                
                    Number = (int)dr["Number"],
                    Status = (TableStatus)dr["StatusId"]
                    
                };
                tables.Add(table);
            }
            return tables;
        }
        public void UpdateTable(Table table)
        {
            string query = ($"UPDATE Tables SET StatusId = {(int)table.Status} where Number = {table.Number}");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
