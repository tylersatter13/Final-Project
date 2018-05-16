using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class TransactionManager
    {
        private Fetch fetch = new Fetch();
        public List<TenantTransaction> GetTenantTransactions(String LastName)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LastName", LastName);

            String spName = "spGetTennatTransactions";

            var results = fetch.fetchTransaction(parameters, spName);
            return results;
        }
        public List<TenantTransaction> CreateTenantTransaction(int LeadTenantID, DateTime TransactionDate, int TransactionType, Decimal TransactionAmount, String Notes) // Inserts new transaction in to database then retrieves
        {
            DynamicParameters parameters = new DynamicParameters(); //Adds the required fields to create a new Tenants Transaction 
            parameters.Add("@LeadTenantID", LeadTenantID);
            parameters.Add("@TransactionDate",TransactionDate);
            parameters.Add("@TransactionTypeID", TransactionType);
            parameters.Add("@TransactionAmount", TransactionAmount);
            parameters.Add("TransactionNotes", Notes);

            String spName = "spCreateTransaction";

            DatabaseConnection<String> conncetion = new DatabaseConnection<String>();
            var results /*lastname*/ = fetch.fetchTransaction(parameters, spName);

           // var results = GetTenantTransactions(lastname[0]);
            return results; // returns  updated transactions List
        }
        public List<TenantTransaction> UpdateTenantTransactions (TenantTransaction transaction)
        {
            return UpdateTenantTransactions(transaction.LeadtenantID, transaction.transactionID, transaction.transactionDate,
                transaction.transactiontype, transaction.transactionAmount, transaction.notes.ToString());
        }
        private List<TenantTransaction> UpdateTenantTransactions(int LeadTenant, int TransactionID, DateTime TransactionDate,
            int TransactionType, decimal TransactionAmount, String TransactionNotes)
        {
            String spName = "spUpdateTransaction ";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LeadTenantID", LeadTenant);
            parameters.Add("@TransactionID", TransactionID);
            parameters.Add("@TransactionDate", TransactionDate);
            parameters.Add("@TransactionTypeID", TransactionType);
            parameters.Add("@TransactionAmount", TransactionAmount);
            parameters.Add("TransactionNotes", TransactionNotes);


            return fetch.fetchTransaction(parameters, spName);
        }
        public List<TenantTransaction> DeleteTenantTransaction(int TransactionID, int LeadTenantID) // Deletes a transaction a return updated results
        {
          String spName  ="spDeleteTenantTransaction";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TransactionID", TransactionID);
            parameters.Add("@LeadTenantID", LeadTenantID);

            return fetch.fetchTransaction(parameters, spName);
        }
    }
}
