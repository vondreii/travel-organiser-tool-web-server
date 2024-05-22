using Microsoft.Extensions.Configuration;

namespace TravelOrganiserTool.Environment
{
    public class EnvironmentService : IEnvironmentService
    {
        private static EnvironmentService _instance;
        private readonly IConfiguration _configuration;

        private EnvironmentService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static EnvironmentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new Exception("EnvironmentService instance is not initialized.");
                }
                return _instance;
            }
        }

        public static void Initialize(IConfiguration configuration)
        {
            _instance = new EnvironmentService(configuration);
        }

        public bool IsProduction => _configuration.GetValue<bool>("IsProduction");
        public bool IsUpdateDbData => _configuration.GetValue<bool>("IsUpdateDbData");
    }
}
