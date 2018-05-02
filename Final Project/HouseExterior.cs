using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class HouseExterior
    {
        private int HouseExteriorID;
        private int SidingID;
        private String SidingName;
        private int ExteriorColorID;
        private String ExteriorColor;
        private String ExteriorColorCode;
        private DateTime ExteriorPaintDate;
        private int TrimID;
        private String Trim;
        private int RoofMaterialID;
        private String RoofMaterial;
        private int RoofColorID;
        private String RoofColorName;
        private DateTime RoofInstall;

        public HouseExterior(Int32 houseExteriorID, Int32 sidingID, String sidingName, Int32 exteriorColorID, String exteriorColor,String exteriorColorCode, DateTime exteriorPaintDate, Int32 trimID,String trim, Int32 roofMaterialID,String roofMaterial, Int32 roofColorID, String roofColorName, DateTime roofInstall)
        {
            HouseExteriorID1 = houseExteriorID;
            SidingID1 = sidingID;
            SidingName1 = sidingName;
            ExteriorColorID1 = exteriorColorID;
            ExteriorColor1 = exteriorColor;
            ExteriorPaintDate1 = exteriorPaintDate;
            TrimID1 = trimID;
            Trim1 = trim;
            RoofMaterialID1 = roofMaterialID;
            RoofMaterial1 = roofMaterial;
            RoofInstall1 = roofInstall;
            RoofColorID = roofColorID;
            RoofColorName = roofColorName;
        }

        public int HouseExteriorID1 { get => HouseExteriorID; set => HouseExteriorID = value; }
        public int SidingID1 { get => SidingID; set => SidingID = value; }
        public string SidingName1 { get => SidingName; set => SidingName = value; }
        public int ExteriorColorID1 { get => ExteriorColorID; set => ExteriorColorID = value; }
        public string ExteriorColor1 { get => ExteriorColor; set => ExteriorColor = value; }
        public DateTime ExteriorPaintDate1 { get => ExteriorPaintDate; set => ExteriorPaintDate = value; }
        public int TrimID1 { get => TrimID; set => TrimID = value; }
        public string Trim1 { get => Trim; set => Trim = value; }
        public int RoofMaterialID1 { get => RoofMaterialID; set => RoofMaterialID = value; }
        public string RoofMaterial1 { get => RoofMaterial; set => RoofMaterial = value; }
        public DateTime RoofInstall1 { get => RoofInstall; set => RoofInstall = value; }
    }
}
