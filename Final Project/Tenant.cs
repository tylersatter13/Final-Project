using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Tenant
    {
       private int tenantId;
       private string tenantFirst;
       private string tenantLast;
       private string tenantPhone;
     

        public Tenant(int tenantID)
        {
           tenantId = tenantID;
        }
        public Tenant(int tenantID, string tenantFirst, string tenantLast, string tenantPhone)
        {
            this.tenantId = tenantID;
            this.tenantFirst = tenantFirst;
            this.tenantLast = tenantLast;
        }

        public int TenantId { get => tenantId; set => tenantId = value; }
        public string TenantFirst { get => tenantFirst; set => tenantFirst = value; }
        public string TenantLast { get => tenantLast; set => tenantLast = value; }
        public string TenantPhone { get => tenantPhone; set => tenantPhone = value; }
    }
}
