using FluentAssertions;
using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Registration
{
    public class UserRegistration
    {
        BaseDriverInit _driverInit;
        Login _login;
        RegistrationPage _reg;


        public UserRegistration()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _reg = new RegistrationPage();
        }


        [Fact]
        public void RegistrationPageValidation()
        {
            try
            {

                //Notes on this test: Doesnt account for waht happens when the test already runs and the registration form has been submitted
                // How is this hardcoded EDIPIN decided? Does it ever go into the database? Because if it does, then that renders this test useless
                _driverInit.InitWebdriver();
                _login.LoginMethod("1232343456");

                WaitMethods.Wait(_reg.CancelButton, 60);

                //validate that all the req fields are correct

                UIActions.ClickElement(_reg.CancelButton);
                //validate that you are indeed at the home page

                _login.LoginMethod("1232343456");
                UIActions.ClickElement(_reg.NextButton);

                //For this method the required field needs to be filled,
                //and then click the Next button for the next error to display
                WaitMethods.Wait(_reg.RankValidator, 60);

                //Rank
                Assert.True(UIActions.GetElement(_reg.RankValidator).Displayed);
                UIActions.SelectElementByText(_reg.RankCombobox, "CIV");

                //First Name
                Assert.True(UIActions.GetElement(_reg.FirstNameValidator).Displayed);
                UIActions.GetElement(_reg.FirstNameTextbox).SendKeys("TestFirstName");

                //Email
                UIActions.ClickElement(_reg.NextButton);
                UIActions.GetElement(_reg.EmailValidator).Displayed.Should().BeTrue();
                UIActions.GetElement(_reg.EmailTextbox).SendKeys("TestEmail@mail.mil");

                //Last Name
                UIActions.ClickElement(_reg.NextButton);
                UIActions.GetElement(_reg.LastNameValidator).Displayed.Should().BeTrue();
                UIActions.GetElement(_reg.LastNameTextbox).SendKeys("TestLastName");

                //Primary Phone
                UIActions.ClickElement(_reg.NextButton);
                UIActions.GetElement(_reg.PhoneValidator).Displayed.Should().BeTrue();
                UIActions.GetElement(_reg.PrimaryPhoneTextbox).SendKeys("5555555555");

                //Role Validation
                UIActions.ClickElement(_reg.NextButton);
                UIActions.GetElement(_reg.RoleSelectedValidator).Displayed.Should().BeTrue();

            }
            finally
            {

                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NewUserRegistration()
        {
            try
            {
                //Scenario: Submission is Successful
                //Given I am Logged in as A_New_User using EDIPIN 1232343458
                //When I fill in all of the required fields and submit
                //Then The submission is successful
                _driverInit.InitWebdriver();
                _login.LoginMethod("1232343456");
                WaitMethods.Wait(_reg.NextButton, 60);

                UIActions.JSEnterText(_reg.FirstNameTextbox, "Register");
                UIActions.JSEnterText(_reg.MiddleNameTextbox, "New");
                UIActions.JSEnterText(_reg.LastNameTextbox, "User");
                UIActions.JSEnterText(_reg.PrimaryPhoneTextbox, "7036450420");
                UIActions.JSEnterText(_reg.PrimaryPhoneExtensionTextbox, "12345");
                UIActions.JSEnterText(_reg.EmailTextbox, "testregisteruser@mail.mil");
                UIActions.JSEnterText(_reg.DSNTextbox, "0240546207");
                UIActions.JSEnterText(_reg.SecondaryPhoneTextbox, "7036450420");
                UIActions.JSEnterText(_reg.SecondaryPhoneExtensionTextbox, "54321");
                UIActions.SelectElementByText(_reg.RankCombobox, "CIV");

                //Select Module and Organization
                UIActions.GetElement(_reg.AVSModuleTab).Click();
                UIActions.SelectElementByText(_reg.AVSOrganizationCombobox, "National Guard");

                //Select Region
                WaitMethods.Wait(_reg.AVSRegionCombobox, 60);
                UIActions.SelectElementByText(_reg.AVSRegionCombobox, "Virginia");

                //Select Role
                _reg.AVSChooseRoleCheckbox("ARNG Approval Authority");

                //Click Next and Submit
                WaitMethods.Wait(_reg.NextButton, 60);
                UIActions.ClickElement(_reg.NextButton);
                UIActions.ClickElement(_reg.SubmitButton);

                //Upload Hipaa
                UIActions.ClickElement(_reg.UploadExistingCertificateLink);
                DocumentUpload.UploadFile(_reg.ChooseFileButton, DocumentUpload.TESTFILE);
                UIActions.ClickElement(DocumentUpload.FileUploadButton);

                //Another Step here???

                WaitMethods.Wait(_reg.FeedbackSuccess, 60);
                UIActions.GetElement(_reg.FeedbackSuccess).Text.Should().BeEquivalentTo("Your HIPAA Certificate was successfully uploaded, and now is pending approval.");

            }
            finally
            {

                _driverInit.TearDown();
            }
        }

    }
}
