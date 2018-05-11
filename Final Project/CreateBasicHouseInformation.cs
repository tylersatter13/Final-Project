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
    public partial class CreateBasicHouseInformation : Form
    {
        private Alert alert = new Alert();
        private House house;
        private ValidationType validation = new ValidationType();
        public CreateBasicHouseInformation(House home)
        {
            
            house = home;
            InitializeComponent();
           
        }
        public CreateBasicHouseInformation()
        {
            InitializeComponent();
        }

        private void CreateBasicHouseInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyManagerDataSet.HouseInteriorColors' table. You can move, or remove it, as needed.
            this.houseInteriorColorsTableAdapter.Fill(this.propertyManagerDataSet.HouseInteriorColors);

            FillComboBox();

            if (house != null)
            {
                SetChosenFields();
            }
        }
        void FillComboBox()
        {
            ManageComboxLists fetchCombox = new ManageComboxLists();

            List<String> streetNames = fetchCombox.GetStreet();
            List<String> Owners = fetchCombox.GetOwners();
            List<String> SqFeetPlans = fetchCombox.GetSQPlans();
            List<String> Colors = fetchCombox.GetInterriorColors();
            List<String> VandFColors = fetchCombox.GetVandFColors();
            List<String> WWColors = fetchCombox.GetWoodWorkColors();
            List<String> CarpetColors = fetchCombox.GetCarpetColor();

            AddListToBox(drpOwner, Owners);
            AddListToBox(drpStreetName, streetNames);
            AddListToBox(drpSQPlan, SqFeetPlans);
            AddListToBox(drpPrimaryColor, Colors);
            AddListToBox(drpSecondaryColor, Colors);
            AddListToBox(drpVynl, VandFColors);
            AddListToBox(drpFermica, VandFColors);
            AddListToBox(drpWoodWork, WWColors);
            AddListToBox(drpCarpetColor, CarpetColors);

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            var dateVal = validation.getValidationDateTime();
            if (validateHouseNumber(textHouseNumber) == false)
            {

            }else if (dateVal.CheckComboBox(drpOwner,"Owner") == false)
            {

            }else if (dateVal.CheckComboBox(drpSQPlan,"Sqaure Feet") == false){

            }else if (dateVal.CheckComboBox(drpStreetName,"Streetname")== false)
            {
            }
            else
            {
                if (house == null)
                {
                    house = new House(0);
                    house.Owner = new Owner(0);
                    house.HouseInterrior = new HouseInterrior(0);
                }
                //Initialize Basic Information
                house.HouseNumber1 = textHouseNumber.Text;
                house.StreetID1 = drpStreetName.SelectedIndex;
                house.FloorPlanID1 = drpSQPlan.SelectedIndex;
                house.Owner.OwnerID1 = drpOwner.SelectedIndex;

                // Interrior Initaliazation
                //paint
                house.HouseInterrior.PrimaryPaintColorID1 = drpPrimaryColor.SelectedIndex;
                house.HouseInterrior.SecondaryPaintColorID1 = drpSecondaryColor.SelectedIndex;

                
                house.HouseInterrior.LastPaintDate1 = dateVal.ConvertDatePickerDefault(dateLastPaint);

                //carpet
                house.HouseInterrior.CarpetInstallDate1 = dateVal.ConvertDatePickerDefault(dateCarpetInstall);
                house.HouseInterrior.CarpetColorID1 =  drpCarpetColor.SelectedIndex;

                //Vyanal and Formica
                house.HouseInterrior.FermicaColorID1 = drpFermica.SelectedIndex;
                house.HouseInterrior.VynalColorID1 = drpVynl.SelectedIndex;
                house.HouseInterrior.VandFInstall1 = dateVal.ConvertDatePickerDefault(dateVF);

                //W.W Work
                house.HouseInterrior.StainID1 = drpWoodWork.SelectedIndex;

                //Blinds
                house.HouseInterrior.Blindreplacement1 = dateVal.ConvertDatePickerDefault(dateBlindReplacement);

                Console.WriteLine($"HouseNumber:{house.HouseNumber1}, $StreetID:{house.StreetID1}, SQ:{house.FloorPlanID1}, Owner:{house.Owner.OwnerID1}");
                Console.WriteLine($"Last Painted:{house.HouseInterrior.LastPaintDate1} Carpet Install:{house.HouseInterrior.CarpetInstallDate1} VandF Install:{house.HouseInterrior.VandFInstall1} Blind:{house.HouseInterrior.Blindreplacement1}");

                CreateHouseExterriorInformation exterriorInformation = new CreateHouseExterriorInformation(house);
                this.Hide();
                exterriorInformation.Show();
                
            }
        }
        private bool validateHouseNumber(TextBox textbox)
        {
            int houseNumber;
            var isNumeric = int.TryParse(textbox.Text, out houseNumber);
            if (isNumeric == false)
            {
                alert.CreateBasicAlert(3, "House number may only contain numerical values", "Invalid House Number");
                return false;
            }
            else if(textbox.Text.Length != 4)
            {
                alert.CreateBasicAlert(3, "House number must be 4 Digits", "Invalid House Number");
                return false;
            }
            else if(houseNumber <1000)
            {
                alert.CreateBasicAlert(3, "House number must be Greater then 1000", "Invalid House Number");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddListToBox(ComboBox combobox, List<String> items)
        {
            combobox.Items.Add("Add Item");
            foreach(String item in items)
            {
                combobox.Items.Add(item);
            }
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;

            if (combobox.SelectedIndex == 0)
            {
                Console.WriteLine("Add new item selected");
            }

        }
        private void SetChosenFields()
        {
            var datevalidation = validation.getValidationDateTime();
            var interrior = house.HouseInterrior;
            //basic house information
            textHouseNumber.Text = house.HouseNumber1;
            drpStreetName.SelectedIndex = house.StreetID1;
            drpSQPlan.SelectedIndex = house.FloorPlanID1;
            drpOwner.SelectedIndex = house.Owner.OwnerID1;

            //Paint Colors
            drpPrimaryColor.SelectedIndex = house.HouseInterrior.PrimaryPaintColorID1;
            drpSecondaryColor.SelectedIndex = house.HouseInterrior.SecondaryPaintColorID1;
            if(datevalidation.fieldHasValue(interrior.LastPaintDate1)== false)
            {
                dateLastPaint.Value = interrior.LastPaintDate1;
            }

            //Carpet
            drpCarpetColor.SelectedIndex = house.HouseInterrior.CarpetColorID1;
            if (datevalidation.fieldHasValue(interrior.CarpetInstallDate1) == false)
            {
                dateCarpetInstall.Value = house.HouseInterrior.CarpetInstallDate1;
            }

            //Vyanl and Fermica
            drpVynl.SelectedIndex = house.HouseInterrior.VynalColorID1;
            drpFermica.SelectedIndex = house.HouseInterrior.FermicaColorID1;
            if (datevalidation.fieldHasValue(interrior.VandFInstall1) == false)
            {
                dateVF.Value = house.HouseInterrior.CarpetInstallDate1;
            }

            drpWoodWork.SelectedIndex = house.HouseInterrior.StainID1; //Wood Work
            if(datevalidation.fieldHasValue(interrior.Blindreplacement1) == false){
                dateBlindReplacement.Value = house.HouseInterrior.Blindreplacement1;
            }// 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SetChosenFields();
        }
    }
}
