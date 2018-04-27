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
    class DatabaseConnection <T> where T:class // T can only repesent a class
    {
        Alert alert = new Alert();

          public List<T> selectFormat(String[] fields, String[] filters, String tablename)
        {
            StringBuilder SQL = new StringBuilder();
            int lastField = fields.Length - 1;
            SQL.Append("SELECT" + " ");
           foreach (string field in fields) // adds all fields to be returned in the search Query
           {
                SQL.Append(field);
                if (field == fields[lastField]) // no comma comma will be added on the last field
                {
                    SQL.Append(" ");
                }
                else //Only add commas if there will be another field
                {
                    SQL.Append(",");

                }

           }
            SQL.Append("FROM" + " " + tablename + " ");

            if (filters.Length != 0)
            {
                foreach (string filter in filters)
                {
                    if (filter == filters[0]) // IF where is Found ADD Where command to The SQL Query
                    {
                        SQL.Append("WHERE" + " ");
                    }
                    SQL.Append(filter); // Filter is added to the query
                }
            }
           Console.WriteLine(SQL);

           return select(SQL);
       }
        public void formatInsert(String tableName,String[] values)
        {
            int lastValuePostion = values.Length - 1;
            StringBuilder SQL = new StringBuilder(); //String Builder is used to save system memory
            SQL.Append( "INSERT"+" "+ tableName+" " + "VALUES (");

            foreach (String value in values)
            {
                SQL.Append("'" + value + "'");
              if (value == values[lastValuePostion])
                {
                    SQL.Append(")"); //Closes the value collection after the last value in the loop
                }
                else
                {
                    SQL.Append(","); // a comma is added to seperate values until the last section is reached 
                }
            } // end of for each
            Console.WriteLine(SQL);
            insert(SQL);

        }
        public void formatUpdate(String tableName, String[] updateColumns, String conditionColumnName, String conditionCritera)
        {
            int lastPostion = updateColumns.Length - 1;
            StringBuilder SQL = new StringBuilder();

            SQL.Append("UPDATE" + " " + tableName + " " + "SET" + " "); // Add the The table that is being uopdated

            foreach (String column in updateColumns)
            {
                SQL.Append(column);
               
                if (column == updateColumns[lastPostion])
                {
                    SQL.Append(" ");
                }
                else
                {
                    SQL.Append(",");
                }
            }//end of foreach
            SQL.Append("WHERE" + " " + conditionColumnName + "=" + conditionCritera);
            //  Console.WriteLine(SQL);
            insert(SQL);
        }
   
        public void formatDelete(String tableName, String objectID, String idName)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append("DELETE FROM" + " " + tableName + " " + "WHERE" + " " + objectID + " = " + idName);
            SQL.Replace(idName, "'" + idName + "'");
            Console.WriteLine(SQL);
            insert(SQL);
        }
        private void insert(StringBuilder SQL)
        {

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("property_manager"))) // For actions that modify the table
            {
                connection.Execute(SQL.ToString());
            }
        }
        private List<T> select(StringBuilder SQL)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("property_manager"))) // From Actions that return values
            {

                var results = connection.Query<T>(SQL.ToString()).ToList();

                return results;

            }
        }
    }
}
