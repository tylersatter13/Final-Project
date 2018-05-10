using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class ManageComboxLists
    {
        public List<String> GetStreet()
        { 
           return GetList("Street", "StreetName");
        }
        public List<String> GetOwners()
        {
           return GetList("Owner", "OwnerInitals");
        }
        public List<String> GetSQPlans()
        {
            return GetList("SQPlan", "SQPlanName");
        }
        public List<String> GetInterriorColors()
        {
            return GetList("InteriorColor", "InteriorColorName");
        }
        public List<String> GetVandFColors()
        {
            return GetList("VAndFColor", "VAndFColor");
        }
        public List<String> GetWoodWorkColors()
        {
            return GetList("Stain", "StainName");
        }
        public List<String> GetCarpetColor()
        {
            return GetList("Carpet", "CarpetName");
        }
        public List<String> GetList(String TableName, String FieldName)
        {
            DatabaseConnection<String> connection = new DatabaseConnection<String>();
            return connection.selectFormat(new[] { FieldName }, new String[0], TableName);
        }

    }
}
