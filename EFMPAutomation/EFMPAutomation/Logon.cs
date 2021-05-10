using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;
using FluentAssertions;
using OpenQA.Selenium;
using System.Linq;
using MedchartSeleniumAutomationCore.Core_Framework;
using System;
using EFMPAutomation.PageObjectModel;

namespace EFMPAutomation
{
    public class Logon
    {

        private readonly Configurations _config;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;
        private readonly SplashPage _splashPage;
        private readonly LogonPage _logonPage;
        private const string ediLoginAuthorized = "1234567890";
        private readonly TopMenuItems _homepage;
        


        public Logon()
        {
            _config = new Configurations();
            _webDriver = new BaseDriverInit();
            _splashPage = new SplashPage();
            _logonPage = new LogonPage();
            _homepage = new TopMenuItems();
            _webSiteUrl = _config.GetConfigValue("EFMPWebsiteUrl");




        }


        [Fact]
        public void EFMPLogon()
        {

            try
            {
                DebuggingHelpers.Logger().Info(" EFMP Splash Page ");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                DebuggingHelpers.Logger().Info("CAC Button is displayed");

                WaitMethods.Wait(_splashPage.CacLoginButton, 5);


                DebuggingHelpers.Logger().Info("Test Body Text EFMP Splash Page");

                _splashPage.GetBodyText().Should().Contain(_splashPage.BodyTextActual);

                DebuggingHelpers.Logger().Info("Clicked CAC Button");

                _splashPage.ClickCacButton();

                DebuggingHelpers.Logger().Info("Enter EDI and submit");

                _logonPage.EnterEdiAndSubmit(ediLoginAuthorized);

                _homepage.GetBodyText().Should().Contain(_homepage.BodyTextActual);

              

                
            }
            catch (Exception ex)
            {
                DebuggingHelpers.Logger().Error("Error: " + ex.Message);

                DebuggingHelpers.Logger().Info(" *** Test ended with an error ***");
            }

            finally
            {
                _webDriver.TearDown();
                _webDriver.Dispose();
                DebuggingHelpers.Logger().Info("Teardown and Dispose");
            }


        }
    }
}









