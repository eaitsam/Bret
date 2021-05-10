using EFMPAutomation.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;
using FluentAssertions;

namespace EFMPAutomation
{
    public class LogOut
    {
        private readonly BaseDriverInit _webDriver;
        private readonly Configurations _config;
        private readonly TopMenuItems _homepage;
        private readonly LogonPage _LogonPage;
        private readonly SplashPage _splashPage;
        private readonly string _webSiteUrl;
        private const string ediLoginAuthorized = "1234567890";
        
       

        public LogOut()
        {
            _config = new Configurations();
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("EFMPWebsiteUrl");
            _splashPage = new SplashPage();
            _LogonPage = new LogonPage();
            _homepage = new TopMenuItems();

        }

        [Fact]
        
        
        public void EFMPLogout()
        {
            try
            {
                DebuggingHelpers.Logger().Info("EFMP LOGGING OUT SPLASH PAGE ");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);
                
                DebuggingHelpers.Logger().Info("CAC Button is displayed");
                WaitMethods.Wait(_splashPage.CacLoginButton, 5);


                DebuggingHelpers.Logger().Info("Test Body Text EFMP HomePage");
                _splashPage.GetBodyText().Should().Contain(_splashPage.BodyTextActual);

                DebuggingHelpers.Logger().Info("Clicked CAC Button");
                    _splashPage.ClickCacButton();

                DebuggingHelpers.Logger().Info("Enter EDI and submit");

                _LogonPage.EnterEdiAndSubmit(ediLoginAuthorized);

                _homepage.GetBodyText().Should().Contain(_homepage.BodyTextActual);
           
                catch (Exception ex)
            {
                DebuggingHelpers.Logger().Error("Error: " + ex.Message);

                DebuggingHelpers.Logger().Info(" *** Test ended with an error ***");
            }

            finally
            {
                _webDriver.TearDown();
                _webDriver.Dispose();
            }






        }
    }
}



