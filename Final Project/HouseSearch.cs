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
            if (house.HouseID1!= 0)
            {
                return findHouseByInterriorColor(house.HouseInterrior.PrimaryPaintColorID1);
            }
            else
            {
                return new List<House>();
            }
            
        }
       public List<House> findExteriorColorByHouse(String houseNumber)
        {
            var house = findAHouseByNumber(houseNumber);
            if (house.HouseID1 != 0)
            {
                return findHouseByExteriorColor(house.HouseExterior.ExteriorColorID1);
            }
            else
            {
                return new List<House>();
            }
        }
       public List<House> findHouses()
        {
            var spName = "spGetAllHouses";
            DynamicParameters parameters = new DynamicParameters();

           var results = fetch.fetchHouseInformation(parameters, spName);
            return generateHouse(results);

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

            var results = fetch.fetchHouseInformation(parameters,spName);

            if (results.Count != 0)
            {
                return generateHouse(results[0]);
            }
            else
            {
                alert.CreateBasicAlert(1, "No results Found", "Search Notification");
                return new House(0);
            }
        }
        public House findAHouseByLastName(String lastName)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LastName", lastName);
            String spName = "spGetHouseByLastName";

            var results = fetch.fetchHouseInformation(parameters, spName);

            if (results.Count != 0)
            {
                House finalresults = generateHouse(results[0]).clone();
                return finalresults.clone();
            }
            else
            {
                alert.CreateBasicAlert(1, "No match found", "Search Results");
                return new House(0);
            }
            

        
        }
        public House findHouseByMaintenaceID(int MaintenanceID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenaneRequestID", MaintenanceID);
            String spName = "spGetHouseByMaintenance";
            var results = fetch.fetchHouseInformation(parameters, spName)[0];

            return generateHouse(results);
        }
       private List<House> generateHouse(List<House> houses)
        {
            foreach(House house in houses)
            {
                generateHouse(house);
            }
            return houses;
        }


       private House generateHouse(House house)
        {
           
            var houseID = house.HouseID1;
            LeadTenant leadTenant = new LeadTenant(0, 0);
            leadTenant = GetLeadTenant(houseID);
            if (leadTenant != null){
                house.LeadTenant = leadTenant.clone();
                house.LeadTenant.Pets = GetLeadTenantPets(house.LeadTenant.LeadTenantID1);
            }
           house.ExteriorFeatures = GetHouseExteriorFeatures(houseID);
           house.InterriorFeatures = GetHouseInterriorFeatures(houseID);
            house.HouseAppliances = GetHouseAppliances(houseID);
           house.HouseInterrior = GetHouseInterrior(houseID);
           house.HouseExterior = GetHouseExterior(houseID);
            house.Owner = fetch.fetchHouseOwner(houseID)[0];
            house.Tenants1 = GetHouseTenant(houseID);
            //house.LeadTenant = GetLeadTenant(houseID);
            Console.WriteLine("Did complete generating houses");
            house.LeadTenant.Pets = GetLeadTenantPets(house.LeadTenant.LeadTenantID1);
        //    Console.WriteLine(house.LeadTenant.TenantFirst);
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
   private List<Tenant> GetHouseTenant( int HouseID)
        {
            String spName = "spGetHouseTenants";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);
            return fetch.fetchHouseTenants(parameters, spName);

        }
   public LeadTenant GetLeadTenant( int HouseID)
        {
            String spName = "spGetLeadTenant";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@HouseID", HouseID);


            var results = fetch.fetchLeadTenants(parameters, spName);

            if (results.Count() == 1)
            {
                var tenant = results[0];
                tenant.Pets.AddRange(GetLeadTenantPets(tenant.LeadTenantID1));

                return tenant;
            }

            return null;
          
        }
        public List<Pet> GetLeadTenantPets(int LeadTenantID)
        {
            String spName = "spGetTenantPets";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@LeadTenantID", LeadTenantID);

            var results = fetch.fetchPets(parameters, spName);
            return results;
    }
    }
 
}
