using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class HouseCreate
    {
        public House CreateNewHouse(House house)
        {
            house.InterriorFeatures.HouseInterriorFeaturesID1 = CreateHouseInterriorFeatures(house.InterriorFeatures);
            house.ExteriorFeatures.ExteriorFeaturesID1 = CreateHouseExterriorFeatures(house.ExteriorFeatures);
            house.HouseExterior.HouseExteriorID1 = CreateHouseExterior(house.HouseExterior);
            house.HouseInterrior.HouseInteriorID1 = CreateHouseInterrior(house.HouseInterrior);
            house.HouseAppliances.HouseApplianceID1 = CreateHouseAppliances(house.HouseAppliances);
            house.HouseAppliances.Range1.ApplianceID1 = CreateAppliances(house.HouseAppliances.Range1);
            house.HouseAppliances.Dishwasher1.ApplianceID1 = CreateAppliances(house.HouseAppliances.Range1);
            house.HouseID1 = CreateCoreHouse(house);
            return house;
        }
        private int CreateCoreHouse(House house)
        {
            String spName = "spCreateHouse";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseNumber",house.HouseNumber1); 
            parameters.Add("@fk_Street", house.StreetID1);
            parameters.Add("@fk_Owner", house.Owner.OwnerID1);
         /**/   parameters.Add("@fk_LeadTenant", house.LeadTenant.TenantId);  /*Need to error test before adding*/ 
            parameters.Add("@fk_SQPlan",house.FloorPlanID1);
            parameters.Add("@fk_HouseInterriorID", house.HouseInterrior.HouseInteriorID1);
            parameters.Add("@fk_HouseExteriorID",house.HouseExterior.HouseExteriorID1);
     /**/   parameters.Add("@fk_KeyNunberID", house.Keys.KeyNumberID1 );/*Missing Function*/
            parameters.Add("@fk_interriorFeaturesID", house.InterriorFeatures.HouseInterriorFeaturesID1);
            parameters.Add("@fk_ExterriorFeaturesID", house.ExteriorFeatures.ExteriorFeaturesID1);
            parameters.Add("@HouseDidDiscloseLea", house.LeadDisclosure1);
            parameters.Add("@fk_HouseAppliancesID", house.HouseAppliances.HouseApplianceID1); 
            parameters.Add("@HouseMiscellaneous", house.Miscellaneous1);
            return house.HouseID1;
        }
        private int CreateHouseInterrior(HouseInterrior houseInterrior)
        {
            return houseInterrior.HouseInteriorID1;
        }
        private int CreateHouseExterior(HouseExterior houseExterior)
        {
            return houseExterior.HouseExteriorID1;
        }
        private int CreateHouseInterriorFeatures(HouseInterriorFeatures interriorFeatures)
        {

            return interriorFeatures.HouseInterriorFeaturesID1;
        }
        private int CreateHouseExterriorFeatures(HouseExteriorFeatures exteriorFeatures)
        {
            return exteriorFeatures.ExteriorFeaturesID1;
        }
        private int CreateHouseAppliances(HouseAppliances houseAppliances)
        {
            throw new NotImplementedException();
        }
        private int CreateAppliances( Appliance appliance)
        {
            return appliance.ApplianceID1;
        }
        
    }
}
