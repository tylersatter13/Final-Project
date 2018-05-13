using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TenantInfo : Form
    {
        private House house;
        private ValidationType validation = new ValidationType();
        public TenantInfo(House home)
        {
            house = home;
            InitializeComponent();
        }

        private void TenantInfo_Load(object sender, EventArgs e)
        {
          
            if (house.LeadTenant != null)
            {
                setupFields();
                if (house.LeadTenant.LeadTenantID1 >= 0)
                {
                    loadTenantTable();
                }
            }
        }

        private void setupFields()
        {
            textLeadTenantFirst.Text = house.LeadTenant.TenantLast;
            textLeadTenantLast.Text = house.LeadTenant.TenantLast;
            textTenantPhone.Text = house.LeadTenant.TenantPhone;
            numChildren.Value = house.LeadTenant.Children;
            numRent.Text = house.LeadTenant.RentAmount.ToString();

            if (validation.getValidationDateTime().fieldHasValue(house.LeadTenant.RentDate)== false)
            {
                dateRentStart.Value = house.LeadTenant.RentDate;
            }   
        }

        private void houseSetup()
        {
            if (house.LeadTenant == null)
            {
                house.LeadTenant= new LeadTenant(0,0);
            }

            house.LeadTenant.TenantFirst = textLeadTenantFirst.Text;
            house.LeadTenant.TenantLast = textLeadTenantLast.Text;
            house.LeadTenant.TenantPhone = textTenantPhone.Text;
            house.LeadTenant.Children =(int)numChildren.Value;
            if (validation.getValidationInt().checkInt(numRent.Text,"Rent")==true)
            {
                house.LeadTenant.RentAmount = Decimal.Parse(numRent.Text);
            }
            house.LeadTenant.RentDate = validation.getValidationDateTime().ConvertDatePickerDefault(dateRentStart);

           
        }
        private void loadTenantTable()
        {
            foreach (Tenant tenant in house.Tenants1)
            {
                addToDataGrid(tenant);
            }
        }
        private void addToDataGrid(Tenant tenant)
        {
            Console.WriteLine(tenant.TenantPhone);
            dataTenants.Rows.Add(tenant.TenantFirst, tenant.TenantLast, tenant.TenantPhone,"Edit","Delete");
            var count = dataTenants.RowCount - 1;
            dataTenants.Rows[count].ReadOnly = true;
        }
        private void btnAddTenant_Click(object sender, EventArgs e)
        {
           Console.WriteLine(textTenantPhone.Text);
           house.Tenants1.Add(new Tenant(0, textTenantFirst.Text,textTenantLast.Text,textTenantPhone.Text.ToString()));
            var entry = house.Tenants1.Count-1;
            addToDataGrid(house.Tenants1[entry]);
            clearAddTenantFields();
        }

        private void clearAddTenantFields()
        {
            textTenantFirst.Text = "";
            textTenantLast.Text = "";
            textTenantPhone.Text = "";
        }
        private void dataTenants_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var count = dataTenants.RowCount - 2;
            dataTenants.Rows[count].ReadOnly = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            houseSetup();
            FinalizeHouse finalizeHouse = new FinalizeHouse(house);
            Hide();
            finalizeHouse.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            houseSetup();
            Appliances appliances = new Appliances(house);
            Hide();
            appliances.ShowDialog();
        }

        private void dataTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = e.ColumnIndex;
            var row = e.RowIndex;
            var cell = dataTenants.CurrentCell.Value;
            if (column == 3)
            {
                if (cell.ToString() == "Edit")
                {
                    Console.WriteLine(row);
                    dataTenants.CurrentCell.Value = "Done";
                    dataTenants.Rows[row].ReadOnly = false;
                }
                else if (cell.ToString() == "Done")
                {
                    dataTenants.CurrentCell.Value = "Edit";
                    dataTenants.Rows[row].ReadOnly = true;
                   Console.WriteLine( house.Tenants1[row].TenantLast);
                }
            }
            else if (column == 4) {
                dataTenants.Rows.RemoveAt(row);

            }

        }
    }
}
