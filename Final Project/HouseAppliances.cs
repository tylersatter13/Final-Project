using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class HouseAppliances
    {
        private int HouseApplianceID;
        private Appliance Range;
        private Appliance Dishwasher;
        private DateTime LastWaterHeaterReplacement;
        private DateTime LastGarbageDisposalReplacement;
        private bool HasRef;

        public HouseAppliances(DateTime lastWaterHeaterReplacement, DateTime lastGarbageDisposalReplacement, bool hasRef)
        {
            LastWaterHeaterReplacement = lastWaterHeaterReplacement;
            LastGarbageDisposalReplacement = lastGarbageDisposalReplacement;
            HasRef = hasRef;
        }

        public HouseAppliances(int houseApplianceID, DateTime lastWaterHeaterReplacement, DateTime lastGarbageDisposalReplacement, bool hasRef)
        {
            HouseApplianceID = houseApplianceID;
            LastWaterHeaterReplacement = lastWaterHeaterReplacement;
            LastGarbageDisposalReplacement = lastGarbageDisposalReplacement;
            HasRef = hasRef;
        }

        public int HouseApplianceID1 { get => HouseApplianceID; set => HouseApplianceID = value; }
        public DateTime LastWaterHeaterReplacement1 { get => LastWaterHeaterReplacement; set => LastWaterHeaterReplacement = value; }
        public DateTime LastGarbageDisposalReplacement1 { get => LastGarbageDisposalReplacement; set => LastGarbageDisposalReplacement = value; }
        public bool HasRef1 { get => HasRef; set => HasRef = value; }
        internal Appliance Range1 { get => Range; set => Range = value; }
        internal Appliance Dishwasher1 { get => Dishwasher; set => Dishwasher = value; }
    }
}
