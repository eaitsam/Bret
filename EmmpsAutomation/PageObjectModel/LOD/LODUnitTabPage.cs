using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODUnitTabPage
    {
        //-----------------------//
        //My LOD Unit Tab Objects
        //-----------------------//

        //--HTML Div--//
        public By LODUnitMenuDiv => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODUnitMenuDiv");
        public By LODUnitIncidenetDateHourValidMessage => By.Id("validationMessage0");
        public By LODUnitIncidenetCityMessage => By.Id("validationMessage2");
        public By LODUnitIncidenetRegionValidMessage => By.Id("validationMessage1");
        public By LODUnitPOCValidMessage => By.Id("validationMessage3");
        public By LODUnitDetailsOfAccidentValidMessage => By.Id("validationMessage6");
        public By LODUnitDateOfAbsenceFromBValidMessage => By.Id("validationMessage9");
        public By LODUnitDateOfAbsenceFromAValidMessage => By.Id("validationMessage10");
        public By LODUnitDateOfTrainingFromBValidMessage => By.Id("validationMessage11");
        public By LODUnitDateOfTrainingFromAValidMessage => By.Id("validationMessage12");
        public By LODUnitInjuryInLODValidMessage => By.Id("validationMessage13");
        public By LODUnitDutyStatusValidMessage => By.Id("validationMessage4");
        public By LODUnitIndivWasOnValidMessage => By.Id("validationMessage5");
        public By LODUnitDeathFromInjuriesReceivedValidMessage => By.Id("validationMessage14");
        public By LODUnitTODDutyStatusValidMessage => By.Id("validationMessage15");

        //--Html-Pane--//
        public By LODUnitTChactersRemainingPOC => By.Id("MEDCHARTContent_EmmpsContent_unitControl_PointOfContactTextBox_output");
        public By LODUnitTChactersRemainingDetailOfAccident => By.Id("MEDCHARTContent_EmmpsContent_unitControl_DetailsOfAccidentTextBox_output");

        //--HTMLEdit--//
        public By LODUnitIncidentDateTextBox => By.Id("MEDCHARTContent_EmmpsContent_unitControl_IncidentDateTextBox");
        public By LODUnitIncidentHourTextBox => By.Id("MEDCHARTContent_EmmpsContent_unitControl_IncidentHourTextBox");
        public By LODUnitIncidentCityTextBox => By.Id("MEDCHARTContent_EmmpsContent_unitControl_IncidentCityTextBox");
        public By LODUnitPOCInfoTextBox => By.Id("MEDCHARTContent_EmmpsContent_unitControl_PointOfContactTextBox");
        public By LODUnitDateofAbsenceAreaA => By.Id("MEDCHARTContent_EmmpsContent_unitControl_DateOfAbsenceTextBox");
        public By LODUnitHourofAbsenceAreaA => By.Id("MEDCHARTContent_EmmpsContent_unitControl_HourOfAbsenceTextBox");
        public By LODUnitDateofAbsenceAreaB => By.Id("MEDCHARTContent_EmmpsContent_unitControl_BDateTextBox");
        public By LODUnitHourofAbsenceAreaB => By.Id("MEDCHARTContent_EmmpsContent_unitControl_BHourTextBox");
        public By LODUnitDateofTrainingAreaA => By.Id("MEDCHARTContent_EmmpsContent_unitControl_TrainingDateBeganTextBox");
        public By LODUnitHourofTrainingAreaA => By.Id("MEDCHARTContent_EmmpsContent_unitControl_TrainingHourBeganTextBox");
        public By LODUnitDateofTrainingAreaB => By.Id("MEDCHARTContent_EmmpsContent_unitControl_TrainingDateEndedTextBox");
        public By LODUnitHourofTrainingAreaB => By.Id("MEDCHARTContent_EmmpsContent_unitControl_TrainingHourEndedTextBox");
        public By LODUnitHourBeginningTravel => By.Id("MEDCHARTContent_EmmpsContent_unitControl_HourBeginningTravelTextBox");
        public By LODUnitDistanceInvolved => By.Id("MEDCHARTContent_EmmpsContent_unitControl_DistanceInvolvedTextBox");
        public By LODUnitNormalTravelTime => By.Id("MEDCHARTContent_EmmpsContent_unitControl_NormalTimeForTravelTextBox");
        public By LODUnitDetailsOfAccident => By.Id("MEDCHARTContent_EmmpsContent_unitControl_DetailsOfAccidentTextBox");

        //--HTMLCombobox--//
        public By LODUnitIncidentRegion => By.Id("MEDCHARTContent_EmmpsContent_unitControl_IncidentRegionDropDownList");
        public By LODUnitDutyStatus => By.Id("MEDCHARTContent_EmmpsContent_unitControl_DutyStatusDropDownList");
        public By LODUnitIndivWasOn => By.Id("MEDCHARTContent_EmmpsContent_unitControl_IndividualWasOnDropDownList");
        public By LODUnitDiedOfInjuries => By.Id("MEDCHARTContent_EmmpsContent_ReservistDiedDropDownList");
        public By LODUnitTODDutyStatus => By.Id("MEDCHARTContent_EmmpsContent_DutyStatusDeathDropDownList");
        public By LODUnitModeTransporation => By.Id("MEDCHARTContent_EmmpsContent_unitControl_ModeOfTransportDropDownList");
        public By LODUniTReservistDiedOfInjuriesRecievedProceeding => By.Id("MEDCHARTContent_EmmpsContent_unitControl_ReservistDiedDropDownList");
        public By LODUnitDutyStatusAtTimeOfDeath => By.Id("MEDCHARTContent_EmmpsContent_unitControl_DutyStatusDeathDropDownList");


        //Radio Button
        public By LODUnitYesInjuryIncurredInLineOfDuty => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_unitControl_InjuryRadioButtonList\"]/tbody/tr/td[2]/label");
        public By LODUnitNoInjuryIncurredInLineOfDuty => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_unitControl_InjuryRadioButtonList\"]/tbody/tr/td[2]/label");
        public By LODUnitNoInjuryButtonId => By.Id("MEDCHARTContent_EmmpsContent_unitControl_InjuryRadioButtonList_1");


        public void VerifyDropDownListUnitTab()
        {

            //Verify dropdownlist
            //Assert.True(UIActions.ComboboxInnerTextValidator(LODUnitIncidentRegion, RegionStatesList));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODUnitDutyStatus, new List<string> { "-- Select --", "Present For Duty", "Absent Without Authority", "Absent With Authority", "On Pass", "On Leave" }));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODUnitIndivWasOn, new List<string> { "-- Select --", "Active Duty", "Active Duty For Training", "Inactive Duty Training" }));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODUnitModeTransporation, new List<string> { "-- Select --", "Commercial Plane", "Commercial Vehicle", "Government Vehicle", "Government Plane", "Privately Owned Vehicle", "Privately Owned Motorcycle", "Ticket Bus", "Ticket Plane" }));

        }

        public void VerifyNumericOnlyFieldsUnitTab()
        {

            string textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODUnitIncidentDateTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODUnitIncidentDateTextBox);
            Assert.False(textBoxValue.Length > 0, "Incident Date should not except alphanumeric data");


            textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODUnitIncidentHourTextBox, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODUnitIncidentHourTextBox);
            //Assert.False(textBoxValue.Length > 0, "Incident Hour should not except alphanumeric data ");

            textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODUnitDateofAbsenceAreaA, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODUnitDateofAbsenceAreaA);
            Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Absence To: Area A should not except alphanumeric data");

            //Time field change relook D Barr
            //textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODUnitHourofAbsenceAreaA, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODUnitHourofAbsenceAreaA);
            //Assert.False(textBoxValue.Length > 0, "LOD Unit Hour of Absence To: Area A should not except alphanumeric data ");


            textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODUnitDateofAbsenceAreaB, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODUnitDateofAbsenceAreaB);
            Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Absence To: Area B should not except alphanumeric data");

            //textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODUnitHourofAbsenceAreaB, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODUnitHourofAbsenceAreaB);
            //Assert.False(textBoxValue.Length > 0, "LOD Unit Hour of Absence To: Area B should not except alphanumeric data ");

            textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODUnitDateofTrainingAreaA, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODUnitDateofTrainingAreaA);
            Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Training To: Area A should not except alphanumeric data");

            //textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODUnitHourofTrainingAreaA, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODUnitHourofTrainingAreaA);
            //Assert.False(textBoxValue.Length > 0, "LOD Unit Hour of Training To: Area A should not except alphanumeric data ");

            textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODUnitDateofTrainingAreaB, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODUnitDateofTrainingAreaB);
            Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Training To: Area B should not except alphanumeric data");

            //textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODUnitHourofTrainingAreaB, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODUnitHourofTrainingAreaB);
            //Assert.False(textBoxValue.Length > 0, "LOD Unit Hour of Training To: Area B should not except alphanumeric data ");


        }

        #region EMMPS Dataseed Workflow methods
        public void UpdateRequiredFieldsUnitTab(string IncidentDate, string IncidentCity, string IncidentRegion, string IncidentPOC, string DutyStatus, string IndivWasOn, string Details)
        {
            WaitMethods.Wait(LODUnitIncidentCityTextBox, 120);
            UIActions.JSEnterText(LODUnitIncidentCityTextBox, IncidentCity);
            UIActions.SelectElementByText(LODUnitIncidentRegion, IncidentRegion);
            UIActions.JSEnterText(LODUnitIncidentDateTextBox, (UIActions.SelectDate(Convert.ToInt32(IncidentDate)) + " 0000"));
            //UIActions.TypeInTextBox(LODUnitIncidentHourTextBox , "0900");
            UIActions.SelectElementByText(LODUnitDutyStatus, DutyStatus);
            UIActions.TypeInTextBox(LODUnitPOCInfoTextBox, IncidentPOC);
            UIActions.SelectElementByText(LODUnitIndivWasOn, IndivWasOn);
            UIActions.TypeInTextBox(LODUnitDetailsOfAccident, Details);
            UIActions.TypeInTextBox(LODUnitDistanceInvolved, "25");

        }

        public void UpdateUnitTabInjuryIncurredLineOfDuty(string lineOfDutyInjury)
        {

            if (lineOfDutyInjury == "Yes")
            {
                UIActions.ClickElement(LODUnitYesInjuryIncurredInLineOfDuty);
            }
            else
            {
                UIActions.ClickElement(LODUnitNoInjuryIncurredInLineOfDuty);
            }

        }

        public void UpdateUnitTabDutyStatusAtTimeOfDeath(string statusAtDeath)
        {
            UIActions.SelectElementByText(LODUnitDutyStatusAtTimeOfDeath, statusAtDeath);

        }
        public void UpdateUnitTabReservistDiedOfInjuriesRecievedProceeding(string injuriesRecieved)
        {
            UIActions.SelectElementByText(LODUniTReservistDiedOfInjuriesRecievedProceeding, injuriesRecieved);

        }

        #endregion

        public void VerifyValidations()
        {
            UIActions.GetElement(LODUnitIncidenetDateHourValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIncidenetDateHourValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODUnitIncidentDateTextBox, (UIActions.SelectDate(Convert.ToInt32(-190)) + " 0000"));
            ObjectRepository.Driver.FindElements(LODUnitIncidenetDateHourValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitIncidenetCityMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIncidenetCityMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODUnitIncidentCityTextBox, "SomeWhere");
            ObjectRepository.Driver.FindElements(LODUnitIncidenetCityMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitIncidenetRegionValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIncidenetRegionValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODUnitIncidentRegion, "Ohio");
            ObjectRepository.Driver.FindElements(LODUnitIncidenetRegionValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitDutyStatusValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDutyStatusValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODUnitDutyStatus, "Present For Duty");
            ObjectRepository.Driver.FindElements(LODUnitDutyStatusValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitPOCValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitPOCValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBox(LODUnitPOCInfoTextBox, "Self");
            ObjectRepository.Driver.FindElements(LODUnitPOCValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitIndivWasOnValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIndivWasOnValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODUnitIndivWasOn, "Active Duty");
            ObjectRepository.Driver.FindElements(LODUnitIndivWasOnValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitDetailsOfAccidentValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDetailsOfAccidentValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBox(LODUnitDetailsOfAccident, "Automation Test");
            ObjectRepository.Driver.FindElements(LODUnitDetailsOfAccidentValidMessage).Count.Should().Be(0);
        }

        public void VerifyFormalValidations()
        {
            UIActions.GetElement(LODUnitIncidenetDateHourValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIncidenetDateHourValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODUnitIncidentDateTextBox, (UIActions.SelectDate(Convert.ToInt32(-1)) + " 0000"));
            ObjectRepository.Driver.FindElements(LODUnitIncidenetDateHourValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitIncidenetCityMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIncidenetCityMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODUnitIncidentCityTextBox, "SomeWhere");
            ObjectRepository.Driver.FindElements(LODUnitIncidenetCityMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitIncidenetRegionValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIncidenetRegionValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODUnitIncidentRegion, "Ohio");
            ObjectRepository.Driver.FindElements(LODUnitIncidenetRegionValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitDutyStatusValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDutyStatusValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODUnitDutyStatus, "Present For Duty");
            ObjectRepository.Driver.FindElements(LODUnitDutyStatusValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitPOCValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitPOCValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBox(LODUnitPOCInfoTextBox, "Self");
            ObjectRepository.Driver.FindElements(LODUnitPOCValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitIndivWasOnValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitIndivWasOnValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODUnitIndivWasOn, "Active Duty");
            ObjectRepository.Driver.FindElements(LODUnitIndivWasOnValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitDetailsOfAccidentValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDetailsOfAccidentValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBox(LODUnitDetailsOfAccident, "Automation Test");
            ObjectRepository.Driver.FindElements(LODUnitDetailsOfAccidentValidMessage).Count.Should().Be(0);

            UIActions.GetElement(LODUnitInjuryInLODValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitInjuryInLODValidMessage).Text.Should().BeEquivalentTo("Required");
            UIActions.ClickElement(LODUnitYesInjuryIncurredInLineOfDuty);
            ObjectRepository.Driver.FindElements(LODUnitInjuryInLODValidMessage).Count.Should().Be(0);

            UIActions.TypeInTextBoxAndEnter(LODUnitDateofAbsenceAreaA, (UIActions.SelectDate(Convert.ToInt32(-2)) + " 0000"));
            UIActions.TypeInTextBoxAndEnter(LODUnitDateofAbsenceAreaB, (UIActions.SelectDate(Convert.ToInt32(-3)) + " 0000"));
            UIActions.GetElement(LODUnitDateOfAbsenceFromBValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDateOfAbsenceFromBValidMessage).Text.Should().BeEquivalentTo("Absence To Date must be after the Incident Date.");
            UIActions.GetElement(LODUnitDateOfAbsenceFromAValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDateOfAbsenceFromAValidMessage).Text.Should().BeEquivalentTo("Absence To Date must be after the Absence From Date.");
            UIActions.ClearTextBox(LODUnitDateofAbsenceAreaB);
            UIActions.TypeInTextBoxAndEnter(LODUnitDateofAbsenceAreaB, (UIActions.SelectDate(Convert.ToInt32(0)) + " 0000"));
            ObjectRepository.Driver.FindElements(LODUnitDateOfAbsenceFromBValidMessage).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODUnitDateOfAbsenceFromAValidMessage).Count.Should().Be(0);

            UIActions.TypeInTextBoxAndEnter(LODUnitDateofTrainingAreaA, (UIActions.SelectDate(Convert.ToInt32(-2)) + " 0000"));
            UIActions.TypeInTextBoxAndEnter(LODUnitDateofTrainingAreaB, (UIActions.SelectDate(Convert.ToInt32(-3)) + " 0000"));
            UIActions.GetElement(LODUnitDateOfTrainingFromBValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDateOfTrainingFromBValidMessage).Text.Should().BeEquivalentTo("Training End Date must be after the Incident Date.");
            UIActions.GetElement(LODUnitDateOfTrainingFromAValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODUnitDateOfTrainingFromAValidMessage).Text.Should().BeEquivalentTo("Training End Date must be after the Training Begin Date.");
            UIActions.ClearTextBox(LODUnitDateofTrainingAreaB);
            UIActions.TypeInTextBoxAndEnter(LODUnitDateofTrainingAreaB, (UIActions.SelectDate(Convert.ToInt32(0)) + " 0000"));
            ObjectRepository.Driver.FindElements(LODUnitDateOfTrainingFromBValidMessage).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODUnitDateOfTrainingFromAValidMessage).Count.Should().Be(0);
        }
    }
}
