using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class MaintenanceTechnician
    {
        private int MaintenanceTechnicianID;
        private String FirstName;
        private String LastName;

        public MaintenanceTechnician(Int32 maintenanceTechnicianID)
        {
            MaintenanceTechnicianID = maintenanceTechnicianID;
            
        }
        public MaintenanceTechnician(Int32 maintenanceTechnicianID, String firstName, String lastName)
        {
            MaintenanceTechnicianID = maintenanceTechnicianID;
            FirstName = firstName;
            LastName = lastName;
        }

        public int MaintenanceTechnicianID1 { get => MaintenanceTechnicianID; set => MaintenanceTechnicianID = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
    }
}
