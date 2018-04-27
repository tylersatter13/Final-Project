using System;
using System.Collections.Generic;
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

        public List<User> fetchUserInformation(String username, String password)
        {      
           return userFetch.selectFormat( new[] {"UserName","UserRoleID"}, new[] {$"UserName='{username}' AND UserPassword ='{password}'" },"Users");  
        }
   
    }
}
