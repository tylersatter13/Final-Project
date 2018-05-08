using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class HouseExteriorFeatures
    {
        private int ExteriorFeaturesID;
        private DateTime FenceReplacement;
        private DateTime GutterReplacemengt;
        private DateTime GrageDoorReplacement;
        private DateTime DrivewayReplacemnt;
        private DateTime ChimneyReplacement;

        public HouseExteriorFeatures(int exteriorFeaturesID)
        {
            ExteriorFeaturesID = exteriorFeaturesID;
        }
        public HouseExteriorFeatures(DateTime fenceReplacement, DateTime gutterReplacemengt,
            DateTime grageDoorReplacement, DateTime drivewayReplacemnt, DateTime chimneyReplacement)
        {
            FenceReplacement = fenceReplacement;
            GutterReplacemengt = gutterReplacemengt;
            GrageDoorReplacement = grageDoorReplacement;
            DrivewayReplacemnt = drivewayReplacemnt;
            ChimneyReplacement = chimneyReplacement;
        }

        public HouseExteriorFeatures(int exteriorFeaturesID, DateTime fenceReplacement, DateTime gutterReplacemengt, DateTime grageDoorReplacement, DateTime drivewayReplacemnt, DateTime chimneyReplacement)
        {
            ExteriorFeaturesID = exteriorFeaturesID;
            FenceReplacement = fenceReplacement;
            GutterReplacemengt = gutterReplacemengt;
            GrageDoorReplacement = grageDoorReplacement;
            DrivewayReplacemnt = drivewayReplacemnt;
            ChimneyReplacement = chimneyReplacement;
        }

        public int ExteriorFeaturesID1 { get => ExteriorFeaturesID; set => ExteriorFeaturesID = value; }
        public DateTime FenceReplacement1 { get => FenceReplacement; set => FenceReplacement = value; }
        public DateTime GutterReplacemengt1 { get => GutterReplacemengt; set => GutterReplacemengt = value; }
        public DateTime GrageDoorReplacement1 { get => GrageDoorReplacement; set => GrageDoorReplacement = value; }
        public DateTime DrivewayReplacemnt1 { get => DrivewayReplacemnt; set => DrivewayReplacemnt = value; }
        public DateTime ChimneyReplacement1 { get => ChimneyReplacement; set => ChimneyReplacement = value; }
    }
}
