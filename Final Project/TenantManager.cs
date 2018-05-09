using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Final_Project
{
    class TenantManager
    {
        Fetch fetch = new Fetch();
        ValidationType validation = new ValidationType();
        public LeadTenant addLeadTenant(LeadTenant leadTenant)
        {
           Tenant tenant = new Tenant(0, leadTenant.TenantFirst, leadTenant.TenantLast, leadTenant.TenantPhone);
           leadTenant.TenantId =  addTenant(tenant).TenantId;
            var finalLeadTenant = ConvertLeadTenant(leadTenant);
            return finalLeadTenant;
        }
        public Tenant addTenant(Tenant tenant)
        {
            String spName = "spCreateTenant";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TenantFirst", tenant.TenantFirst);
            parameters.Add("@TenantLast", tenant.TenantLast);
            parameters.Add("@TenantPhone",tenant.TenantPhone);
            var results = fetch.fetchHouseTenants(parameters, spName);
            return results[0];

        }
        public LeadTenant ConvertLeadTenant(LeadTenant leadTenant)
        {
            var dateCheck = validation.getValidationDateTime();
            var fkCheck = validation.getValidationInt();
            String spName = "spCreateLeadTenant";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@fk_TennantID  ", leadTenant.TenantId);
            parameters.Add("@LeadPetFeePaid ", null);
            parameters.Add("@LeadTenantRentStart",dateCheck.checkNullDate(leadTenant.RentDate));
            parameters.Add("@Children ", leadTenant.Children);
            parameters.Add("@LeadTenantRentAmount", leadTenant.RentAmount);
            parameters.Add("@LeadTenantBalance", leadTenant.Balance);
            parameters.Add("@fk_TenatFlag ",fkCheck.CheckNullForeignKey(leadTenant.TenantFlag));

            var results = fetch.fetchLeadTenants(parameters, spName);
            return results[0];
        }
        public LeadTenant updateLeadTenant(LeadTenant leadTenant)
        {
            throw new NotImplementedException();
        }
        public Tenant updateTenant(Tenant tenant){
            throw new NotImplementedException();
        }
    }
}
