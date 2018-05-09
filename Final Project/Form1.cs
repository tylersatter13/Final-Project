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
            //  TransactionManager tenantTransaction = new TransactionManager();
            //  var results = tenantTransaction.GetTenantTransactions("McAlpine");
            //  DatabaseConnection<TransactionManager> databaseConnection = new DatabaseConnection<TransactionManager>();
            //databaseConnection.insertTransaction();
            //  results[1].notes.Append("ABCD");
            //     results = tenantTransaction.UpdateTenantTransactions(results[1]);
            //  results = tenantTransaction.DeleteTenantTransaction(results[1].transactionID, results[1].LeadtenantID);
            //   foreach ( TenantTransaction result in results)
            //  {
            //     Console.WriteLine("Transaction ID:" + result.transactionID + " " + "Transaction Date: " + result.transactionDate+ " " + "Transaction Balance:" + result.currentBalance + " " +"Notes"+ result.notes.ToString());

            // }



            // MaintenanceRequest maintenanceRequest = new MaintenanceRequest(1,false,true, DateTime.Today,DateTime.Today,DateTime.Today,DateTime.Today,1,1," "," ");
            CreateHouse create = new CreateHouse();
            House house = new House(0);
            house.HouseNumber1 = "4617";
            house.StreetID1 = 4;
            house.LeadDisclosure1 = true;
            house.setFloorPlan("3-1426", 9);

            //Create Keys
            Keys keys = new Keys(0)
            {
                KeyNumberCurrent1 = "000000",
                KeyNumberCurrentDate1 = DateTime.Today,
                KeyNumberPrevious1 = "000000",
                KeyNumberPrevDate1 = DateTime.Today
            };
            house.Keys = keys;

            house.HouseAppliances = new HouseAppliances(0);
            house.HouseAppliances.Dishwasher1 = new Appliance(0);
            house.HouseAppliances.Dishwasher1.Type1 = 2;
            house.HouseAppliances.Range1 = new Appliance(0);
            house.HouseAppliances.Range1.Type1 = 1;

            house.HouseAppliances.LastGarbageDisposalReplacement1 = new DateTime(2008, 11, 1);
            house.HouseAppliances.HasRef1 = false;

            house.InterriorFeatures = new HouseInterriorFeatures(0);

            house.InterriorFeatures.WaterHeaterReplacementDate1 = new DateTime(2001, 03, 1);
            house.InterriorFeatures.CielingFanReplacementDate1 = new DateTime(2011, 09, 1);

            house.ExteriorFeatures = new HouseExteriorFeatures(0);
          

            Owner owner = new Owner(2);
            house.Owner = owner;
             
            house.HouseExterior = new HouseExterior(0);
            house.HouseExterior.SidingID1 = 1;
            house.HouseExterior.ExteriorColorID1 = 2;
            house.HouseExterior.ExteriorPaintDate1 = new DateTime(2011, 7, 1);
            house.HouseExterior.TrimID1 = 2;
            house.HouseExterior.RoofMaterialID1 = 1;
            house.HouseExterior.RoofColorID1 =  1;
            house.HouseExterior.RoofInstall1 = new DateTime(1997, 08, 01);



             house.HouseInterrior = new HouseInterrior(0);
            house.HouseInterrior.PrimaryPaintColorID1 = 1;
            house.HouseInterrior.LastPaintDate1 = new DateTime(2017, 12, 01);
            house.HouseInterrior.CarpetColorID1 = 1;
            house.HouseInterrior.CarpetInstallDate1 = new DateTime(2007, 11, 1);
            house.HouseInterrior.VynalColorID1 = 1;
            house.HouseInterrior.FermicaColorID1 =1;
            house.HouseInterrior.VandFInstall1 =new DateTime(2007,11,1);
            house.HouseInterrior.StainID1 = 7;
            house.HouseInterrior.Blindreplacement1=new DateTime(2011, 7, 1);

            house.LeadTenant = new LeadTenant(0,0);

            house.Keys.KeyNumberCurrent1 = "123456";

             create.CreateNewHouse(house).print();

            UpdateHouse update = new UpdateHouse();
            var results = update.generatUpdatedHouse(house);

            HouseSearch search = new HouseSearch();
          var updatedHouse = search.findAHouseByNumber(house.HouseNumber1);

            updatedHouse.print();

        }
    }
}
