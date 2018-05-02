using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Fetch
    {
        private DatabaseConnection<User> userFetch = new DatabaseConnection<User>();
        private DatabaseConnection<TenantTransaction> transactionFetch = new DatabaseConnection<TenantTransaction>();
        private DatabaseConnection<Tenant> tenantFetch = new DatabaseConnection<Tenant>();
        private DatabaseConnection<LeadTenant> leadTennantFetcH = new DatabaseConnection<LeadTenant>();
        private DatabaseConnection<House> houseFetch = new DatabaseConnection<House>();
        private DatabaseConnection<HouseInterrior> houseIntFetch = new DatabaseConnection<HouseInterrior>();
        private DatabaseConnection<HouseExterior> houseExterFetch = new DatabaseConnection<HouseExterior>();
        private DatabaseConnection<HouseAppliances> houseApplianceFetch = new DatabaseConnection<HouseAppliances>();
        private DatabaseConnection<Appliance> applianceFetch = new DatabaseConnection<Appliance>();
        private DatabaseConnection<HouseExteriorFeatures> fetchHouseExtFeature = new DatabaseConnection<HouseExteriorFeatures>();
        private DatabaseConnection<HouseInterriorFeatures> fetchInterriorFeatures = new DatabaseConnection<HouseInterriorFeatures>();
        private DatabaseConnection<Owner> fetchOwner = new DatabaseConnection<Owner>();
        public List<Owner> fetchHouseOwner(int HouseID)
        {
            return fetchOwner.selectFormat(new[] { "*" }, new[] { $"OwnerID = (SELECT fk_Owner FROM House WHERE HouseID = {HouseID})" }, "Owner");
        }
        public List<User> fetchUserInformation(String username, String password)
        {
            return userFetch.selectFormat(new[] { "UserName", "UserRoleID" }, new[] { $"UserName='{username}' AND UserPassword ='{password}'" }, "Users");
        }
        public List<House> fetchHouseInformationByLast(String LastName)
        {
            return houseFetch.selectFormat(new[] { "HouseID", "HouseNumber", "fk_Street", "StreetName", "fk_SQPlan", "S3.SQPlanName" },
                new[] { $"fk_LeadTenant = ( SELECT LeadTenantID FROM  LeadTenant l LEFT JOIN  Tenant t ON l.fk_TennantID = t.TenantID WHERE t.TenantLast = '{LastName}')" },
                " House INNER JOIN Street S2 on House.fk_Street = S2.StreetID INNER JOIN SQPlan S3 on House.fk_SQPlan = S3.SQPlanID   INNER JOIN  Owner O on House.fk_Owner = O.OwnerID");
        }
        public List<House> fetchHouseInformationByHouseNum(String HouseNumber)
        {
            return houseFetch.selectFormat(new[] {"HouseID", "HouseNumber", "fk_Street","StreetName","fk_SQPlan","S3.SQPlanName"},new[] { $"HouseNumber={HouseNumber}" },
                " House INNER JOIN Street S2 on House.fk_Street = S2.StreetID INNER JOIN SQPlan S3 on House.fk_SQPlan = S3.SQPlanID   INNER JOIN  Owner O on House.fk_Owner = O.OwnerID");
        }
        public List<HouseInterrior> fetchHouseInterrior(int HouseID)
        {
            String from = "HouseInterior Left JOIN InteriorColor IC on HouseInterior.fk_PrimaryColorID = IC.InteriorColorID LEFT JOIN InteriorColor IC2 on HouseInterior.fk_SecondaryColorID = IC2.InteriorColorID" +
                " Left JOIN Carpet C on HouseInterior.fk_CarpetColorID = C.CarpetID Left JOIN VAndFColor VAFC on HouseInterior.fk_FermicaColorID = VAFC.VAndFID Left JOIN VAndFColor C2 on HouseInterior.fk_VynlColorID = C2.VAndFID" +
                " left JOIN Stain S2 on HouseInterior.fk_StainID = S2.StainID";

            return houseIntFetch.selectFormat(new[] { "HouseInteriorID", "fk_PrimaryColorID as PrimaryPaintColorID",
                "IC.InteriorColorName as PrimaryPaintColor ", "IC.InteriorColorCode as PrimaryPaintCode","fk_SecondaryColorID as SecondaryPaintColorID ","" +
                "IC2.InteriorColorName as SecondaryPiantColorCode","IC2.InteriorColorCode as SecondaryPaintColorCode",
                "HouseLastPaintDate as  LastPaintDate","C.CarpetID as CarpetColorID ","C.CarpetName as CarpetColorName",
                "HouseInteriorCarpetDate as CarpetInstallDate", "VAFC.VAndFID as FermicaColorID","VAFC.VAndFColor as FermicaColorName",
                "C2.VAndFID as VynalColorID ",
                "C2.VAndFColor as VynalColorName ","HouseInteriorVFInstall as VandFInstall",
                "S2.StainID as StainID ","S2.StainName as StainColor","HouseBlindReplacement as Blindreplacement"},
                new[] { $"HouseInteriorID = (SELECT  fk_HouseInterriorID FROM House WHERE HouseID = {HouseID}) " }, from);
        }
        public List<HouseInterriorFeatures> fetchHouseInterriorFeatures(int HouseID)
        {
            return fetchInterriorFeatures.selectFormat(new[] { "InteriorFeaturesID as houseInterriorFeaturesID",
                "InterriorFeaturesHallShowerDate as  hallShowerReplacementDate" ,
                "InterriorFeaturesWaterHeaterDate as waterHeaterReplacementDate",
                "InterriorFeaturesCelingFanDate as cielingFanReplacementDate",
                "InterriorFeaturesFurnanceReplacement as furnanceReplacementDate"},
                new[] { $"InteriorFeaturesID = (SELECT fk_InterriorFeaturesID FROM House WHERE HouseID = {HouseID})" }, "InteriorFeatures");
        }
        public List<HouseExterior> HouseExteriors(int HouseID)
        {
            String form = "HouseExterior LEFT JOIN Siding S2 on HouseExterior.fk_SidingID = S2.SidingID LEFT JOIN ExteriorColor E on HouseExterior.fk_ExteriorColorID" +
                " = E.ExteriorColorID LEFT JOIN TrimColor Color on HouseExterior.fk_TrimID = Color.TrimID LEFT JOIN RoofMaterial on HouseExterior.fk_RoofMaterialID =" +
                " RoofMaterial.RoofMaterialID LEFT JOIN RoofColor R on HouseExterior.fk_RoofColorID = R.RoofColorID";
            return houseExterFetch.selectFormat(new[] { "HouseExteriorID as houseExteriorID "," fk_SidingID as sidingID "," SidngType as sidingName ",
                   " ExteriorColorID as   exteriorColorID "," E.ExteriorColorName as   exteriorColor "," E.ExteriorColorCode as exteriorColorCode ",
                   "HouseExteriorPaintDate as   exteriorPaintDate "," fk_TrimID as  trimID ","  Color.TrimColor as  trim ","  fk_RoofMaterialID as   roofMaterialID ",
                   "  RoofMaterial.RoofMaterialName as   roofMaterial "," RoofColorID as roofColorID "," RoofColorName as  roofColorName ",
                   " HouseExteriorRoofInstall as roofInstall"}, new[] {$"HouseExteriorID = (SELECT  fk_HouseExteriorID" +
                   $"  FROM House WHERE HouseID = {HouseID})" }, form);
        }
        public List<HouseExteriorFeatures> fetchHouseExteriorFeatures(int HouseID)
        {
            return fetchHouseExtFeature.selectFormat(new[] { "ExteriorFeaturesID as exteriorFeaturesID","ExteriorFenece as fenceReplacement",
                "ExteriorGutterReplacement  as gutterReplacemengt" , "ExteriorGarageDoor  as grageDoorReplacement",
                "ExteriorDriveWay as drivewayReplacemnt", "ExteriorChimney as chimneyReplacement"},
                new[] { $"ExteriorFeaturesID = (SELECT fk_ExterriorFeaturesID FROM House WHERE HouseID = {HouseID})" }, "ExteriorFeatures" );
        }
        public List<HouseAppliances> fetchHouseAppliances(int HouseID)
        {
            var results = houseApplianceFetch.selectFormat(new[]{ "HouseApplianceID as houseApplianceID","HouseApplianceWHDate as lastWaterHeaterReplacement",
                "HouseApplianceGDDate as lastGarbageDisposalReplacement", "HouseApplianceHasRefer as hasRef"}, new[] 
                { $"HouseApplianceID = (SELECT fk_HouseAppliancesID  FROM House WHERE HouseID = {HouseID})" }, "HouseAppliances");

            var applianceID = results[0].HouseApplianceID1;
            var Dishwasher = applianceFetch.selectFormat(new[] { " DishwasherID AS applianceID ","DishwasherBrand AS brand","DishwasherColor AS color","DishwasherModel as model",
                "DishwasherSerial AS serialNumber","DishwasherPurchaseDate AS lastReplacementDate" }, new[] { $"DishwasherID = (SELECT DishwasherID FROM dbo.HouseAppliances WHERE HouseApplianceID = {applianceID})" }, "Dishwasher");
            results[0].Dishwasher1 = Dishwasher[0];

            var Range = applianceFetch.selectFormat(new[] { "RangeID AS  applianceID" ,"RangeBrand AS brand","RangeColor AS color","RangeModel AS model",
                "RangeSerial AS serialNumber","RangeReplaceDate AS lastReplacementDate"}, new[] { $"RangeID = (SELECT RangeID FROM HouseAppliances WHERE HouseApplianceID ={applianceID} )" }, "CookingRange");
            results[0].Range1 = Range[0];

            return results;
        }
        
    }
}
