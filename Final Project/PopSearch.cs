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
    public partial class PopSearch : Form
    {
        private Alert alert = new Alert();
        public PopSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CreateMaintenaceRequest create = new CreateMaintenaceRequest();
            MaintenanceRequest lastName = create.GenerateBasicMaintenceRequest(textLastName.Text);

            if (lastName.House.HouseID1 != 0)
            {
                CreateMaintenaceRequestScreen  createMaintenace= new CreateMaintenaceRequestScreen(lastName);
                Close();
                createMaintenace.Show();
            }
            else
            {
               //  alert.CreateBasicAlert(2, "No match found", "Invalid entry");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu maintenaceMenu = new Menu();
            Close();
          //  maintenaceMenu.Show();
        }
    }
}
