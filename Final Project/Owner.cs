using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Owner
    {
        private int OwnerID;
        private String OwnerFirst;
        private String OwnerLast;
        private String OwnerInitals;

        public Owner(int ownerID, string ownerFirst, string ownerLast, string ownerInitals)
        {
            OwnerID1 = ownerID;
            OwnerFirst1 = ownerFirst;
            OwnerLast1 = ownerLast;
            OwnerInitals1 = ownerInitals;
        }

        public int OwnerID1 { get => OwnerID; set => OwnerID = value; }
        public string OwnerFirst1 { get => OwnerFirst; set => OwnerFirst = value; }
        public string OwnerLast1 { get => OwnerLast; set => OwnerLast = value; }
        public string OwnerInitals1 { get => OwnerInitals; set => OwnerInitals = value; }
    }
}
