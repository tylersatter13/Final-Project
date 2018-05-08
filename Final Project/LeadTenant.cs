

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
        private Decimal rentAmount;
        private DateTime rentDate;
        private int children;
        private Decimal balance;
        private List<Pet> pets;

        public int LeadTenantID1 { get => LeadTenantID; set => LeadTenantID = value; }
        public decimal RentAmount { get => rentAmount; set => rentAmount = value; }
        public DateTime RentDate { get => rentDate; set => rentDate = value; }
        public int Children { get => children; set => children = value; }
        public decimal Balance { get => balance; set => balance = value; }
        internal List<Pet> Pets { get => pets; set => pets = value; }

        public LeadTenant(Int32 LeadTenantID, Decimal rentAmount, DateTime rentDate, Int32 Children, Int32 balance, Int32 TenantID,
           String TenantFirst, String TenantLast, String TenantPhone, List<Pet> pets) 
            : this(LeadTenantID, rentAmount, rentDate, Children, balance, TenantID, TenantFirst, TenantLast, TenantPhone) 
        {
            this.pets = pets;
        }
        public LeadTenant(Int32 LeadTenantID, Decimal rentAmount, DateTime rentDate, Int32 Children,
            Decimal balance, Int32 TenantID, String TenantFirst, String TenantLast, String TenantPhone) 
            : base(TenantID, TenantFirst, TenantLast, TenantPhone)
        {
            this.LeadTenantID = LeadTenantID;
            this.rentAmount = rentAmount;
            this.rentDate = rentDate;
            this.children = Children;
            this.balance = balance;

        }
    }
}
