using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class TenantTransaction
    {
       public int transactionID;
       public int LeadtenantID;
       public DateTime transactionDate;
       public int transactiontype;
       public decimal transactionAmount;
       public decimal currentBalance;
       public  int transactionFlag;
       public StringBuilder notes = new StringBuilder();

        TenantTransaction(Int32  transactionID, Int32  LeadtenantID, DateTime transactionDate,
            Int32  transactiontype, decimal transactionAmount, decimal currentBalance, String Notes)
        {
            this.transactionID = transactionID;
            this.LeadtenantID = LeadtenantID;
            this.transactionDate = transactionDate;
            this.transactiontype = transactiontype;
            this.transactionAmount = transactionAmount;
            this.currentBalance = currentBalance;
            notes.Append(Notes);
        }
        public String getTransactionType()
        {
            switch (transactiontype)
            {
                case 1:
                    return "Debt";
                case 2:
                    return "Credit";
                default:
                    return "Unkown";
            }
        }
        public String getTransactionFlag()
        {
            switch (transactionFlag)
            {
                case 1: return "Late Fee";
                case 2: return "Monthly Payment";
                default: return "Other";

            }
        }

    }
}
