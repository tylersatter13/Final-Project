using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
   public class Pet
    {
        public int PetID;
        public int PetTypeID;
        public String petType;
        public String petBreed;
        public decimal petFee;
        public bool petFeePaid;
        public decimal petRent;
        public Pet(Int32 PetID,Int32 petTypeID,String petType, String petBreed, decimal petFee, decimal petRent, bool petFeePaid)
        {
            this.PetID = PetID;
            PetTypeID = petTypeID;
            this.petType = petType;
            this.petBreed = petBreed;
            this.petFee = petFee;
            this.petRent = petRent;
            this.petFeePaid = petFeePaid;

        }
    }
}
