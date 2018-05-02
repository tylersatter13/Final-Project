using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class House
    {
        private int HouseID;
        private int OwnerID;
        private String HouseOwner;
        private String HouseNumber;
        private int StreetID;
        private String Streetname;
        private String FloorPlan;
        private int FloorPlanID;


        private HouseAppliances houseAppliances;
        private HouseInterriorFeatures interriorFeatures;
        private HouseExteriorFeatures exteriorFeatures;
        private HouseInterrior houseInterrior;
        private HouseExterior houseExterior;
        private LeadTenant leadTenant;
        private Owner owner;
        private ValidationType validate = new ValidationType();

        internal HouseAppliances HouseAppliances { get => houseAppliances; set => houseAppliances = value; }
        internal HouseInterriorFeatures InterriorFeatures { get => interriorFeatures; set => interriorFeatures = value; }
        internal HouseExteriorFeatures ExteriorFeatures { get => exteriorFeatures; set => exteriorFeatures = value; }
        internal HouseInterrior HouseInterrior { get => houseInterrior; set => houseInterrior = value; }
        internal HouseExterior HouseExterior { get => houseExterior; set => houseExterior = value; }
        internal LeadTenant LeadTenant { get => leadTenant; set => leadTenant = value; }
        public string HouseNumber1 { get => HouseNumber;}
        public int StreetID1 { get => StreetID;}
        public string Streetname1 { get => Streetname;}
        public string FloorPlan1 { get => FloorPlan; }
        public int FloorPlanID1 { get => FloorPlanID;}
        public int HouseID1 { get => HouseID; set => HouseID = value; }
        internal Owner Owner { get => owner; set => owner = value; }

        House(Int32 HouseID,String HouseNumber,Int32 fk_Street,String StreetName,  Int32 fk_SQPlan,String SQPlanName) 

        {
            this.HouseID1 = HouseID;
            this.HouseNumber = HouseNumber;
            setStreet(fk_Street,StreetName);
            setFloorPlan(SQPlanName, fk_SQPlan);
        }

        public void setStreet(int StreetID,String Streetname) // If both fields contain valid inputs then the House Owner is set
        {
            if (validate.getValidationInt().fieldHasValue(StreetID) == false)
            {
                if (validate.getValidationString().fieldHasValue(Streetname) == false)
                {
                    this.StreetID = StreetID;
                    this.Streetname = Streetname;
                }
                else
                 {
                   Console.WriteLine("StreetName was nil Street valus were not set");
                }

            }
            else
            {
                Console.WriteLine("StreetID was nil Street values were not set");
            }
        }
        
        public void setFloorPlan(String FloorPlan, int FloorPlanID) // If both fields contain valid inputs then the Floor plan is set
        {
            if(validate.getValidationInt().fieldHasValue(StreetID1) == false)
            {
                if (validate.getValidationString().fieldHasValue(FloorPlan) == false)
                {
                    this.FloorPlan = FloorPlan;
                    this.FloorPlanID = FloorPlanID;
                }
            }
        }
    

    }
}
