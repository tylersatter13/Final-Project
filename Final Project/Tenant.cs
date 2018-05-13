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
       private String tenantFirst;
       private String tenantLast;
       private String tenantPhone;
     

        public Tenant(int tenantID)
        {
           tenantId = tenantID;
        }
        public Tenant(Int32 tenantID, String tenantFirst, String tenantLast, String tenantPhone)
        {
            this.tenantId = tenantID;
            this.tenantFirst = tenantFirst;
            this.tenantLast = tenantLast;
            this.TenantPhone = tenantPhone;
        }

        public int TenantId { get => tenantId; set => tenantId = value; }
        public String TenantFirst { get => tenantFirst; set => tenantFirst = value; }
        public String TenantLast { get => tenantLast; set => tenantLast = value; }
        public String TenantPhone { get => tenantPhone; set => tenantPhone = value; }
    }
}
