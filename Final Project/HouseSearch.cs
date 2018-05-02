using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class HouseSearch
    {
        private Fetch fetch = new Fetch();
        public House findAHouseByNumber(String HouseNumber)
        {
            var results = fetch.fetchHouseInformationByHouseNum(HouseNumber)[0];
            return generateHouse(results);
        }
        public House findAHouseByLastName(String lastName)
        {

            var results = fetch.fetchHouseInformationByLast(lastName)[0];
            return  generateHouse(results);

        }
        public House generateHouse(House house)
        {
            var houseID = house.HouseID1;
            house.ExteriorFeatures = fetch.fetchHouseExteriorFeatures(houseID)[0];
            house.InterriorFeatures = fetch.fetchHouseInterriorFeatures(houseID)[0];
            house.HouseAppliances = fetch.fetchHouseAppliances(houseID)[0];
            house.HouseInterrior = fetch.fetchHouseInterrior(houseID)[0];
            house.HouseExterior = fetch.HouseExteriors(houseID)[0];
            house.Owner = fetch.fetchHouseOwner(houseID)[0];
            //house.LeadTenant = fetch.L
            return house;


        }

    }
}
