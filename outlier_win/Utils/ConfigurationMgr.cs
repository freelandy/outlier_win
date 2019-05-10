using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace outlier_win.Utils
{
    public class ConfigurationMgr
    {
        public static string ReadAppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void WriteAppSettings(string key, string value)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings[key].Value = value;
            cfa.Save();
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
