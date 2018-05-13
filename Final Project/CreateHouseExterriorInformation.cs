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
    public partial class CreateHouseExterriorInformation : Form
    {
        private ManageComboxLists comboxLists = new ManageComboxLists();
        private Alert alert = new Alert();
        private ValidationType validation = new ValidationType();
        private House house;
        public CreateHouseExterriorInformation(House home)
        {
            house = home;
            Console.WriteLine(home.HouseID1);
            InitializeComponent();
        }
        public CreateHouseExterriorInformation()
        {
            InitializeComponent();
        }
        private void CreateHouseExterriorInformation_Load(object sender, EventArgs e)
        {
            FillComboxBox();
            if (house.HouseExterior == null) //If value have already filled in populate them
            {
                Console.WriteLine("Did return new house");
            }
            else
            {
                Console.WriteLine("Did return house exterrior");
                SetChosenFields();
            }
        }
        //get combox elements from the database and adds them to the list
        private void FillComboxBox() 
        {
            List<String> exteriorColors = comboxLists.GetExteriorColor();
            AddListToBox(drpExteriorColor, exteriorColors);

            List<String> trimcolors = comboxLists.GetTrimColor();
            AddListToBox(drpTrimColor, trimcolors);

            List<String> sidingtypes = comboxLists.GetSidingType();
            AddListToBox(drpSiding, sidingtypes);

            List<String> roofmaterials = comboxLists.GetRoofMaterial();
            AddListToBox(drpRoofMaterial, roofmaterials);

            List<String> roofcolors = comboxLists.GetRoofColor();
            AddListToBox(drpRoofColor, roofcolors);

        }

        private void AddListToBox(ComboBox combobox, List<String> items)
        {
            combobox.Items.Add("Add Item");
            foreach (String item in items)
            {
                combobox.Items.Add(item);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            setupHouse();
            var createBasicHouse = new CreateBasicHouseInformation(house);
            this.Hide();
            createBasicHouse.ShowDialog();
            
        }
        private void SetChosenFields()
        {
            var exterior = house.HouseExterior;
            var exteriorFeatures = house.ExteriorFeatures;
            var dateValidate = validation.getValidationDateTime();

            //Exterior Color
            drpExteriorColor.SelectedIndex = exterior.ExteriorColorID1;
            drpTrimColor.SelectedIndex = exterior.TrimID1;
            drpRoofMaterial.SelectedIndex = exterior.SidingID1;

            if (dateValidate.fieldHasValue(exterior.ExteriorPaintDate1)==false)
            {
                dateLastPaint.Value = exterior.ExteriorPaintDate1;
            }


            //Roof Color
            drpRoofColor.SelectedIndex = exterior.RoofColorID1;
            drpRoofMaterial.SelectedIndex = exterior.RoofMaterialID1;
            drpSiding.SelectedIndex = exterior.SidingID1;

            //Date Exterior
            if (dateValidate.fieldHasValue(exteriorFeatures.ChimneyReplacement1) == false)
            {
                dateChimney.Value = exteriorFeatures.ChimneyReplacement1;
            }
            if (dateValidate.fieldHasValue(exteriorFeatures.DrivewayReplacemnt1) == false)
            {
                dateDriveWay.Value = exteriorFeatures.DrivewayReplacemnt1;
            }
            if (dateValidate.fieldHasValue(exteriorFeatures.FenceReplacement1) == false)
            {
                dateFence.Value = exteriorFeatures.FenceReplacement1;
            }
            if (dateValidate.fieldHasValue(exteriorFeatures.GrageDoorReplacement1) == false)
            {
                dateGarageDoor.Value = exteriorFeatures.GrageDoorReplacement1;
            }
            if (dateValidate.fieldHasValue(exteriorFeatures.GutterReplacemengt1) == false)
            {
                dateGutter.Value = exteriorFeatures.GutterReplacemengt1;
            }
            

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            setupHouse();
            Appliances appliance = new Appliances(house);
            Hide();
            appliance.ShowDialog();

        }

        public void setupHouse()
        {
      
            var dateVal = validation.getValidationDateTime();
            if (house.HouseExterior == null)
            {
                house.HouseExterior= new HouseExterior(0);
                house.ExteriorFeatures = new HouseExteriorFeatures(0);
          
            }
            var exterior = house.HouseExterior;
            var exteriorFeatures = house.ExteriorFeatures;
            //Exterior Paint
            house.HouseExterior.ExteriorColorID1 = drpExteriorColor.SelectedIndex;
            exterior.TrimID1 = drpTrimColor.SelectedIndex;
            exterior.SidingID1 = drpSiding.SelectedIndex;
            exterior.ExteriorPaintDate1 = dateVal.ConvertDatePickerDefault(dateLastPaint);

            //Roof
            exterior.RoofColorID1 = drpRoofColor.SelectedIndex;
            exterior.RoofMaterialID1 = drpRoofMaterial.SelectedIndex;
            exterior.RoofInstall1 = dateVal.ConvertDatePickerDefault(dateRoofInstallDate);

            //Exterior Features
            exteriorFeatures.GrageDoorReplacement1 = dateVal.ConvertDatePickerDefault(dateGarageDoor);
            exteriorFeatures.GutterReplacemengt1 = dateVal.ConvertDatePickerDefault(dateGutter);
            exteriorFeatures.FenceReplacement1 = dateVal.ConvertDatePickerDefault(dateFence);
            exteriorFeatures.DrivewayReplacemnt1 = dateVal.ConvertDatePickerDefault(dateDriveWay);
            exteriorFeatures.ChimneyReplacement1 = dateVal.ConvertDatePickerDefault(dateChimney);

            Console.WriteLine(house.HouseExterior.ExteriorColorID1);
        }

    
    }
}
