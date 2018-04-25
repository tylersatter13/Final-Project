using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace Final_Project
{
    class DatabaseConnection
    {
        Alert alert = new Alert();

          public List<object> selectFormat(String[] fields, String[] filters, String tablename)
        {
            String SQL = "SELECT * FROM Users";

          /* foreach (string field in fields) // adds all fields to be returned in the search Query
           {
               SQL += field + ",".PadRight(1); 
           }
           SQL += "FROM".PadLeft(1) 

           for
          + tablename.PadRight(1) + "WHERE".PadRight(1);



           foreach (string filter in filters)
           {
               SQL += filter.PadRight(1);// 
           }
           Console.WriteLine(SQL);*/
           return select(SQL);
       }
        public void formatInsert(String tableName,String[] values)
        {
            int lastValuePostion = values.Length - 1;
            String SQL = "INSERT"+" "+ tableName.PadRight(2)+" " + "VALUES (";
            foreach (String value in values)
            {
                SQL += "'" + value + "'";
              if (value == values[lastValuePostion])
                {
                    SQL += ")";
                }
                else
                {
                    SQL += ",";
                }
            } // end of for each
            //Console.WriteLine(SQL);
            insert(SQL);

        }
        public void formatUpdate(String tableName, String[] updateColumns)
        {

        }
   
        public void formatDelete(String tableName, String objectID, String idName)
        {
            String SQL = "DELETE FROM" + " " + tableName + " " + "WHERE" + " " + objectID + " = " + idName;
            Console.WriteLine(SQL);
            insert(SQL);
        }
        private void insert(string SQL)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("property_manager"))) // For actions that modify the table
            {
                connection.Execute(SQL);
            }
        }
        private List<object> select(string SQL)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("property_manager"))) // From Actions that return values
            {

                var results = connection.Query<object>(SQL).ToList();

                results.ForEach(Console.WriteLine);
                return results;

            }
        }
    }
}
