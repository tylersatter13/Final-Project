using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class StreetNames
    {
       private int StreetID;
       private String StreetName;

        public StreetNames(Int32 streetID, String streetName)
        {
            StreetID = streetID;
            StreetName = streetName;
        }

        public int StreetID1 { get => StreetID; set => StreetID = value; }
        public string StreetName1 { get => StreetName; set => StreetName = value; }
    }
}
