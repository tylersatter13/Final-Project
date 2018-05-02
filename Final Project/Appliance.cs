using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Appliance
    {
        private int ApplianceID;
        private String Brand;
        private String Color;
        private String Model;
        private String SerialNumber;
        private DateTime LastReplacementDate;
        private int Type;

        public Appliance(Int32 applianceID, String brand, String color, String model, String serialNumber,DateTime lastReplacementDate)
        {
            ApplianceID = applianceID;
            Brand = brand;
            Color = color;
            Model = model;
            SerialNumber = serialNumber;
            LastReplacementDate1 = lastReplacementDate;
        }

        public int ApplianceID1 { get => ApplianceID; set => ApplianceID = value; }
        public string Brand1 { get => Brand; set => Brand = value; }
        public string Color1 { get => Color; set => Color = value; }
        public string Model1 { get => Model; set => Model = value; }
        public string SerialNumber1 { get => SerialNumber; set => SerialNumber = value; }
      
        public int Type1 { get => Type; set => Type = value; }// 1 = Range, 2 = Dishwasher
        public DateTime LastReplacementDate1 { get => LastReplacementDate; set => LastReplacementDate = value; }
    }
}
