using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Linq;

namespace SingletoneDesignPattern
{
    public sealed class AppConfigManager
    {
        private static readonly Lazy<AppConfigManager> lazy = new Lazy<AppConfigManager>(() => new AppConfigManager());
        private AppConfigManager()
        {
            Initialize();
        }

        public static AppConfigManager Instance => lazy.Value;

        public Dictionary<string, string> AppSettings { get; private set; }
        public Dictionary<string, string> ConnectionStrings { get; private set; }

        public T GetAppSetting<T>(string key) where T : IConvertible
        {
            T result = default(T);
            try
            {
                var value = AppSettings[key];
                result = (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                //Could not convert.  Pass back default value...
                result = default(T);
            }

            return result;
        }


        public void Initialize()
        {
            if (!ConfigurationManager.AppSettings.HasKeys())
            {
                Console.WriteLine("No appsettings secion found in the config file.");
            }

            AppSettings = new Dictionary<string, string>();
            ConnectionStrings = new Dictionary<string, string>();

            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                string value = ConfigurationManager.AppSettings[key];
                AppSettings.Add(key, value);
            }

            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                ConnectionStrings.Add(item.Name, item.ConnectionString);
            }
        }
    }
}
