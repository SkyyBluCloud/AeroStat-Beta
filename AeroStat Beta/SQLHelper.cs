using System.Configuration;

namespace AeroStat_Beta
{
    public static class SQLHelper
    {
        public static string cnnVal()
        {
            return ConfigurationManager.ConnectionStrings["AeroStat_Beta.Properties.settings.testAeroStat"].ConnectionString;
        }
    }
}
