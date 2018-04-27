using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Pet
    {
        public String petType;
        public String petBreed;
        public String petFee;
        public bool petFeePaid;

        public Pet(String petType, String petBreed, String petFee, bool petFeePaid)
        {
            this.petType = petType;
            this.petBreed = petBreed;
            this.petFee = petFee;
            this.petFeePaid = petFeePaid;
        }
    }
}
