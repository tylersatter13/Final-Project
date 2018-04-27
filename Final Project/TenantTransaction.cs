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
       public int tenantID;
       public DateTime transactionDate;
       public int transactiontype;
       public double transactionAmount;
       public double currentBalance;
       public  int transactionFlag;
       public StringBuilder notes;

        TenantTransaction(int transactionID, int tenantID, DateTime transactionDate, int transactiontype, double transactionAmount, double currentBalance, int transactionFlag, StringBuilder notes)
        {
            this.transactionID = transactionID;
            this.tenantID = tenantID;
            this.transactionDate = transactionDate;
            this.transactiontype = transactiontype;
            this.transactionAmount = transactionAmount;
            this.currentBalance = currentBalance;
            this.transactionFlag = transactionFlag;
            this.notes = notes;
        }
        public String getTransactionType()
        {
            switch (transactiontype)
            {
                case 1:
                    return "Debt";
                case 2: return "Credit";
                default: return "Unkown";
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
