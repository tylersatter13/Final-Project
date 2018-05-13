using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class HouseSearch
    {
        public Alert alert = new Alert();
        private Fetch fetch = new Fetch();
      //  private String[] HouseSelect = new[] { "HouseID", "HouseNumber", "fk_Street", "StreetName", "HouseDidDiscloseLea", "fk_SQPlan", "S3.SQPlanName" };
      //  private String[] HouseJoin = new[]

       public List<House> findInterriorColorByHouse(String houseNumber)
        {
            var house = findAHouseByNumber(houseNumber);
            return findHouseByInterriorColor(house.HouseInterrior.PrimaryPaintColorID1);
        }
       public List<House> findExteriorColorByHouse(String houseNumber)
        {
            var house = findAHouseByNumber(houseNumber);
            return findHouseByExteriorColor(house.HouseExterior.ExteriorColorID1);
        }
        public List<House> findHouseByExteriorColor(int ColorID)
        {
            try
            {
                String spName = "spGetHouseByExterriorColor";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@colorID", ColorID);
                var homes = fetch.fetchHouseInformation(parameters, spName);
                
                foreach (House house in homes )
                {
                    generateHouse(house);
                }
                return homes;
            }
            catch (Exception ex)
            {
                alert.CreateBasicAlert(3, "No match Found", "Error");
                Console.WriteLine(ex);
                return null;
            }
        }
        public List<House> findHouseByInterriorColor(int ColorID)
        {
            /*String[] where = new[] { $" fk_HouseInterriorID = (SELECT HouseInteriorID FROM dbo.HouseInterior WHERE " +
               $"fk_PrimaryColorID = {ColorID} OR fk_SecondaryColorID = {ColorID})" };*/
            String spName = "spGetHouseByInterriorColors";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ColorID", ColorID);
            try
            {

                List<House> homes = fetch.fetchHouseInformation(parameters, spName);
           
                foreach(House house in homes)
                {
                    generateHouse(house);
                   /* house.HouseInterrior = GetHouseInterrior(house.HouseID1);
                    house.Owner = fetch.fetchHouseOwner(house.HouseID1)[0];
                    house.LeadTenant = GetLeadTenant(house.HouseID1);*/
                }
                return homes;
            }
            catch (Exception ex)
            {
                alert.CreateBasicAlert(3, "No match Found", "Error");
                Console.WriteLine(ex);
                return null;
            }
        }
        public House findAHouseByNumber(String HouseNumber)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseNumber", HouseNumber); // insert variables in the query
            String spName = "spGetHouseByNumber";  // Sets the stored procedure name
            var results = fetch.fetchHouseInformation(parameters,spName)[0];
            return generateHouse(results);
        }
        public House findAHouseByLastName(String lastName)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LastName", lastName);
            String spName = "spGetHouseByLastName";

            var results = fetch.fetchHouseInformation(parameters, spName)[0];
        
            House finalresults =  generateHouse(results).clone();
            Console.WriteLine("Results returned from By LastName");
            Console.WriteLine(finalresults.LeadTenant.TenantLast);
            Console.WriteLine(finalresults.LeadTenant.TenantFirst);
            Console.WriteLine(finalresults.LeadTenant.TenantPhone);

            return finalresults.clone();
        }
        public House findHouseByMaintenaceID(int MaintenanceID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenaneRequestID", MaintenanceID);
            String spName = "spGetHouseByMaintenance";
            var results = fetch.fetchHouseInformation(parameters, spName)[0];

            return generateHouse(results);
        }
       
       private House generateHouse(House house)
        {
            Cloner clone = new Cloner();
            var houseID = house.HouseID1;
            LeadTenant leadTenant = new LeadTenant(0, 0);
            leadTenant = GetLeadTenant(houseID);
            house.LeadTenant = leadTenant.clone();
           house.ExteriorFeatures = GetHouseExteriorFeatures(houseID);
           house.InterriorFeatures = GetHouseInterriorFeatures(houseID);
            house.HouseAppliances = GetHouseAppliances(houseID);
           house.HouseInterrior = GetHouseInterrior(houseID);
           house.HouseExterior = GetHouseExterior(houseID);
            house.Owner = fetch.fetchHouseOwner(houseID)[0];

            //house.LeadTenant = GetLeadTenant(houseID);
            Console.WriteLine("Did complete generating houses");
           
            Console.WriteLine(house.LeadTenant.TenantFirst);
            Console.WriteLine(house.Owner.OwnerInitals1);
            Console.WriteLine(house.ExteriorFeatures.DrivewayReplacemnt1);
            Console.WriteLine(house.HouseAppliances.LastGarbageDisposalReplacement1);
            return house;


        }
     private HouseExteriorFeatures GetHouseExteriorFeatures(int HouseID)
        {
            String spName = "spGetExteriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);

           return fetch.fetchHouseExteriorFeatures(parameters, spName)[0];
        }
    private HouseInterriorFeatures GetHouseInterriorFeatures(int HouseID)
        {
            String spName = "spGetTheInterriorFeatures";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);

            return fetch.fetchHouseInterriorFeatures(parameters, spName)[0];
        }
   private HouseAppliances GetHouseAppliances(int HouseID)
        {
            String spName = "spSelectHouseAppliance";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);

            var results = fetch.fetchHouseAppliances(parameters, spName)[0];

            results.Range1 = GetAppliance(results.HouseApplianceID1, 1);
            results.Dishwasher1 = GetAppliance(results.HouseApplianceID1, 2);
            return results;
        }
   private Appliance GetAppliance(int HouseAppliancesID, int Type)
        {
            String spName = "spGetAppliance";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseApplianceID",  HouseAppliancesID);
            parameters.Add("@TypeID", Type);

            return fetch.fetchAppliances(parameters, spName)[0];
        }
   private HouseInterrior GetHouseInterrior(int HouseID)
        {
            String spName = "spGetInterrior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);

            return fetch.fetchHouseInterrior(parameters, spName)[0];

        }
   private HouseExterior GetHouseExterior( int HouseID)
        {
            String spName = "GetHouseExterrior";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);
            return fetch.HouseExteriors(parameters, spName)[0];
        }
   public LeadTenant GetLeadTenant( int HouseID)
        {
            String spName = "spGetLeadTenant";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);
           LeadTenant results = fetch.fetchLeadTenants(parameters, spName)[0];

            Console.WriteLine(results.TenantLast);
            Console.WriteLine(results.TenantFirst);
            Console.WriteLine(results.TenantPhone);
            return results;
        }
    }
}
