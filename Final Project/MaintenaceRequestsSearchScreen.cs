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
    public partial class MaintenaceRequestsSearchScreen : Form
    {
        private Alert alert = new Alert();
        private SearchMaintenanceRequests search = new SearchMaintenanceRequests();
        private House house;
        private MaintenanceRequest maintenanceRequest;
        private List<MaintenanceRequest> requestlist = new List<MaintenanceRequest>();
        private ManageComboxLists comboxLists = new ManageComboxLists();
        ValidationType validation = new ValidationType();
        public MaintenaceRequestsSearchScreen()
        {
            InitializeComponent();
            updateRadioBtn();
        }
        private void MaintenaceRequestsSearchScreen_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }
        private void FillCombobox()
        {
            List<String> requestType = comboxLists.GetMaintenceRequestType();
            AddListToBox(drpRequestType, requestType);
        }
        private void AddListToBox(ComboBox combobox, List<String> items)
        {
          
            combobox.Items.Add("Add Item");
            foreach (String item in items)
            {
                combobox.Items.Add(item);
            }
        }
        private void PopulateDatabase(List<MaintenanceRequest> requests)
        {
            requestlist.Clear();
            var dateVal = validation.getValidationDateTime();
            foreach (MaintenanceRequest request in requests)
            {
                if (checkOpenRequests.Checked == true)
                {
                    
                    if(dateVal.fieldHasValue(request.DateCompleted1) == true)
                    {
                        AddRequestsToTable(request);
                        requestlist.Add(request);
                    }
                }
                else
                {
                    AddRequestsToTable(request);
                    requestlist.Add(request);
                }          
            }
        }
        private void AddRequestsToTable(MaintenanceRequest request)
        {
            //obtaines the Request Type Value
            drpRequestType.SelectedIndex = request.RequestTypeID1;
            var requestType = drpRequestType.SelectedItem;
            drpRequestType.SelectedIndex = -1;
          
            dataHouse.Rows.Add(false,
                request.House.HouseNumber1 + " " + request.House.Streetname1,
                request.House.LeadTenant.TenantLast,
                request.House.LeadTenant.TenantPhone, requestType,
                ConvertDateFormat(request.DateCreated1),
                ConvertDateFormat(request.DateStarted1),
                ConvertDateFormat(request.DateCompleted1),
                request.Jobdescription, request.MaintenanceTechnician.FirstName1
            );
        }
        private void updateRadioBtn()
        {
            if (radioHouse.Checked == true)
            {
                textHouseNumber.Enabled = true;

                textLastName.Enabled = false;
                textLastName.Text = "";
                drpRequestType.Enabled = false;
                drpRequestType.SelectedIndex = -1;
            }else if (radioLastName.Checked == true)
            {
                textLastName.Enabled = true;

                drpRequestType.Enabled = false;
                drpRequestType.SelectedIndex = -1;

                textHouseNumber.Enabled = false;
                textHouseNumber.Text = "";
            }
            else if(radioRequestType.Checked == true)
            {
                drpRequestType.Enabled = true;

                textHouseNumber.Enabled = false;
                textHouseNumber.Text = "";

                textLastName.Enabled = false;
                textLastName.Text = "";
            }
        }
        private void ClearInputs()
        {
            drpRequestType.SelectedIndex = -1;
            textHouseNumber.SelectedText = "";
            textLastName.SelectedText = "";
            checkOpenRequests.Checked = false;
        }
        private String ConvertDateFormat(DateTime date)
        {
            if (validation.getValidationDateTime().fieldHasValue(date) == false)
            {
                return date.ToString("MM/dd/yyyy");
            }
            else
            {
                return "N/A";
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataHouse.Rows.Clear();
            dataHouse.Refresh();
            if (textHouseNumber.Text != "")
            {
                if (validation.getValidationInt().validateHouseNumber(textHouseNumber) == true)
                {
                    List<MaintenanceRequest> requests = search.searchByHouseNumber(textHouseNumber.Text);
                    PopulateDatabase(requests);
                }
            }
            else if (textLastName.Text != "")
            {
                    List<MaintenanceRequest> requests = search.searchByLastName(textLastName.Text.ToString());
                PopulateDatabase(requests);
            }
               else if(drpRequestType.SelectedIndex > 0)
            {
                Console.WriteLine($"Repair Type{drpRequestType.SelectedIndex}");
                List<MaintenanceRequest> requests = search.searchForRequestsByType(drpRequestType.SelectedIndex);
                PopulateDatabase(requests);     
            }
            else
            {
                alert.CreateBasicAlert(4, "Search Critera could not be used","Invalid Entry");
            }
            
        }

        private void radioHouse_CheckedChanged(object sender, EventArgs e)
        {
            updateRadioBtn();
        }

        private void dataHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            CreateMaintenaceRequestScreen requestScreen = new CreateMaintenaceRequestScreen(requestlist[row]);
            Hide();
            requestScreen.Show();
        }
    }
}
