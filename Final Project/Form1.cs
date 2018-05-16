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
        private Login login = new Login();
        private Alert alert = new Alert();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Singleton.Instance.UserIsSet == true)
            {
                Singleton.Instance.Logout(); //clears out user information
            }
          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login.validateUser(txtUserName.Text, txtPassword.Text))
            {

                // Menu mainMenu = new Menu() ;
                // mainMenu.Show();
                // CreateBasicHouseInformation createBasicHouse = new CreateBasicHouseInformation();
                // createBasicHouse.Show(); 
                //   CreateMaintenaceRequest request = new CreateMaintenaceRequest();
                //SearchMaintenanceRequests rsearch = new SearchMaintenanceRequests();

                // MaintenanceRequest result = rsearch.searchByLastName("Arnold");
                //    HouseSearch search = new HouseSearch();
                //   var house = search.findAHouseByLastName("Arnold");
                //  Console.WriteLine("Did return Maintenace Request");
                //   Console.WriteLine(result.House.LeadTenant.TenantLast);
                //   Console.WriteLine(result.House.LeadTenant.TenantFirst);
                //   Console.WriteLine(result.House.LeadTenant.TenantPhone);

                //  var requests = request.GenerateBasicMaintenceRequest(house.LeadTenant.TenantLast);
                ///  Close();
                // create.Show();
                Menu mainMenu = new Menu();
                Hide();
                mainMenu.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
