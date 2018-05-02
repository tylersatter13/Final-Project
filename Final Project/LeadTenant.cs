

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class LeadTenant : Tenant
    {
        private int LeadTenantID;
        private int rentAmount;
        private DateTime rentDate;
        private String children;
        private int balance;
        private List<Pet> pets;

       public LeadTenant(int LeadTenantID, int rentAmount, DateTime rentDate, String children, int balance, int tenantID, String tenantFirst, String tenantLast, string tenantPhone, List<Pet> pets) : this(LeadTenantID, rentAmount, rentDate, children, balance, tenantID, tenantFirst, tenantLast, tenantPhone) 
        {
            this.pets = pets;
        }
        public LeadTenant(int LeadTenantID, int rentAmount, DateTime rentDate, String children, int balance, int tenantID, String tenantFirst, String tenantLast, string tenantPhone) : base(tenantID, tenantFirst, tenantLast,
        tenantPhone)
        {
            this.LeadTenantID = LeadTenantID;
            this.rentAmount = rentAmount;
            this.rentDate = rentDate;
            this.children = children;
            this.balance = balance;

        }
    }
}
