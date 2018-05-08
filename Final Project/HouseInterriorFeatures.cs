using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class HouseInterriorFeatures
    {
        private int HouseInterriorFeaturesID;
        private DateTime HallShowerReplacementDate;
        private DateTime WaterHeaterReplacementDate;
        private DateTime CielingFanReplacementDate;
        private DateTime FurnanceReplacementDate;


        public HouseInterriorFeatures( DateTime hallShowerReplacementDate,
            DateTime waterHeaterReplacementDate, DateTime cielingFanReplacementDate, DateTime furnanceReplacementDate)
        {
            HallShowerReplacementDate = hallShowerReplacementDate;
            WaterHeaterReplacementDate = waterHeaterReplacementDate;
            CielingFanReplacementDate = cielingFanReplacementDate;
            FurnanceReplacementDate = furnanceReplacementDate;
        }
        public HouseInterriorFeatures(int houseInterriorFeaturesID,   DateTime hallShowerReplacementDate, DateTime waterHeaterReplacementDate,
            DateTime cielingFanReplacementDate, DateTime furnanceReplacementDate)
        {
            HouseInterriorFeaturesID = houseInterriorFeaturesID;
            HallShowerReplacementDate = hallShowerReplacementDate;
            WaterHeaterReplacementDate = waterHeaterReplacementDate;
            CielingFanReplacementDate = cielingFanReplacementDate;
            FurnanceReplacementDate = furnanceReplacementDate;
        }

        public int HouseInterriorFeaturesID1 { get => HouseInterriorFeaturesID; set => HouseInterriorFeaturesID = value; }
        public DateTime HallShowerReplacementDate1 { get => HallShowerReplacementDate; set => HallShowerReplacementDate = value; }
        public DateTime WaterHeaterReplacementDate1 { get => WaterHeaterReplacementDate; set => WaterHeaterReplacementDate = value; }
        public DateTime CielingFanReplacementDate1 { get => CielingFanReplacementDate; set => CielingFanReplacementDate = value; }
        public DateTime FurnanceReplacementDate1 { get => FurnanceReplacementDate; set => FurnanceReplacementDate = value; }
    }
}
