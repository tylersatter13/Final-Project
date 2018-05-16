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
    public partial class Menu : Form
    {
      
        public Menu()
        {
            this.IsMdiContainer= true;
            InitializeComponent();
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTenants_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMaintenace_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            Close();
           logout.Show();
        }

        private void houseSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PaintSearch search = new PaintSearch();
            search.MdiParent = this;
            search.Show();
        }

        private void createHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBasicHouseInformation house = new CreateBasicHouseInformation();
            Close();
            house.StartPosition = FormStartPosition.Manual;
            house.SetDesktopLocation(this.Location.X, this.Location.X);
            house.Show();
        }

        private void btntenantSearch_Click(object sender, EventArgs e)
        {
            
            TenantSearchScreen searchscreen = new TenantSearchScreen();
            //Close();
            searchscreen.MdiParent = this;
           // searchscreen.Dock = DockStyle.Fill;
            searchscreen.Show();

        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            PopSearch search = new PopSearch();
            search.MdiParent = this;
          //  Close();
            search.Show();
        }

        private void btnSearchMaintenace_Click(object sender, EventArgs e)
        {
            MaintenaceRequestsSearchScreen searchScreen = new MaintenaceRequestsSearchScreen();
            searchScreen.MdiParent = this;
            // searchScreen.Dock = DockStyle.Fill;
            //   Close();
            
            searchScreen.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
