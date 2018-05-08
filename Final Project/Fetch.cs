using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Fetch
    {
        private DatabaseConnection<User> userFetch = new DatabaseConnection<User>();
        private DatabaseConnection<TenantTransaction> transactionFetch = new DatabaseConnection<TenantTransaction>();
        private DatabaseConnection<Tenant> tenantFetch = new DatabaseConnection<Tenant>();
        private DatabaseConnection<LeadTenant> leadTennantFetcH = new DatabaseConnection<LeadTenant>();
        private DatabaseConnection<House> houseFetch = new DatabaseConnection<House>();
        private DatabaseConnection<HouseInterrior> houseIntFetch = new DatabaseConnection<HouseInterrior>();
        private DatabaseConnection<HouseExterior> houseExterFetch = new DatabaseConnection<HouseExterior>();
        private DatabaseConnection<HouseAppliances> houseApplianceFetch = new DatabaseConnection<HouseAppliances>();
        private DatabaseConnection<Appliance> applianceFetch = new DatabaseConnection<Appliance>();
        private DatabaseConnection<HouseExteriorFeatures> fetchHouseExtFeature = new DatabaseConnection<HouseExteriorFeatures>();
        private DatabaseConnection<HouseInterriorFeatures> fetchInterriorFeatures = new DatabaseConnection<HouseInterriorFeatures>();
        private DatabaseConnection<Owner> fetchOwner = new DatabaseConnection<Owner>();
        private DatabaseConnection<MaintenanceRequest> maintenanceRequestFetch = new DatabaseConnection<MaintenanceRequest>();
        private DatabaseConnection<MaintenanceTechnician> technicianfetch = new DatabaseConnection<MaintenanceTechnician>();
        private DatabaseConnection<MaintenancePart> partFetch = new DatabaseConnection<MaintenancePart>();
        private DatabaseConnection<TenantTransaction> transationFetch = new DatabaseConnection<TenantTransaction>();
        private DatabaseConnection<Keys> keysFetch = new DatabaseConnection<Keys>();
        public List<Owner> fetchHouseOwner(int HouseID)
        {
            return fetchOwner.selectFormat(new[] { "*" }, new[] { $"OwnerID = (SELECT fk_Owner FROM House WHERE HouseID = {HouseID})" }, "Owner");
        }
        public List<User> fetchUserInformation(String username, String password)
        {
            return userFetch.selectFormat(new[] { "UserName", "UserRoleID" }, new[] { $"UserName='{username}' AND UserPassword ='{password}'" }, "Users");
        }
        public List<House> fetchHouseByColor(String[]Select ,String[] where)
        {

            String From = " House INNER JOIN Street S2 on House.fk_Street = S2.StreetID INNER JOIN SQPlan S3 on House.fk_SQPlan = S3.SQPlanID   INNER JOIN  Owner O on House.fk_Owner = O.OwnerID";
            return houseFetch.selectFormat(Select, where, From);
        }
        public List<House> fetchHouseInformation(DynamicParameters parameters, String spName)
        {
            return houseFetch.selectStoredProcedure(parameters, spName);
        }
        public List<HouseInterrior> fetchHouseInterrior(DynamicParameters parameters, String spName)
        {
            return houseIntFetch.selectStoredProcedure( parameters, spName); 
        }
        public List<HouseInterriorFeatures> fetchHouseInterriorFeatures(DynamicParameters parameters, String spName)
        {
            return fetchInterriorFeatures.selectStoredProcedure(parameters, spName);
           
        }
        public List<HouseExterior> HouseExteriors(DynamicParameters parameters, String spName)
        {
            return houseExterFetch.selectStoredProcedure(parameters, spName);

        }
        public List<HouseExteriorFeatures> fetchHouseExteriorFeatures(DynamicParameters parameters, String spName)
        {
            return fetchHouseExtFeature.selectStoredProcedure(parameters, spName);
        }
        public List<HouseAppliances> fetchHouseAppliances(DynamicParameters parameters, String spName)
        {
            var results = houseApplianceFetch.selectStoredProcedure(parameters, spName);
            return results;
        }
        public List<Appliance> fetchAppliances(DynamicParameters parameters, String spName)
        {
            return applianceFetch.selectStoredProcedure(parameters, spName);
        }
        public List<LeadTenant> fetchLeadTenants(int HouseID)
        {
            return leadTennantFetcH.selectFormat(new[]{"LeadTenantID", "LeadTenantRentAmount AS rentAmount"
                ,"LeadTenantRentStart AS rentDate", "Children" ,"LeadTenantBalance as balance",
                "TenantID","TenantFirst","TenantLast","TenantPhone" },
                new[] { $"LeadTenantID = (SELECT fk_LeadTenant FROM House WHERE HouseID = {HouseID})" },
                "LeadTenant LEFT JOIN Tenant T on LeadTenant.fk_TennantID = T.TenantID");
        }

        public List<MaintenanceRequest> fetchMaintenanceRequests(DynamicParameters parameters, String spName)
        {
            return maintenanceRequestFetch.selectStoredProcedure(parameters, spName);
        }
        public List<MaintenanceTechnician> fetchMaintenanceTechnicians(DynamicParameters parameters, String spName)
        {
            return technicianfetch.selectStoredProcedure(parameters, spName);
        }
        public List<MaintenancePart> fetchMaintenaceParts(DynamicParameters paramaters, String spName)
        {
            return partFetch.selectStoredProcedure(paramaters, spName);
        }
        public List<TenantTransaction> fetchTransaction(DynamicParameters parameters, String spName)
        {
            return transactionFetch.selectStoredProcedure(parameters, spName);
        }
        public List<Keys> fetchKeys(DynamicParameters parameters, String spName)
        {
            return keysFetch.selectStoredProcedure(parameters, spName);
        }
        
    }
}
