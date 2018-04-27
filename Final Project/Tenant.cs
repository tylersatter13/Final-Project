using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Tenant
    {
        public int tenantId;
        public string tenantFirst;
        public string tenantLast;
        public string tenantPhone;
     

        
        public Tenant(int tenantID, string tenantFirst, string tenantLast, string tenantPhone)
        {
            this.tenantId = tenantID;
            this.tenantFirst = tenantFirst;
            this.tenantLast = tenantLast;
        }
    }
}
