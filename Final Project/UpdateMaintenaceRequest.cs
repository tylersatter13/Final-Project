﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Final_Project
{
    class UpdateMaintenaceRequest
    {
        private HouseSearch search = new HouseSearch();
        private Fetch fetch = new Fetch();
        private SearchMaintenanceRequests searchMain = new SearchMaintenanceRequests();
        private ValidationType validation = new ValidationType();
        public MaintenanceRequest MaintenaceRequestUpdate(MaintenanceRequest request)
        {
            UpdateMaintenanceRequest(request);
            return searchMain.searchByLastName(request.House.LeadTenant.TenantLast);
        }
        
        public void UpdatePart(MaintenancePart part, int MaintenaceRequestID)
        {
            String spName = "spUpdatePart";
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@PartID", part.PartID1);
            parameters.Add("@PartName", part.PartName1);
            parameters.Add("@fk_PartBrand", null);
            parameters.Add("@PartCost", part.PartCost1);
            parameters.Add("@PartPurchaseLocation", null);
            parameters.Add("@PartStockorCharge", part.InStock1);

            var results = fetch.fetchMaintenaceParts(parameters, spName);
            //return results[0];
        }
        private void UpdateMaintenanceRequest(MaintenanceRequest request)
        {
            String spName = "spUpdateMaintenaceRequest";
            DynamicParameters parameters = new DynamicParameters();
            var dateCheck = validation.getValidationDateTime();
            var KeyCheck = validation.getValidationInt();
            parameters.Add("@MaintenenceRequestID", request.MaintenenceRequestID1);
            parameters.Add("@fk_LeadTenantID ", KeyCheck.CheckNullForeignKey(request.House.LeadTenant.LeadTenantID1));
            parameters.Add("@fk_MaintenanceTechnician ", KeyCheck.CheckNullForeignKey(request.MaintenanceTechnician.MaintenanceTechnicianID1));
            parameters.Add("@MaintenenceRequestDate ", dateCheck.checkNullDate(request.DateCreated1));
            parameters.Add("@MaintenenceRequestDescription", request.Jobdescription.ToString());
            parameters.Add("@MaintenenceRequestWorkPerformed", request.WorkPerformed1.ToString());
            parameters.Add("@MaintenenceeRequestDateStarted ", dateCheck.checkNullDate(request.DateStarted1));
            parameters.Add("@MaintenenceRequestDateCompleted ", dateCheck.checkNullDate(request.DateCompleted1));
            parameters.Add("@MaintenenceRequestAppointmentDate ", dateCheck.checkNullDate(request.AppointmentDate1));
            parameters.Add("@MaintenenceRequestCompletionHousrs ", request.HoursWorked);
            parameters.Add("@fk_MaintenanceRequestTypeID ", KeyCheck.CheckNullForeignKey(request.RequestTypeID1));
            parameters.Add("@MaintenanceRequestCanEnter ", request.PermissionToEnter1);
            parameters.Add("@MaintenancRequesteIsAppliance", request.IsAppliance1);

            var results = fetch.fetchMaintenanceRequests(parameters, spName);
           // return results[0];
        }
    }
}