using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  DatabaseConnection databaseConnection = new DatabaseConnection();
              // databaseConnection.insert("INSERT Users VALUES ('Rick','paper0',4);");
              // databaseConnection.select("SELECT * FROM Users");
              String[] values = { "Kimmie", "popcorn13", "3" };
             // databaseConnection.formatInsert("Users",values );
              String[] update = {"UserName = 'Bob'" };
              String[] filter = new String [0];
              String[] selection = { "*" };
              //databaseConnection.formatUpdate("Users", update, "UserID", "4");
              databaseConnection.formatDelete("Users", "UserName", "Bob");
              databaseConnection.selectFormat(selection, filter, "Users");*/
            // Login login = new Login();
            //   Fetch fetch = new Fetch();
            // HouseSearch search = new HouseSearch();
            // var results = search.findAHouseByNumber("4611");
            ///    try
            /*   {
                 House house = results;
                   Console.WriteLine(house.HouseNumber1);

               }
               catch{
                   Alert alert = new Alert();
                   alert.CreateBasicAlert(3, "No Matches Found", "Error");
               }*/
            //   SearchMaintenanceRequests search = new SearchMaintenanceRequests();
            //List<MaintenanceRequest> maintenanceRequests = search.searchForRequestsByType(1);
            // MaintenanceRequest request = search.searchByHouseNumber("4588");
            // Console.WriteLine(request.Appliances[0].Brand1);
              TransactionManager tenantTransaction = new TransactionManager();
              var results = tenantTransaction.GetTenantTransactions("McAlpine");
            //  DatabaseConnection<TransactionManager> databaseConnection = new DatabaseConnection<TransactionManager>();
            //databaseConnection.insertTransaction();
            results[1].notes.Append("ABCD");
             results = tenantTransaction.UpdateTenantTransactions(results[1]);
            results = tenantTransaction.DeleteTenantTransaction(results[1].transactionID, results[1].LeadtenantID);
            foreach ( TenantTransaction result in results)
            {
                Console.WriteLine("Transaction ID:" + result.transactionID + " " + "Transaction Date: " + result.transactionDate+ " " + "Transaction Balance:" + result.currentBalance + " " +"Notes"+ result.notes.ToString());
                
            }
         
        
           

           // MaintenanceRequest maintenanceRequest = new MaintenanceRequest(1,false,true, DateTime.Today,DateTime.Today,DateTime.Today,DateTime.Today,1,1," "," ");

        }
    }
}
