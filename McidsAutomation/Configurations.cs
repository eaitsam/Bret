using Microsoft.Extensions.Configuration;

namespace McidsAutomation
{
    public class Configurations
    {
        private readonly IConfiguration _config;

        public Configurations()
        {
            _config = InitConfiguration();
        }

        public IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            return config;
        }

        public string GetConfigValue(string configName)
        {
            return _config[configName];
        }

    }
}
