using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMPAutomation
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





