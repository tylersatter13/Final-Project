using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
   public class MaintenanceRequest
    {
        private int MaintenenceRequestID;
        private bool IsAppliance;
        private bool PermissionToEnter;
        private DateTime DateCreated;
        private DateTime DateStarted;
        private DateTime DateCompleted;
        private DateTime AppointmentDate;
       // private int ApplianceType;
        private int Cats;
        private int Dogs;
        private StringBuilder jobdescription = new StringBuilder();
        private StringBuilder WorkPerformed = new StringBuilder();
        private int hoursWorked;
        private int RequestTypeID;
       /// private LeadTenant Tenant;
        private House house;
        private List<Appliance> appliances = new List<Appliance>();
        private List<MaintenancePart> parts = new List<MaintenancePart>();
        private MaintenanceTechnician maintenanceTechnician = new MaintenanceTechnician(0);
        public ValidationType validation = new ValidationType();

        public MaintenanceRequest(Int32 MaintenenceRequestID)
        {
            this.MaintenenceRequestID = MaintenenceRequestID;
            
        }
        public MaintenanceRequest(House House)
        {
            house = House.clone();
            MaintenanceTechnician = new MaintenanceTechnician(0);
            //house.LeadTenant = new LeadTenant(0,0);
        }
        public MaintenanceRequest(  Int32 maintenanceRequestID, Boolean isAppliance,  Boolean permissionToEnter, DateTime dateCreated,
            DateTime dateStarted,  DateTime dateCompleted, DateTime appointmentDate, /* Int32 Dogs, Int32 Cats,*/ String jobdescription, 
            String workPerformed ,  Int32 hoursWorked, Int32 requestTypeID )
        {
            MaintenenceRequestID1 = maintenanceRequestID;
            IsAppliance1 = isAppliance;
            PermissionToEnter1 = permissionToEnter;
            DateCreated1 = dateCreated;
            DateCompleted1 = dateCompleted;
            AppointmentDate1 = appointmentDate;
            //Cats1 = Cats;
           // Dogs1 = Dogs;
            Jobdescription.Append(jobdescription);
            WorkPerformed.Append(workPerformed);
                this.HoursWorked = hoursWorked;
            RequestTypeID1 = requestTypeID;

        }
        public void print()
        {
            Console.WriteLine($"MaintenaceRequestID:{MaintenenceRequestID} DateCreated:{DateCreated} " +
                $"DateStarted:{DateStarted} DateCompleted:{DateCompleted}");
        }
        public MaintenanceRequest clone()
        {
            return (MaintenanceRequest)this.MemberwiseClone();
        }
        public int MaintenenceRequestID1 { get => MaintenenceRequestID; set => MaintenenceRequestID = value; }
        public bool IsAppliance1 { get => IsAppliance; set => IsAppliance = value; }
        public bool PermissionToEnter1 { get => PermissionToEnter; set => PermissionToEnter = value; }
        public DateTime DateCreated1 { get => DateCreated; set => DateCreated = value; }
        public DateTime DateStarted1 { get => DateStarted; set => DateStarted = value; }
        public DateTime DateCompleted1 { get => DateCompleted; set => DateCompleted = value; }
        public DateTime AppointmentDate1 { get => AppointmentDate; set => AppointmentDate = value; }
   //     public int ApplianceType1 { get => ApplianceType; set => ApplianceType = value; }
        public int Cats1 { get => Cats; set => Cats = value; }
        public int Dogs1 { get => Dogs; set => Dogs = value; }
        public StringBuilder Jobdescription { get => jobdescription; set => jobdescription = value; }
        public StringBuilder WorkPerformed1 { get => WorkPerformed; set => WorkPerformed = value; }
     
        internal House House { get => house; set => house = value; }
        internal List<Appliance> Appliances { get => appliances; set => appliances = value; }
        internal List<MaintenancePart> Parts { get => parts; set => parts = value; }
        internal MaintenanceTechnician MaintenanceTechnician { get => maintenanceTechnician; set => maintenanceTechnician = value; }
        public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        public int RequestTypeID1 { get => RequestTypeID; set => RequestTypeID = value; }
    }
}
