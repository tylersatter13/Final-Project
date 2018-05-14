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
    public partial class CreateMaintenaceRequestScreen : Form
    {
        private Alert alert = new Alert();
        private House house;
        private LeadTenant leadTenant;
        private MaintenanceRequest maintenanceRequest;
        private ManageComboxLists comboxLists = new ManageComboxLists();
        private ValidationType validation = new ValidationType();
        public CreateMaintenaceRequestScreen(MaintenanceRequest request)
        {
           
            maintenanceRequest = request;
            house = maintenanceRequest.House;
            leadTenant = maintenanceRequest.House.LeadTenant;
            InitializeComponent();
        }
        private void CreateMaintenaceRequestScreen_Load(object sender, EventArgs e)
        {
            FillCombobox();
            if (maintenanceRequest.MaintenenceRequestID1 != 0)
            {
                SetSavedFields();
            }
            else { 
            SetBasicHouseInformation();
             }
          
        }
        private void SetSavedFields()
        {
            btnFinish.Text = "Update";
            var dateval = validation.getValidationDateTime();

            SetBasicHouseInformation();

            numCats.Value = maintenanceRequest.Cats1;
            numericUpDogs.Value = maintenanceRequest.Dogs1;
            checkPermissionToEnter.Checked = maintenanceRequest.PermissionToEnter1;
            checkAppliance.Checked = maintenanceRequest.IsAppliance1;

            if (checkAppliance.Checked == true)
            {
                if (maintenanceRequest.RequestTypeID1 == 1)
                {
                    radioRange.Checked = true;
                }
                else
                {
                    radioDishwasher.Checked = true;
                }
            }
            drpRequestType.SelectedIndex = maintenanceRequest.RequestTypeID1;
            drpTechnicians.SelectedIndex = maintenanceRequest.MaintenanceTechnician.MaintenanceTechnicianID1;

            textJobDescsription.Text = maintenanceRequest.Jobdescription.ToString();
            textWorkPreformed.Text = maintenanceRequest.WorkPerformed1.ToString();

            numJobHours.Value = maintenanceRequest.HoursWorked;
            if(dateval.fieldHasValue(maintenanceRequest.DateStarted1)== false)
            {
                dateJobStarted.Value = maintenanceRequest.DateStarted1;
                dateJobStart.Value = maintenanceRequest.DateStarted1;
            }
            if (dateval.fieldHasValue(maintenanceRequest.DateCreated1) == false)
            {
                dateJobStarted.Value = maintenanceRequest.DateCreated1;
            }
            if (dateval.fieldHasValue(maintenanceRequest.DateCompleted1) == false)
            {
                dateJobCompleted.Value = maintenanceRequest.DateCompleted1;
            }
            PopulateDatabase(maintenanceRequest.Parts);
        }
        private void SetBasicHouseInformation()
        {
            
            textTenantFirstName.Text =leadTenant.TenantFirst;
            textTenantLast.Text =leadTenant.TenantLast;
            textTennantPhone.Text =leadTenant.TenantPhone;
            textHouseNumber.Text = house.HouseNumber1;

            drpStreetName.SelectedIndex = house.StreetID1;

            numCats.Value = leadTenant.getNumberOfCats();
            numericUpDogs.Value = leadTenant.getNumberOfDogs();

            dateJobCreated.Checked = true;
            dateJobCreated.Value = DateTime.Today;
        }
        private void FillCombobox()
        {
            List<String> streetNames = comboxLists.GetStreet();
            AddListToBox(drpStreetName, streetNames);

            List<String> requesttypes = comboxLists.GetMaintenceRequestType();
            AddListToBox(drpRequestType, requesttypes);

            List<String> technicians = comboxLists.GetMaintenceTechnicans();
            AddListToBox(drpTechnicians, technicians);
        }
        private void AddListToBox(ComboBox comboBox, List<String> items)
        {
            comboBox.Items.Add("None"); //prototype only
            foreach (String item in items)
            {
                comboBox.Items.Add(item);
            }
        }
        private void PopulateDatabase(List<MaintenancePart> parts)
        {
          
            foreach (MaintenancePart part in parts)
            {
                AddPartToTable(part);
            }
        }
        private void AddPartToTable(MaintenancePart part)
        {
            dataRepairParts.Rows.Add(part.PartName1, part.InStock1,
                part.PartCost1, "Edit", "Delete");
            
        }
        private void checkAppliance_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAppliance.Checked == false)
            {
                radioRange.Enabled = false;
                radioDishwasher.Enabled = false;
            }
            else
            {
                radioRange.Enabled = true;
                radioDishwasher.Enabled = true;
            }
        }
        
        private void SetupRequest()
        {
            var dateVal = validation.getValidationDateTime();
            maintenanceRequest.DateCreated1 = dateVal.ConvertDatePickerDefault(dateJobCreated);
            maintenanceRequest.DateStarted1 = dateVal.ConvertDatePickerDefault(dateJobStart);
            maintenanceRequest.DateCreated1 = dateVal.ConvertDatePickerDefault(dateJobCompleted);

            maintenanceRequest.PermissionToEnter1 = checkPermissionToEnter.Checked;
            maintenanceRequest.IsAppliance1 = checkAppliance.Checked;

            if(maintenanceRequest.IsAppliance1== true)
            {
                PopulateDatabase(maintenanceRequest.Parts);
            }

            maintenanceRequest.Jobdescription.Clear();
            maintenanceRequest.Jobdescription.Append(textJobDescsription.Text);

            maintenanceRequest.WorkPerformed1.Clear();
            maintenanceRequest.WorkPerformed1.Append(textWorkPreformed.Text);

            if (maintenanceRequest.MaintenanceTechnician.MaintenanceTechnicianID1 < 0)
            {
                maintenanceRequest.MaintenanceTechnician.MaintenanceTechnicianID1 = drpTechnicians.SelectedIndex;
            }
            Console.WriteLine(maintenanceRequest.MaintenanceTechnician.MaintenanceTechnicianID1);
            maintenanceRequest.HoursWorked = (int)numJobHours.Value;

            maintenanceRequest.DateCompleted1 = dateVal.ConvertDatePickerDefault(dateJobCompleted);
            
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var val = validation.getValidationString();
            bool partaquired;
            if (radioCharge.Checked == true)
            {
                partaquired = false;
            }
            else
            {
                partaquired = true;
            }
            maintenanceRequest.Parts.Add( new MaintenancePart(0, textPartName.Text,(double) val.convertStringToDecimal(textPartCost.Text), partaquired));
            AddPartToTable(maintenanceRequest.Parts.Last());
        }

        private void dataRepairParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var column = e.ColumnIndex;
            var row = e.RowIndex;
            var cell = dataRepairParts.CurrentCell.Value;
            if (column == 3)
            {
                if (cell.ToString() == "Edit")
                {
                    Console.WriteLine("A");
                    Console.WriteLine(row);
                    dataRepairParts.CurrentCell.Value = "Done";
                    dataRepairParts.Rows[row].ReadOnly = false;
                }
                else if (cell.ToString() == "Done")
                {
                    Console.WriteLine("B");
                    dataRepairParts.CurrentCell.Value = "Edit";
                    dataRepairParts.Rows[row].ReadOnly = true;
                  
                }
            }
            else if (column == 4)
            {
                dataRepairParts.Rows.RemoveAt(row);
                maintenanceRequest.Parts[row].PartID1 = -1;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SetupRequest();
            Console.Write(maintenanceRequest.Jobdescription);
            if (maintenanceRequest.MaintenenceRequestID1 == 0)
            {
                Console.Write("Maintenace Request Created");
                CreateMaintenaceRequest createMaintenaceRequest = new CreateMaintenaceRequest();
                createMaintenaceRequest.CreateNewMaintenaceRequest(maintenanceRequest);

            }
            else
            {
                Console.Write("Maintenace Request Updated");
                UpdateMaintenaceRequest updateMaintenace = new UpdateMaintenaceRequest();
                updateMaintenace.MaintenaceRequestUpdate(maintenanceRequest);
            }
            MaintenaceRequestsSearchScreen searchScreen = new MaintenaceRequestsSearchScreen();
            Hide();
            searchScreen.ShowDialog();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           var descsion = alert.CreateChoiceAlert(4, "Unsaved Data", "If you exit you will loose any unsaved data");
           if(descsion == true)
            {
                MaintenaceRequestsSearchScreen searchScreen = new MaintenaceRequestsSearchScreen();
                Hide();
                searchScreen.ShowDialog();
            }

        }
    }
}
