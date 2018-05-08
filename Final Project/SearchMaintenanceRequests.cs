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
            return GetMaintenanceRequests(parameters, spName)[0];
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
            parameters.Add("@MaintenanceRequestId", MaintenanceRequestID);
            String spName = "spGetApplianceByMaintenance";
            return fetch.fetchAppliances(parameters, spName);
        }
        private MaintenanceTechnician getMaintenanceTechnician (int MaintenanceRequestID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenanceRequestID", MaintenanceRequestID);
            String spName = "spGetMaintenaceTechID";

            return fetch.fetchMaintenanceTechnicians(parameters, spName)[0]; 
        }
        private List<MaintenancePart> getMaintenaceParts( int MaintenaceRequestID)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@MaintenceRequestID", MaintenaceRequestID);

            String spName = "getPartsForMaintenceRequest";
            return fetch.fetchMaintenaceParts(parameters, spName);

        }
       private List<MaintenanceRequest> GetMaintenanceRequests(DynamicParameters paramaters, String spName)
        {
            try
            {
                var result = fetch.fetchMaintenanceRequests(paramaters, spName);
               
                return result;
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

            List<Appliance> appliances = searchFormMaintenanceAppliance(request.MaintenenceRequestID1);
            request.Appliances = appliances;

            request.MaintenanceTechnician = getMaintenanceTechnician(request.MaintenenceRequestID1);
            List<MaintenancePart> parts = getMaintenaceParts(request.MaintenenceRequestID1);

            request.Parts = parts;
            return request;
            
        }
    }
}
