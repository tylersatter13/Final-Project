using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Final_Project
{
    class SearchMaintenanceRequests
    {
        private int LeadTenant;
        private HouseSearch houseSearch = new HouseSearch();
        private Fetch fetch = new Fetch();
        ValidationType validation = new ValidationType();
       public MaintenanceRequest searchByLastName( String LastName)
        {
            DynamicParameters parameters = new DynamicParameters();
            String spName = "spGetMaintenceRequest";// Stored Procedure Name
            parameters.Add("@LastName", LastName);

            return GetMaintenanceRequests(parameters, spName)[0];
        }
        public MaintenanceRequest searchByHouseNumber( String HouseNumber)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@houseNumber", HouseNumber); 
            String spName = "spGetMaintenceRequestByHouse";
            var results = GetMaintenanceRequests(parameters, spName)[0];
            return results;
        }
        public List<MaintenanceRequest> searchForOpenRequests()

        {
            String spName = "spGetOpenMaintenceRequest";
            return GetMaintenanceRequests(null, spName);
        } 
        public List<MaintenanceRequest> searchForRequestsByType(int TypeID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@RepairTypeID", TypeID);
            String spName = "spGetMaintenceRequestByType ";
            return GetMaintenanceRequests(parameters, spName);
        }
        private List <Appliance> searchFormMaintenanceAppliance(int MaintenanceRequestID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenanceRequestID", MaintenanceRequestID);
            String spName = "spGetApplianceByMaintenance";
            var results = fetch.fetchAppliances(parameters, spName);
            return results;
        }
        private MaintenanceTechnician getMaintenanceTechnician (int MaintenanceRequestID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenanceRequestID", MaintenanceRequestID);
            String spName = "spGetMaintenaceTechID";

            var results = fetch.fetchMaintenanceTechnicians(parameters, spName)[0];
            return results;
        }
        private List<MaintenancePart> getMaintenaceParts( int MaintenaceRequestID)
        {
            Console.WriteLine(MaintenaceRequestID);
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenceRequestID", MaintenaceRequestID);
            

            String spName = "spGetPartsForMaintenceRequest";
            var results = fetch.fetchMaintenaceParts(parameters, spName);
            if (!results.Any())
            {
                return results;
            }
            else
            {
                return new List<MaintenancePart>();
            }

        }
       private List<MaintenanceRequest> GetMaintenanceRequests(DynamicParameters paramaters, String spName)
        {
            try
            {
                var result = fetch.fetchMaintenanceRequests(paramaters, spName);

                var fullresults = generateFullMaintenanceRequest(result);

                return fullresults;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        private List<MaintenanceRequest> generateFullMaintenanceRequest (List<MaintenanceRequest> requests)
        {
           foreach ( MaintenanceRequest request in requests)
            {
                generateFullMaintenanceRequest(request);
            }
            return requests;
        }
        private MaintenanceRequest generateFullMaintenanceRequest( MaintenanceRequest request)
        {
            request.House = houseSearch.findHouseByMaintenaceID(request.MaintenenceRequestID1);

            Console.WriteLine("Printing retreiced house");
            //   request.House.print();

             if (request.IsAppliance1 == true) {
             List<Appliance> appliances = searchFormMaintenanceAppliance(1);
                request.Appliances = appliances;
             }
            request.MaintenanceTechnician = getMaintenanceTechnician(1);

            if (validation.getValidationDateTime().fieldHasValue(request.DateCompleted1) == false)
            {
            List<MaintenancePart> parts = getMaintenaceParts(1);
            request.Parts.Concat(parts);
               
            }
          
            return request;    
        }
        
    }
}
