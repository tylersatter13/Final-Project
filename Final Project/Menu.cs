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
            searchHouses();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            Close();
           logout.Show();
        }
  
        private void tenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            TenantSearchScreen search = new TenantSearchScreen();
            loadChildForm(search);
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
        private void searchHouses()
        {
            PaintSearch search = new PaintSearch();
            loadChildForm(search);
        }
        private void loadChildForm(Form form) // creates a new child form of the selected type
        {
            form.MdiParent = this;
            if (this.ActiveMdiChild != null) // close previous child before opening a new one
            {
                this.ActiveMdiChild.Close();
            }
          
            sizeChildForm(form);
            form.Show();
        }
        private void sizeChildForm(Form form) // adjust the size of the child form to fit inside the parent
        {
          
            form.Top = 0;
            form.Left = 0;
            form.Dock = DockStyle.Fill;
            form.WindowState = FormWindowState.Maximized;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MaximizeBox = false;
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCreateHouse_Click(object sender, EventArgs e)
        {
            searchHouses();
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            //this.sizeChildForm(ActiveMdiChild);
        }

        private void Menu_AutoSizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("autosize changed");
            sizeChildForm(ActiveMdiChild);
        }

        private void Menu_ResizeEnd(object sender, EventArgs e)
        {
            Console.WriteLine("resize end");
            sizeChildForm(ActiveMdiChild);
        }

        private void maintenaceRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenaceRequestsSearchScreen searchScreen = new MaintenaceRequestsSearchScreen();
            loadChildForm(searchScreen);
        }
    }
}
