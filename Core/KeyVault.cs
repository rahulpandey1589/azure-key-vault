using Core.Common;
using Core.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Core
{
    public static class KeyVault
    {
        private static IConfiguration configuration;

        static KeyVault()
        {
            LoadConfiguration();
        }

        private static void LoadConfiguration()
        {
            if(configuration is null)
            {
                var builder = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                configuration = builder.Build();
            }
        }

        public static void GetSecret(EnvironmentEnum environment, string secretName)
        {
            var keyVaultDetails
                 = GetVaultDetails(environment);
        }


        private static KeyVaultDetailModel GetVaultDetails(EnvironmentEnum environment)
        {
            var keyVaultCredentialModel = new KeyVaultDetailModel();

            string configLocation = $"Environment:{environment}";

            configuration.Bind(configLocation, keyVaultCredentialModel);

            return keyVaultCredentialModel;
        }
    }


}
