using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class GatewayApiPage
    {
        private readonly string _clientId;

        public GatewayApiPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By WeatherApiLink => By.Id("callGatewayLink");
        private By WeatherApiPageHeading => By.Id("weatherApiPageHeading");
        private By WeatherApiResults => By.Id("weatherApiResults");

        #endregion By Elements

        #region String Elements

        public string WeatherApiPageHeadingActual => "Call Api WeatherForecast Service - " + _clientId;
        public string AccessDeniedMessageActual => "Access Denied - No Access Token.";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void ClickWeatherApiLink() => UIActions.ClickElement(WeatherApiLink);

        public string GetWeatherApiPageHeading() => UIActions.GetElement(WeatherApiPageHeading).Text;

        public string GetWeatherApiResults() => UIActions.GetElement(WeatherApiResults).Text;

        #endregion Page Methods
    }
}