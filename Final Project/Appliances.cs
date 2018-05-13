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
    public partial class Appliances : Form
    {
        private House house;
        private ValidationType validation = new ValidationType();
        public Appliances(House home)
        {
            house = home;
            InitializeComponent();
        }

        private void Appliances_Load(object sender, EventArgs e)
        {
            if (house.HouseAppliances != null)
            {
                SetValues();
            }
        }
        private void SetValues()
        {
            var dateVal = validation.getValidationDateTime();
            var interrior = house.InterriorFeatures;
            var appliances = house.HouseAppliances;

           if( dateVal.fieldHasValue(interrior.CielingFanReplacementDate1)==false){
                dateCeilingfan.Value = interrior.CielingFanReplacementDate1;
            }

            if (dateVal.fieldHasValue(interrior.FurnanceReplacementDate1) == false)
            {
                dateFurnace.Value = interrior.FurnanceReplacementDate1;
            }

            if (dateVal.fieldHasValue(interrior.HallShowerReplacementDate1) == false)
            {
                dateHallShower.Value = interrior.HallShowerReplacementDate1;
            }

            if (dateVal.fieldHasValue(interrior.WaterHeaterReplacementDate1) == false)
            {
                dateWaterHeater.Value = interrior.WaterHeaterReplacementDate1;
            }

            textDWBrand.Text = appliances.Dishwasher1.Brand1;
            textDWModel.Text = appliances.Dishwasher1.Model1;
            textDWSerial.Text = appliances.Dishwasher1.SerialNumber1;
            textDishwasherColor.Text = appliances.Dishwasher1.Color1;
            if (dateVal.fieldHasValue(appliances.Dishwasher1.LastReplacementDate1) == false)
            {
                dateDWPurchase.Value = appliances.Dishwasher1.LastReplacementDate1;
            }

            textModel.Text = appliances.Range1.Model1;
            textRangeBrand.Text = appliances.Range1.Brand1;
            txtRangeColor.Text = appliances.Range1.Color1;
            textSerialNumber.Text = appliances.Range1.SerialNumber1;
            if (dateVal.fieldHasValue(appliances.Range1.LastReplacementDate1) == false)
            {
                datePurchaseDate.Value = appliances.Range1.LastReplacementDate1;
            }

            if (dateVal.fieldHasValue(interrior.CielingFanReplacementDate1) == false)
            {
                dateGD.Value = appliances.LastGarbageDisposalReplacement1;
            }

            checkRefrigerator.Checked = appliances.HasRef1;
        }  
        private void SetupHouse()
        {
            var dateVal = validation.getValidationDateTime();
            
            if (house.InterriorFeatures == null)
            {
                house.InterriorFeatures = new HouseInterriorFeatures(0);
                house.HouseAppliances = new HouseAppliances(0);
                house.HouseAppliances.Range1 = new Appliance(0);
               house.HouseAppliances.Dishwasher1 = new Appliance(0);
            }
            var interrior = house.InterriorFeatures;
            var appliances = house.HouseAppliances;

            interrior.CielingFanReplacementDate1 = dateVal.ConvertDatePickerDefault(dateCeilingfan);
            interrior.FurnanceReplacementDate1 = dateVal.ConvertDatePickerDefault(dateFurnace);
            interrior.HallShowerReplacementDate1 = dateVal.ConvertDatePickerDefault(dateHallShower);
            interrior.WaterHeaterReplacementDate1 = dateVal.ConvertDatePickerDefault(dateWaterHeater);

            appliances.Dishwasher1.Brand1 = textDWBrand.Text;
            appliances.Dishwasher1.Color1 = textDishwasherColor.Text;
            appliances.Dishwasher1.Model1 = textDWModel.Text;
            appliances.Dishwasher1.SerialNumber1 = textDWSerial.Text;
            appliances.Dishwasher1.LastReplacementDate1 = dateVal.ConvertDatePickerDefault(dateDWPurchase);

            appliances.Range1.Brand1 = textRangeBrand.Text;
            appliances.Range1.Color1 = txtRangeColor.Text;
            appliances.Range1.SerialNumber1 = textSerialNumber.Text;
            appliances.Range1.Model1 = textDWModel.Text;
            appliances.Range1.LastReplacementDate1 = dateVal.ConvertDatePickerDefault(datePurchaseDate);

            appliances.LastGarbageDisposalReplacement1 = dateVal.ConvertDatePickerDefault(dateGD);
            appliances.HasRef1 = checkRefrigerator.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SetupHouse();
            CreateHouseExterriorInformation exterrior = new CreateHouseExterriorInformation(house);
            Hide();
            exterrior.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SetupHouse();
            TenantInfo tenantInfo = new TenantInfo(house);
            Hide();
            tenantInfo.ShowDialog();

        }
    }
}
 