using Microsoft.Extensions.Configuration;

namespace BasicLogin.Infrastructure
{
    public class SharedSettings
    {
        public ConfigurationOption ConfigurationOption { get; set; }
    }

    public class ConfigurationOption
    {
        public string IBDbServer { get; set; }
        public string IBDbName { get; set; }
        public string Provider { get; set; }
        public string TokenExpiration { get; set; }
        public string SqlConnection { get; set; }
        public string SqlCacheCon { get; set; }
        public string RedisCacheCon { get; set; }
        public string TableName { get; set; }
        public string Port { get; set; }
    }

    public class ConfigOption
    {
        public static string GetValueFromSharedSettings(string strKey)
        {
            try
            {
                var configurationBuilder = new ConfigurationBuilder();
                var path = Path.GetFullPath(Path.Combine(@"..\Shared", "sharedsettings.json"));
                configurationBuilder.AddJsonFile(path, false);
                var root = configurationBuilder.Build();
                string connectionString = root.GetSection(strKey).Value;
                return connectionString;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
