using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class HouseInterrior
    {
        private int HouseInteriorID;
        private int PrimaryPaintColorID;
        private String PrimaryPaintColor;
        private String PrimaryPaintColorCode;
        private int SecondaryPaintColorID;
        private String SecondaryPaintColor;
        private String SecondaryPiantColorCode;
        private DateTime LastPaintDate;
        private int CarpetColorID;
        private String CarpetColorName;
        private DateTime CarpetInstallDate;
        private int FermicaColorID;
        private String FermicaColorName;
        private int VynalColorID;
        private String VynalColorName;
        private int houseInteriorID1;

        private DateTime VandFInstall;
        private int StainID;
        private String StainColor;
        private DateTime Blindreplacement;
        public ValidationType validation = new ValidationType();

        public int HouseInteriorID2 { get => HouseInteriorID; set => HouseInteriorID = value; }
        public int PrimaryPaintColorID1 { get => PrimaryPaintColorID; set => PrimaryPaintColorID = value; }
        public string PrimaryPaintColor1 { get => PrimaryPaintColor; set => PrimaryPaintColor = value; }
        public string PrimaryPaintColorCode1 { get => PrimaryPaintColorCode; set => PrimaryPaintColorCode = value; }
        public int SecondaryPaintColorID1 { get => SecondaryPaintColorID; set => SecondaryPaintColorID = value; }
        public string SecondaryPaintColor1 { get => SecondaryPaintColor; set => SecondaryPaintColor = value; }
        public string SecondaryPiantColorCode1 { get => SecondaryPiantColorCode; set => SecondaryPiantColorCode = value; }
        public DateTime LastPaintDate1 { get => LastPaintDate; set => LastPaintDate = value; }
        public int CarpetColorID1 { get => CarpetColorID; set => CarpetColorID = value; }
        public string CarpetColorName1 { get => CarpetColorName; set => CarpetColorName = value; }
        public DateTime CarpetInstallDate1 { get => CarpetInstallDate; set => CarpetInstallDate = value; }
        public int FermicaColorID1 { get => FermicaColorID; set => FermicaColorID = value; }
        public string FermicaColorName1 { get => FermicaColorName; set => FermicaColorName = value; }
        public int VynalColorID1 { get => VynalColorID; set => VynalColorID = value; }
        public string VynalColorName1 { get => VynalColorName; set => VynalColorName = value; }
        public int HouseInteriorID1 { get => houseInteriorID1; set => houseInteriorID1 = value; }
        public DateTime VandFInstall1 { get => VandFInstall; set => VandFInstall = value; }
        public int StainID1 { get => StainID; set => StainID = value; }
        public string StainColor1 { get => StainColor; set => StainColor = value; }
        public DateTime Blindreplacement1 { get => Blindreplacement; set => Blindreplacement = value; }

        public HouseInterrior(int HouseInteriorID)
        {
            HouseInteriorID1 = HouseInteriorID;
        }
        public HouseInterrior(int PrimaryPaintColorID, String PrimaryPaintColor, String PrimaryPaintCode, int SecondaryPaintColorID, String SecondaryPiantColorCode,
     String SecondaryPaintColorCode, DateTime LastPaintDate, int CarpetColorID, String CarpetColorName, DateTime CarpetInstallDate, int FermicaColorID,
      String FermicaColorName, int VynalColorID, String VynalColorName, DateTime VandFInstall, int StainID, String StainColor, DateTime Blindreplacement)
        {
           this.LastPaintDate = LastPaintDate;
           this.PrimaryPaintColorID = PrimaryPaintColorID;
            this.PrimaryPaintColor = PrimaryPaintColor;
            PrimaryPaintColorCode1 = PrimaryPaintColorCode;
            this.SecondaryPaintColorID = SecondaryPaintColorID;
            SecondaryPaintColor1 = SecondaryPaintColor;
            this.SecondaryPiantColorCode = SecondaryPaintColorCode;
           this.CarpetColorID = CarpetColorID;
           this.CarpetColorName = CarpetColorName;
           this.CarpetInstallDate = CarpetInstallDate;
          this.FermicaColorID =  FermicaColorID;
          this.FermicaColorName =  FermicaColorName;
          this.VynalColorID =  VynalColorID;
          this.VynalColorName =  VynalColorName;
          this.VandFInstall =  VandFInstall;
            this.StainID = StainID;
            this.StainColor = StainColor;
           this.Blindreplacement1 = Blindreplacement;
        }
        public HouseInterrior(int HouseInteriorID, int PrimaryPaintColorID, String PrimaryPaintColor, String PrimaryPaintCode, int SecondaryPaintColorID, String SecondaryPiantColorCode,
            String SecondaryPaintColorCode, DateTime LastPaintDate, int CarpetColorID, String CarpetColorName, DateTime CarpetInstallDate, int FermicaColorID,
             String FermicaColorName, int VynalColorID, String VynalColorName, DateTime VandFInstall, int StainID, String StainColor, DateTime Blindreplacement)
        {
            this.HouseInteriorID1= HouseInteriorID;
            this.LastPaintDate = LastPaintDate;
            this.PrimaryPaintColorID = PrimaryPaintColorID;
            this.PrimaryPaintColor = PrimaryPaintColor;
            PrimaryPaintColorCode1 = PrimaryPaintColorCode;
            this.SecondaryPaintColorID = SecondaryPaintColorID;
            SecondaryPaintColor1 = SecondaryPaintColor;
            this.SecondaryPiantColorCode = SecondaryPaintColorCode;
            this.CarpetColorID = CarpetColorID;
            this.CarpetColorName = CarpetColorName;
            this.CarpetInstallDate = CarpetInstallDate;
            this.FermicaColorID = FermicaColorID;
            this.FermicaColorName = FermicaColorName;
            this.VynalColorID = VynalColorID;
            this.VynalColorName = VynalColorName;
            this.VandFInstall = VandFInstall;
            this.StainID = StainID;
            this.StainColor = StainColor;
            this.Blindreplacement1 = Blindreplacement;
        }
        //SETTERs 
        //On setters where there is a two variables the String is just the human representation of the value
        //The ID properties are the values that impact actual changes when storing data to the database.
     /*   public void setPrimaryColor(int PrimaryPaintColorID, String PrimaryPaintColor, String PrimaryPaintColorCode)
        {
            if (validateSetters(PrimaryPaintColorID, PrimaryPaintColor, PrimaryPaintColorCode) == false)
            {
                this.PrimaryPaintColor = PrimaryPaintColor;
                this.PrimaryPaintColorID = PrimaryPaintColorID;
                this.PrimaryPaintColorCode = PrimaryPaintColorCode;
            }
        }
        public void setSecondaryColor(int SecondaryPaintColorID, String SecondaryPaintColor, String SecondaryPiantColorCode)

        {
            if (validateSetters(SecondaryPaintColorID, SecondaryPaintColor, SecondaryPiantColorCode) == false)
            {
                this.SecondaryPaintColor = SecondaryPaintColor;
                this.SecondaryPaintColorID = SecondaryPaintColorID;
                this.SecondaryPiantColorCode = SecondaryPiantColorCode;
            }
        }
        public void setLastPaintDate(DateTime LastPaintDate)
        {
            this.LastPaintDate = LastPaintDate;
        }
        public void setCarpert(int CarpetColorID, String CarpetColorName)
        {
            if (validateSetters(CarpetColorID, CarpetColorName) == false)
            {
                this.CarpetColorID = CarpetColorID;
                this.CarpetColorName = CarpetColorName;
            }
        }
        public void setFermica(int FermicaColorID, String FermicaName)
        {
            if (validateSetters(FermicaColorID, FermicaColorName) == false)
            {
                this.FermicaColorID = FermicaColorID;
                this.FermicaColorName = FermicaColorName;
            }
        }
        public void setVynal(int VynalColorID, String VynalColorName)
        {
            if (validateSetters(VynalColorID, VynalColorName) == false)
            {
                this.VynalColorID = VynalColorID;
                this.VynalColorName = VynalColorName;
            }
        }
        public void setBlindReplacement(DateTime Blindreplacement)
        {
            if (validation.getValidationDateTime().fieldHasValue(Blindreplacement) == false)
            {
                this.Blindreplacement = Blindreplacement;
            }
        }
        public void setStain(int StainID, String StainColor)
        {
            if (validateSetters(StainID, StainColor) == false)
            {
                this.StainID = StainID;
                this.StainColor = StainColor;
            }
        }
        public void setVandFInstall(DateTime VandFInstall)
        {
            if (validation.getValidationDateTime().fieldHasValue(VandFInstall) == false)
            {
                this.VandFInstall = VandFInstall;
            }
        }
        public void setCarpetInstallDate(DateTime CarpetInstallDate)
        {
            if (validation.getValidationDateTime().fieldHasValue(CarpetInstallDate) == false)
            {
                this.CarpetInstallDate = CarpetInstallDate;
            }

        }*/
   
/*
        //Getters
        public int getPrimaryPaintColorID()
        {
            return PrimaryPaintColorID;
        }
        public String getPrimaryPaintColor()
        {
            return PrimaryPaintColor;
        }
        public int getSecondaryPaintColorID()
        {
            return SecondaryPaintColorID;
        }
        public String getSecondaryPaintColor()
        {
            return SecondaryPaintColor;
        }
        public int getHouseInterriorID()
        {
            return HouseInteriorID1;
        }
        public DateTime getLastPaintDate()
        {
            return LastPaintDate;
        }
        public int getCarpetColorID()
        {
            return CarpetColorID;
        }
        public String getCarpetColorName()
        {
            return CarpetColorName;
        }
        public int getFermicaColorID()
        {
            return FermicaColorID;
        }
        public int getVynalColorID()
        {
            return VynalColorID;
        }
        public String getVynalColorName()
        {
            return VynalColorName;
        }
        public int getStaindID()
        {
            return StainID;
        }
        public String getStainColor()
        {
            return StainColor;
        }
        public DateTime getCarpetInstallDate()
        {
            return CarpetInstallDate;
        }
        public DateTime getVandFInstallDate()
        {
            return VandFInstall;
        }
        public DateTime getBlindReplaceMent()
        {
            return Blindreplacement;
        }
        //Makes sure that both fields are not emply
        private bool validateSetters(int ID, String Name, String code)
        {
            if (validation.getValidationString().fieldHasValue(code) == false)
            {
                return validateSetters(ID, Name);
            }
            else
            {
                return false;
            }
        }
        private bool validateSetters(int ID, String Name)
        {
            if (validation.getValidationInt().fieldHasValue(ID) == false)
            {
                if (validation.getValidationString().fieldHasValue(Name) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }*/
    }
}
