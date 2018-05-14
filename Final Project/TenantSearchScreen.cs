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
    public partial class TenantSearchScreen : Form
    {
        HouseSearch search = new HouseSearch();
        private ValidationType validation = new  ValidationType();
        private List<House> LeadTenants = new List<House>();
        private DataFormat format = new DataFormat();
        public TenantSearchScreen()
        {
            InitializeComponent();
        }

        private void PopulateDatabase(List<House> tenants)
        {

            foreach (House tenant in tenants)
            {
                AddTenantToTable(tenant);
                
            }
        }
        private void AddTenantToTable(House tenant)
        {
            var leadTenant = tenant.LeadTenant;
            var FullName = leadTenant.TenantFirst + " " + leadTenant.TenantLast;
            var Address = tenant.HouseNumber1 + " " + tenant.Streetname1;
            var people = tenant.getTenants();
            var rent = format.formatCurrency(leadTenant.RentAmount);
            var startDate = leadTenant.RentDate.ToShortDateString();
            var pets = leadTenant.getNumberOfPets();
            var phone = leadTenant.TenantPhone;
            var Owner = tenant.Owner.OwnerInitals1;
            var FloorPlan = tenant.FloorPlan1;
            var Balance =  format.formatCurrency(leadTenant.Balance);
            LeadTenants.Add(tenant);
            dataTenant.Rows.Add(false,Owner, FloorPlan, Address, FullName,
                phone, rent, startDate, Balance, people, pets);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataTenant.Rows.Clear();
            dataTenant.Refresh();

            
            House house = search.findAHouseByLastName(textLastName.Text);
            AddTenantToTable(house);

          
            
        }

        private void btnSearchLatePayments_Click(object sender, EventArgs e)
        {
            List<House> houses = search.findHouses();
            var results = houses.Where(house => (house.LeadTenant.Balance <= 0)).ToList();
            PopulateDatabase(results);
        }

        private void dataTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            TransactionManager manager = new TransactionManager();
            LeadTenants[row].LeadTenant.Transactions = manager.GetTenantTransactions(LeadTenants[row].LeadTenant.TenantLast);
            TenantPaymentManger paymentmanager = new TenantPaymentManger(LeadTenants[row]);
            Hide();
            paymentmanager.Show();


        }
    }
}
