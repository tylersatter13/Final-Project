using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Pet
    {
        public int PetID;
        public String petType;
        public String petBreed;
        public decimal petFee;
        public bool petFeePaid;
        public decimal petRent;
        public Pet(int PetID,String petType, String petBreed, decimal petFee, decimal petRent, bool petFeePaid)
        {
            this.PetID = PetID;
            this.petType = petType;
            this.petBreed = petBreed;
            this.petFee = petFee;
            this.petRent = petRent;
            this.petFeePaid = petFeePaid;

        }
    }
}
