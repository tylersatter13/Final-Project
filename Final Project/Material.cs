using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Material
    {
        private int fk_MaintenaceRequestID;
        private int fk_PartID;

       public Material( int fk_MaintenaceRequestID, int fk_PartID)
        {
            this.fk_MaintenaceRequestID = fk_MaintenaceRequestID;
            this.fk_PartID = fk_PartID;
        }
    }
}
