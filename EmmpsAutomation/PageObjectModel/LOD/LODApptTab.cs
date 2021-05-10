using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODApptTab
    {
        #region My LOD Appointment Tab Objects
        //------------------------------//
        //My LOD Appointment Tab Objects
        //------------------------------//
        public By LODAppointmentValidationMess => By.Id("validationMessage0");
        public By LODAppointmentIntermediateCommandDropDownList => By.Id("MEDCHARTContent_EmmpsContent_appointmentControl_SelectDropDownList");
        public By LODAppointmentIntermediateCommandSelectButton => By.Id("MEDCHARTContent_EmmpsContent_appointmentControl_SelectButton");
        public By LODAppointmentInvestigationOfficerDropDownList => By.Id("MEDCHARTContent_EmmpsContent_appointmentControl_SelectOfficerDropDownList");
        public By LODAppointmentInvestigationOfficerSelectButton => By.Id("MEDCHARTContent_EmmpsContent_appointmentControl_SelectOfficerButton");

        public By ChangeButton => By.Id("MEDCHARTContent_EmmpsContent_appointmentControl_ChangeButton");
        public By ChangeOfficerButton => By.Id("MEDCHARTContent_EmmpsContent_appointmentControl_ChangeOfficerButton");


        #endregion


    }
}
