using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class CreateHouse
    {
        private Fetch fetch = new Fetch();
        public House CreateNewHouse(House house)
        {
            house.Keys.KeysID1 = CreateHouseKeys(house.Keys);
            house.HouseAppliances.Range1.ApplianceID1 = CreateAppliances(house.HouseAppliances.Range1);
            house.HouseAppliances.Dishwasher1.ApplianceID1 = CreateAppliances(house.HouseAppliances.Dishwasher1);
            house.HouseAppliances.HouseApplianceID1 = CreateHouseAppliances(house.HouseAppliances);
            house.InterriorFeatures.HouseInterriorFeaturesID1 = CreateInterrioFeatures(house.InterriorFeatures);
            house.ExteriorFeatures.ExteriorFeaturesID1 = CreateExterrioFeatures(house.ExteriorFeatures);
            house.HouseInterrior.HouseInteriorID1 = CreateInterrior(house.HouseInterrior);
            house.HouseExterior.HouseExteriorID1 = CreateExterrior(house.HouseExterior);
            return CreateFinishedHouse(house);


        }

        private int CreateHouseKeys(Keys key)
        {
            String spName = "spCreateKeys ";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@KeyNumberCurrent", key.KeyNumberCurrent1 );
            parameters.Add("@KeyNumberCurrentDate", key.KeyNumberCurrentDate1 );
            parameters.Add("@KeyNumberPrevious", key.KeyNumberPrevious1 );
            parameters.Add("@KeyNumberPrevDate", key.KeyNumberPrevDate1 );

            return fetch.fetchKeys(parameters, spName)[0].KeysID1;
        }
        private int CreateAppliances(Appliance appliance)
        {
            String spName = "spCreateAppliance";
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@fk_ApplianceTypeID", appliance.Type1 );
            parameters.Add("@ApplianceBrand", appliance.Brand1);
            parameters.Add("@ ApplianceModel", appliance.Model1);
            parameters.Add("@ ApplianceSerial", appliance.SerialNumber1);
            parameters.Add("@ ApplianceLastRepalcementDate", appliance.LastReplacementDate1);
            parameters.Add("@ApplianceColor", appliance.Color1);

           return fetch.fetchAppliances(parameters, spName)[0].ApplianceID1;
        }
        private int CreateHouseAppliances(HouseAppliances houseAppliances)
        {
            String spName = "spCreateHouseAppliances";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_Ranger ", houseAppliances.Range1.ApplianceID1);
            parameters.Add("@fk_Dishwasher ", houseAppliances.Dishwasher1.ApplianceID1);
            parameters.Add("@HouseApplianceWHDate ", houseAppliances.LastWaterHeaterReplacement1);
            parameters.Add("@HouseApplianceGDDate ", houseAppliances.LastGarbageDisposalReplacement1);
            parameters.Add("@HouseApplianceHasRefer", houseAppliances.HasRef1);

            return fetch.fetchHouseAppliances(parameters, spName)[0].HouseApplianceID1;
        }
        private int CreateInterrioFeatures(HouseInterriorFeatures interriorFeatures)
        {
            String spName = "SetInterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@InterriorFeaturesHallShowerDate ", interriorFeatures.HallShowerReplacementDate1);
            parameters.Add("@InterriorFeaturesWaterHeaterDate ", interriorFeatures.WaterHeaterReplacementDate1);
            parameters.Add("@InterriorFeaturesCelingFanDate ", interriorFeatures.CielingFanReplacementDate1);
            parameters.Add("@InterriorFeaturesFurnanceReplacement", interriorFeatures.FurnanceReplacementDate1);
            return fetch.fetchHouseInterriorFeatures(parameters, spName)[0].HouseInterriorFeaturesID1;
        }
        private int CreateExterrioFeatures(HouseExteriorFeatures exteriorFeatures )
        {
            String spName = "CreateExterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ExteriorFenece Date", exteriorFeatures.FenceReplacement1);
            parameters.Add("@ExteriorGutterReplacement Date", exteriorFeatures.GutterReplacemengt1);
            parameters.Add("@ExteriorGarageDoor Date", exteriorFeatures.GrageDoorReplacement1);
            parameters.Add("@ExteriorDriveWay Date", exteriorFeatures.DrivewayReplacemnt1);
            parameters.Add("@ExteriorChimney Date", exteriorFeatures.ChimneyReplacement1);

            return fetch.fetchHouseExteriorFeatures(parameters, spName)[0].ExteriorFeaturesID1;
        }
          private int CreateInterrior(HouseInterrior interrior)
        {
            String spName ="spCreateHouseInterrior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_PrimaryColorID", interrior.getPrimaryPaintColorID());
            parameters.Add("@fk_SecondaryColorID", interrior.getSecondaryPaintColorID());
            parameters.Add("@HouseLastPaintDate", interrior.getLastPaintDate());
            parameters.Add("@fk_CarpetColorID", interrior.getCarpetColorName() );
            parameters.Add("@HouseInteriorCarpetDate", interrior.getCarpetInstallDate());
            parameters.Add("@fk_FermicaColorID", interrior.getFermicaColorID());
            parameters.Add("@fk_VynlColorID", interrior.getVynalColorID());
            parameters.Add("@HouseInteriorVFInstall", interrior.getVandFInstallDate());
            parameters.Add("@fk_StainID", interrior.getStaindID());
            parameters.Add("@HouseBlindReplacement", interrior.getBlindReplaceMent());

            return fetch.fetchHouseInterrior(parameters, spName)[0].HouseInteriorID1;
        }
        private int CreateExterrior(HouseExterior exterior)
        {
            String spName = "spCreateHouseExterior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_SidingID", exterior.SidingID1);
            parameters.Add("@fk_ExteriorColorID",exterior.ExteriorColorID1);
            parameters.Add("@HouseExteriorPaintDate", exterior.ExteriorPaintDate1);
            parameters.Add("@fk_TrimID", exterior.TrimID1);
            parameters.Add("@fk_RoofMaterialID", exterior.RoofMaterialID1);
            parameters.Add("@fk_RoofColorID", exterior.RoofColorID1);
            parameters.Add("@HousseExteriorRoofInstall",exterior.RoofInstall1);

            return fetch.HouseExteriors(parameters, spName)[0].ExteriorColorID1;
        }
        private House CreateFinishedHouse(House house)
        {
            String spName = "spCreateHouse";
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@HouseNumber", house.HouseNumber1);
            parameters.Add("@fk_Street",house.StreetID1);
            parameters.Add("@fk_Owner", house.Owner);
            parameters.Add("@fk_LeadTenant", house.LeadTenant.LeadTenantID1);
            parameters.Add("@fk_SQPlan", house.FloorPlanID1);
            parameters.Add("@fk_HouseInterriorID", house.HouseInterrior.HouseInteriorID1);
            parameters.Add("@fk_HouseExteriorID ", house.HouseExterior.HouseExteriorID1);
            parameters.Add("@fk_KeyNunberID", house.Keys.KeysID1);
            parameters.Add("@fk_interriorFeaturesID  ", house.InterriorFeatures.HouseInterriorFeaturesID1);
            parameters.Add("@fk_ExterriorFeaturesID  ", house.HouseExterior.HouseExteriorID1);
            parameters.Add("@HouseDidDiscloseLea", house.LeadDisclosure1);
            parameters.Add("@fk_HouseAppliancesID  ", house.HouseAppliances);
            parameters.Add("@HouseMiscellaneous", house.Miscellaneous1);

           return fetch.fetchHouseInformation(parameters, spName)[0];

        }
    }
}
