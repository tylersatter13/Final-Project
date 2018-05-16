using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class UpdateHouse
    {
        private Fetch fetch = new Fetch();
        private ValidationType validation = new ValidationType();
        private CreateHouse createHouse = new CreateHouse();
        public House generatUpdatedHouse(House house)
        {
            var houseappliance = house.HouseAppliances;
            var range = houseappliance.Range1;
            var dishwasher = houseappliance.Dishwasher1;
            var interriorfeature = house.InterriorFeatures;
            var exterriorfeature = house.ExteriorFeatures;
            var interrior = house.HouseInterrior;
            var exterrior = house.HouseExterior;

            UpdateHouseKeys(house.HouseID1, house.Keys);
            UpdateAppliances(range.ApplianceID1, range);
            UpdateAppliances(dishwasher.ApplianceID1, dishwasher);
            UpdateHouseAppliances(houseappliance.HouseApplianceID1, houseappliance);
            UpdateInterrioFeatures(interriorfeature.HouseInterriorFeaturesID1, interriorfeature);
            UpdateExterrioFeatures(exterriorfeature.ExteriorFeaturesID1, exterriorfeature);
            UpdateInterrior(interrior.HouseInteriorID1, interrior);
            UpdateExterrior(exterrior.ExteriorColorID1, exterrior);
            updateLeadTenant(house.LeadTenant);

            checkTenants(house.Tenants1, house.HouseID1);
            checkPets(house.LeadTenant.Pets, house.LeadTenant.LeadTenantID1);
            return house;
        }
        private void checkTenants(List<Tenant> tenants, int HouseID)
        {
            foreach (Tenant tenant in tenants)
            {
                updateTenant(tenant, HouseID);
            }
        }
        private void updateLeadTenant(LeadTenant tenant)
        {
            String spName = "spUpdateLeadTenant";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LeadTenantID",tenant.LeadTenantID1);
            parameters.Add("@fk_TennantID",tenant.TenantId);
            parameters.Add("@LeadPetFeePaid",null);
            parameters.Add("@LeadTenantRentStart ", tenant.RentDate);
            parameters.Add("@Children",tenant.Children);
            parameters.Add("@LeadTenantRentAmount",tenant.RentAmount);
            parameters.Add("@LeadTenantBalance",tenant.Balance);
            parameters.Add("@fk_TenatFlag",tenant.TenantFlag);

            fetch.fetchLeadTenants(parameters, spName);
        }
        private void updateTenant(Tenant tenant, int HouseID)
        {
            if (tenant.TenantId == 0)
            {
                CreateHouse createHouse = new CreateHouse();
                createHouse.CreateHouseTenant(tenant, HouseID);
            }
            else if (tenant.TenantId == -1)
            {
                //Add delete function
            }
            else
            {
                UpdateHouseTenant(tenant);
            }

        }
        public void checkPets(List<Pet> Pets, int LeadTenantID)
        {
            foreach (Pet pet in Pets)
            {
                updatePet(pet, LeadTenantID);
            }
        }
        private void updatePet(Pet pet, int LeadTenantID)
        {
           if(pet.PetID == 0)
            {
                createHouse.CreateHousePet(pet, LeadTenantID);
            }else if(pet.PetID == -1){
                //add delete function
            }
            else
            {
                //add update function
            }
        }
        private void UpdateHouseTenant(Tenant tenant)
        {
            String spName = "spUpdateTenant";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TenantID", tenant.TenantId);
            parameters.Add("@TenantFirst", tenant.TenantFirst);
            parameters.Add("@TenantLast", tenant.TenantLast);
            parameters.Add("@TenantPhone", tenant.TenantPhone);

            fetch.fetchHouseTenants(parameters, spName);
        }
        private void UpdateHouseKeys(int HouseID, Keys key)
        {
            String spName = "spUpdateKeys";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@KeyNumberID", key.KeysID1);
            parameters.Add("@KeyNumberCurrent", key.KeyNumberCurrent1);
            parameters.Add("@KeyNumberCurrentDate", validation.getValidationDateTime().checkNullDate((key.KeyNumberCurrentDate1)));
            parameters.Add("@KeyNumberPrevious", key.KeyNumberPrevious1);
            parameters.Add("@KeyNumberPrevDate", validation.getValidationDateTime().checkNullDate(key.KeyNumberPrevDate1));

            fetch.fetchKeys(parameters, spName);
        }
        private void UpdateAppliances(int AppliaceID, Appliance appliance)
        {
            String spName = "spUpdateAppliance";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ApplianceID", appliance.ApplianceID1);
            parameters.Add("@fk_ApplianceTypeID", appliance.Type1);
            parameters.Add("@ApplianceBrand", appliance.Brand1);
            parameters.Add("@ApplianceModel", appliance.Model1);
            parameters.Add("@ApplianceSerial", appliance.SerialNumber1);
            parameters.Add("@ApplianceLastRepalcementDate", validation.getValidationDateTime().checkNullDate((appliance.LastReplacementDate1)) ?? null);
            parameters.Add("@ApplianceColor", appliance.Color1);

            var results = fetch.fetchAppliances(parameters, spName); 
            //return results;

        }
        private void UpdateHouseAppliances(int HouseApplianceID, HouseAppliances houseAppliances)
        {
            String spName = "spUpdateHouseAppliances";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseApplianceID", houseAppliances.HouseApplianceID1);
            parameters.Add("@fk_Ranger", validation.getValidationInt().CheckNullForeignKey(houseAppliances.Range1.ApplianceID1));
            parameters.Add("@fk_Dishwasher", validation.getValidationInt().CheckNullForeignKey(houseAppliances.Dishwasher1.ApplianceID1));
            parameters.Add("@HouseApplianceGDDate", validation.getValidationDateTime().checkNullDate((houseAppliances.LastGarbageDisposalReplacement1)) ?? null);
            parameters.Add("@HouseApplianceHasRefer", houseAppliances.HasRef1);


            var results = fetch.fetchHouseAppliances(parameters, spName);
            // return results[0].HouseApplianceID1;
        }
        private void UpdateInterrioFeatures(int InterriorFeaturesID, HouseInterriorFeatures interriorFeatures)
        {
            String spName = "spUpdateInterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@InteriorFeaturesID", interriorFeatures.HouseInterriorFeaturesID1);
            parameters.Add("@InterriorFeaturesHallShowerDate ", validation.getValidationDateTime().checkNullDate((interriorFeatures.HallShowerReplacementDate1)));
            parameters.Add("@InterriorFeaturesWaterHeaterDate ", validation.getValidationDateTime().checkNullDate((interriorFeatures.WaterHeaterReplacementDate1)));
            parameters.Add("@InterriorFeaturesCelingFanDate ", validation.getValidationDateTime().checkNullDate((interriorFeatures.CielingFanReplacementDate1)));
            parameters.Add("@InterriorFeaturesFurnanceReplacement", validation.getValidationDateTime().checkNullDate((interriorFeatures.FurnanceReplacementDate1)));
            var results = fetch.fetchHouseInterriorFeatures(parameters, spName);
        }
        private void UpdateExterrioFeatures(int ExterriorFeaturesID, HouseExteriorFeatures exteriorFeatures)
        {
            String spName = "spUpdateExterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ExteriorFeaturesID", exteriorFeatures.ExteriorFeaturesID1);
            parameters.Add("@ExteriorFenece", validation.getValidationDateTime().checkNullDate((exteriorFeatures.FenceReplacement1)));
            parameters.Add("@ExteriorGutterReplacement", validation.getValidationDateTime().checkNullDate((exteriorFeatures.GutterReplacemengt1)));
            parameters.Add("@ExteriorGarageDoor", validation.getValidationDateTime().checkNullDate((exteriorFeatures.GrageDoorReplacement1)));
            parameters.Add("@ExteriorDriveWay", validation.getValidationDateTime().checkNullDate((exteriorFeatures.DrivewayReplacemnt1)));
            parameters.Add("@ExteriorChimney", validation.getValidationDateTime().checkNullDate((exteriorFeatures.ChimneyReplacement1)));

            fetch.fetchHouseExteriorFeatures(parameters, spName);
        }
        private void UpdateInterrior(int InterriorID, HouseInterrior interrior)
        {
            String spName = "spUpdateHouseInterior";
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@HouseInteriorID", interrior.HouseInteriorID1);
            parameters.Add("@fk_PrimaryColorID", interrior.PrimaryPaintColorID1);
            parameters.Add("@fk_SecondaryColorID", validation.getValidationInt().CheckNullForeignKey(interrior.SecondaryPaintColorID1));
            parameters.Add("@HouseLastPaintDate", validation.getValidationDateTime().checkNullDate((interrior.LastPaintDate1)));
            parameters.Add("@fk_CarpetColorID", validation.getValidationInt().CheckNullForeignKey(interrior.CarpetColorID1));
            parameters.Add("@HouseInteriorCarpetDate", validation.getValidationDateTime().checkNullDate((interrior.CarpetInstallDate1)));
            parameters.Add("@fk_FermicaColorID", validation.getValidationInt().CheckNullForeignKey(interrior.FermicaColorID1));
            parameters.Add("@fk_VynlColorID", validation.getValidationInt().CheckNullForeignKey(interrior.VynalColorID1));
            parameters.Add("@HouseInteriorVFInstall", validation.getValidationDateTime().checkNullDate(interrior.VandFInstall1));
            parameters.Add("@fk_StainID", validation.getValidationInt().CheckNullForeignKey(interrior.StainID1));
            parameters.Add("@HouseBlindReplacement", validation.getValidationDateTime().checkNullDate(interrior.Blindreplacement1));

            var results = fetch.fetchHouseInterrior(parameters, spName);
        }
        private void UpdateExterrior(int exterriorID, HouseExterior exterior)
        {
            String spName = "spUpdateHouseExterrior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseExteriorID ", exterior.HouseExteriorID1);
            parameters.Add("@fk_SidingID", validation.getValidationInt().CheckNullForeignKey(exterior.SidingID1));
            parameters.Add("@fk_ExteriorColorID", validation.getValidationInt().CheckNullForeignKey(exterior.ExteriorColorID1));
            parameters.Add("@HouseExteriorPaintDate", validation.getValidationDateTime().checkNullDate(exterior.ExteriorPaintDate1));
            parameters.Add("@fk_TrimID", validation.getValidationInt().CheckNullForeignKey(exterior.TrimID1));
            parameters.Add("@fk_RoofMaterialID", validation.getValidationInt().CheckNullForeignKey(exterior.RoofMaterialID1));
            parameters.Add("@fk_RoofColorID", validation.getValidationInt().CheckNullForeignKey(exterior.RoofColorID1));
            parameters.Add("@HouseExteriorRoofInstall", validation.getValidationDateTime().checkNullDate(exterior.RoofInstall1));

            fetch.HouseExteriors(parameters, spName);
        }
        /*  private House UpdateFinishedHouse(House house)
          {
              String spName = "spCreateHouse";
              DynamicParameters parameters = new DynamicParameters();

              parameters.Add("@HouseNumber", house.HouseNumber1);
              parameters.Add("@fk_Street", house.StreetID1);
              parameters.Add("@fk_Owner", house.Owner.OwnerID1);
              parameters.Add("@fk_LeadTenant", validation.getValidationInt().CheckNullForeignKey(house.LeadTenant.LeadTenantID1));
              parameters.Add("@fk_SQPlan", house.FloorPlanID1);
              parameters.Add("@fk_HouseInterriorID", house.HouseInterrior.HouseInteriorID1);
              parameters.Add("@fk_HouseExteriorID ", house.HouseExterior.HouseExteriorID1);
              parameters.Add("@fk_KeyNunberID", validation.getValidationInt().CheckNullForeignKey(house.Keys.KeysID1));
              parameters.Add("@fk_interriorFeaturesID  ", house.InterriorFeatures.HouseInterriorFeaturesID1);
              parameters.Add("@fk_ExterriorFeaturesID  ", house.HouseExterior.HouseExteriorID1);
              parameters.Add("@HouseDidDiscloseLea", house.LeadDisclosure1);
              parameters.Add("@fk_HouseAppliancesID  ", house.HouseAppliances.HouseApplianceID1);
              parameters.Add("@HouseMiscellaneous", house.Miscellaneous1);

              return fetch.fetchHouseInformation(parameters, spName)[0];

          }*/
    }
}



