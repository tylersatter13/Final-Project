using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class MaintenancePart
    {
       private int PartID;
       private String PartName;
       private Decimal PartCost;
       bool InStock;

        public MaintenancePart(Int32 partID, String partName, Double partCost, Boolean inStock)
        {
            PartID1 = partID;
            PartName1 = partName;
            PartCost1 = decimal.Parse(partCost.ToString());
            InStock1 = inStock;
        }

        public int PartID1 { get => PartID; set => PartID = value; }
        public string PartName1 { get => PartName; set => PartName = value; }
        public decimal PartCost1 { get => PartCost; set => PartCost = value; }
        public bool InStock1 { get => InStock; set => InStock = value; }
    }
}
