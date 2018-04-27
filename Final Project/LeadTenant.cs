using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class LeadTenant : Tenant
    {
        public int rentAmount;
        public DateTime rentDate;
        public String children;
        public int balance;
        public List<Pet> pets;

        LeadTenant(int rentAmount, DateTime rentDate, String children, int balance, int tenantID, String tenantFirst, String tenantLast, string tenantPhone, List<Pet> pets) : this(rentAmount, rentDate, children, balance, tenantID, tenantFirst, tenantLast, tenantPhone) 
        {
            this.pets = pets;
        }
        LeadTenant(int rentAmount, DateTime rentDate, String children, int balance, int tenantID, String tenantFirst, String tenantLast, string tenantPhone) : base(tenantID, tenantFirst, tenantLast,
        tenantPhone)
        {
            this.rentAmount = rentAmount;
            this.rentDate = rentDate;
            this.children = children;
            this.balance = balance;

        }
    }
}
