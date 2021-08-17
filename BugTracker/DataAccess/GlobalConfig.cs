using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;
using TaskTracker.DataAccess;

namespace TaskTracker
{
    /// <summary>
    /// A class for processing general info of various application settings
    /// </summary>
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static TimeSpan EmailTime = Properties.Settings.Default.EmailTime;
        public static bool DemoModeEnabled = false;

        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static string AppKeyLookup(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
        public static bool EmailEnabled()
        {
            return Properties.Settings.Default.EmailCheckBox;
        }
        
        



    }
}
