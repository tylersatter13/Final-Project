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
        //private Validation<DateTime> validation = new Validation<DateTime>();
        private ValidationType validation = new ValidationType();
        public House CreateNewHouse(House house)
        {
            TenantManager manager = new TenantManager();
            house.Keys.KeysID1 = CreateHouseKeys(house.Keys);
            house.HouseAppliances.Range1.ApplianceID1 = CreateAppliances(house.HouseAppliances.Range1);
            house.HouseAppliances.Dishwasher1.ApplianceID1 = CreateAppliances(house.HouseAppliances.Dishwasher1);
            house.HouseAppliances.HouseApplianceID1 = CreateHouseAppliances(house.HouseAppliances);
            house.InterriorFeatures.HouseInterriorFeaturesID1 = CreateInterrioFeatures(house.InterriorFeatures);
            house.ExteriorFeatures.ExteriorFeaturesID1 = CreateExterrioFeatures(house.ExteriorFeatures);
            house.HouseInterrior.HouseInteriorID1 = CreateInterrior(house.HouseInterrior);
            house.HouseExterior.HouseExteriorID1 = CreateExterrior(house.HouseExterior);
            house.LeadTenant = manager.addLeadTenant(house.LeadTenant);
            var results = CreateFinishedHouse(house);

            foreach (Tenant tenant in results.Tenants1)
            {
                CreateHouseTenant(tenant, results.HouseID1);
            }
            foreach (Pet pet in house.LeadTenant.Pets)
            {
                CreateHousePet(pet, results.LeadTenant.LeadTenantID1);
            }

            return house;


        }
        public Tenant CreateHouseTenant(Tenant tenant, int HouseID)
        {
            String spName = "spCreateHouseTenant";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TenantFirst", tenant.TenantFirst);
            parameters.Add("@TenantLast", tenant.TenantLast);
            parameters.Add("@TenantPhone", tenant.TenantPhone);
            parameters.Add("@HouseID", HouseID);
            fetch.fetchHouseTenants(parameters, spName);
            return tenant;
        }
        public Pet CreateHousePet(Pet pet, int LeadTenantID)
        {
            String spName = "spCreatePet";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_PetTypeID", pet.PetTypeID);
            parameters.Add("@PetBreed", pet.petBreed);
            parameters.Add("@PetRent", pet.petRent);
            parameters.Add("@PetFee", pet.petFee);
            parameters.Add("@PetFeePaid", pet.petFeePaid);
            parameters.Add("@LeadTenantID", LeadTenantID);

            fetch.fetchPets(parameters, spName);
            return pet;
        }
        private int CreateHouseKeys(Keys key)
        {
            String spName = "spCreateKeys ";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@KeyNumberCurrent", key.KeyNumberCurrent1);
            parameters.Add("@KeyNumberCurrentDate", validation.getValidationDateTime().checkNullDate((key.KeyNumberCurrentDate1)));
            parameters.Add("@KeyNumberPrevious", key.KeyNumberPrevious1);
            parameters.Add("@KeyNumberPrevDate", validation.getValidationDateTime().checkNullDate(key.KeyNumberPrevDate1));

            return fetch.fetchKeys(parameters, spName)[0].KeysID1;
        }
        private int CreateAppliances(Appliance appliance)
        {
            String spName = "spCreateAppliance";
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@fk_ApplianceTypeID", validation.getValidationInt().CheckNullForeignKey(appliance.Type1));
            parameters.Add("@ApplianceBrand", appliance.Brand1);
            parameters.Add("@ApplianceModel", appliance.Model1);
            parameters.Add("@ApplianceSerial", appliance.SerialNumber1);
            parameters.Add("@ApplianceLastRepalcementDate", validation.getValidationDateTime().checkNullDate((appliance.LastReplacementDate1)) ?? null);
            parameters.Add("@ApplianceColor", appliance.Color1);

            var results = fetch.fetchAppliances(parameters, spName)[0].ApplianceID1;
            return results;

        }
        private int CreateHouseAppliances(HouseAppliances houseAppliances)
        {
            String spName = "spCreateHouseAppliances";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_Ranger", validation.getValidationInt().CheckNullForeignKey(houseAppliances.Range1.ApplianceID1));
            parameters.Add("@fk_Dishwasher", validation.getValidationInt().CheckNullForeignKey(houseAppliances.Dishwasher1.ApplianceID1));
            parameters.Add("@HouseApplianceGDDate", validation.getValidationDateTime().checkNullDate((houseAppliances.LastGarbageDisposalReplacement1)) ?? null);
            parameters.Add("@HouseApplianceHasRefer", houseAppliances.HasRef1);


            var results = fetch.fetchHouseAppliances(parameters, spName);
            return results[0].HouseApplianceID1;
        }
        private int CreateInterrioFeatures(HouseInterriorFeatures interriorFeatures)
        {
            String spName = "spSetInterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@InterriorFeaturesHallShowerDate ", validation.getValidationDateTime().checkNullDate((interriorFeatures.HallShowerReplacementDate1)));
            parameters.Add("@InterriorFeaturesWaterHeaterDate ", validation.getValidationDateTime().checkNullDate((interriorFeatures.WaterHeaterReplacementDate1)));
            parameters.Add("@InterriorFeaturesCelingFanDate ", validation.getValidationDateTime().checkNullDate((interriorFeatures.CielingFanReplacementDate1)));
            parameters.Add("@InterriorFeaturesFurnanceReplacement", validation.getValidationDateTime().checkNullDate((interriorFeatures.FurnanceReplacementDate1)));
            return fetch.fetchHouseInterriorFeatures(parameters, spName)[0].HouseInterriorFeaturesID1;
        }
        private int CreateExterrioFeatures(HouseExteriorFeatures exteriorFeatures)
        {
            String spName = "CreateExterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ExteriorFenece", validation.getValidationDateTime().checkNullDate((exteriorFeatures.FenceReplacement1)));
            parameters.Add("@ExteriorGutterReplacement", validation.getValidationDateTime().checkNullDate((exteriorFeatures.GutterReplacemengt1)));
            parameters.Add("@ExteriorGarageDoor", validation.getValidationDateTime().checkNullDate((exteriorFeatures.GrageDoorReplacement1)));
            parameters.Add("@ExteriorDriveWay", validation.getValidationDateTime().checkNullDate((exteriorFeatures.DrivewayReplacemnt1)));
            parameters.Add("@ExteriorChimney", validation.getValidationDateTime().checkNullDate((exteriorFeatures.ChimneyReplacement1)));

            return fetch.fetchHouseExteriorFeatures(parameters, spName)[0].ExteriorFeaturesID1;
        }
        private int CreateInterrior(HouseInterrior interrior)
        {
            String spName = "spCreateHouseInterrior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_PrimaryColorID", validation.getValidationInt().CheckNullForeignKey(interrior.PrimaryPaintColorID1));
            parameters.Add("@fk_SecondaryColorID", validation.getValidationInt().CheckNullForeignKey(interrior.SecondaryPaintColorID1));
            parameters.Add("@HouseLastPaintDate", validation.getValidationDateTime().checkNullDate((interrior.LastPaintDate1)));
            parameters.Add("@fk_CarpetColorID", validation.getValidationInt().CheckNullForeignKey(interrior.CarpetColorID1));
            parameters.Add("@HouseInteriorCarpetDate", validation.getValidationDateTime().checkNullDate((interrior.CarpetInstallDate1)));
            parameters.Add("@fk_FermicaColorID", validation.getValidationInt().CheckNullForeignKey(interrior.FermicaColorID1));
            parameters.Add("@fk_VynlColorID", validation.getValidationInt().CheckNullForeignKey(interrior.VynalColorID1));
            parameters.Add("@HouseInteriorVFInstall", validation.getValidationDateTime().checkNullDate(interrior.VandFInstall1));
            parameters.Add("@fk_StainID", validation.getValidationInt().CheckNullForeignKey(interrior.StainID1));
            parameters.Add("@HouseBlindReplacement", validation.getValidationDateTime().checkNullDate(interrior.Blindreplacement1));

            return fetch.fetchHouseInterrior(parameters, spName)[0].HouseInteriorID1;
        }
        private int CreateExterrior(HouseExterior exterior)
        {
            String spName = "spCreateHouseExterior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_SidingID", validation.getValidationInt().CheckNullForeignKey(exterior.SidingID1));
            parameters.Add("@fk_ExteriorColorID", validation.getValidationInt().CheckNullForeignKey(exterior.ExteriorColorID1));
            parameters.Add("@HouseExteriorPaintDate", validation.getValidationDateTime().checkNullDate(exterior.ExteriorPaintDate1));
            parameters.Add("@fk_TrimID", validation.getValidationInt().CheckNullForeignKey(exterior.TrimID1));
            parameters.Add("@fk_RoofMaterialID", validation.getValidationInt().CheckNullForeignKey(exterior.RoofMaterialID1));
            parameters.Add("@fk_RoofColorID", validation.getValidationInt().CheckNullForeignKey(exterior.RoofColorID1));
            parameters.Add("@HouseExteriorRoofInstall", validation.getValidationDateTime().checkNullDate(exterior.RoofInstall1));

            return fetch.HouseExteriors(parameters, spName)[0].HouseExteriorID1;
        }
        private House CreateFinishedHouse(House house)
        {
            String spName = "spCreateHouse";
            var fkVal = validation.getValidationInt();
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@HouseNumber", house.HouseNumber1);
            parameters.Add("@fk_Street", house.StreetID1);
            parameters.Add("@fk_Owner", house.Owner.OwnerID1);
            parameters.Add("@fk_LeadTenant", fkVal.CheckNullForeignKey(house.LeadTenant.LeadTenantID1));
            parameters.Add("@fk_SQPlan", fkVal.CheckNullForeignKey(house.FloorPlanID1));
            parameters.Add("@fk_HouseInterriorID", fkVal.CheckNullForeignKey(house.HouseInterrior.HouseInteriorID1));
            parameters.Add("@fk_HouseExteriorID ", fkVal.CheckNullForeignKey(house.HouseExterior.HouseExteriorID1));
            parameters.Add("@fk_KeyNunberID", fkVal.CheckNullForeignKey(house.Keys.KeysID1));
            parameters.Add("@fk_interriorFeaturesID  ", fkVal.CheckNullForeignKey(house.InterriorFeatures.HouseInterriorFeaturesID1));
            parameters.Add("@fk_ExterriorFeaturesID  ", fkVal.CheckNullForeignKey(house.HouseExterior.HouseExteriorID1));
            parameters.Add("@HouseDidDiscloseLea", house.LeadDisclosure1);
            parameters.Add("@fk_HouseAppliancesID  ", fkVal.CheckNullForeignKey(house.HouseAppliances.HouseApplianceID1));
            parameters.Add("@HouseMiscellaneous", house.Miscellaneous1);

            return fetch.fetchHouseInformation(parameters, spName)[0];

        }

    }
}
