using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Reflection;

namespace KeyOnline.MvcCore.Helper
{
    public class AppConfigs
    {
        public static void ReadConfigs()
        {
            merchant_id = GetConfigValue("merchant_id", "");
            api_user = GetConfigValue("api_user", "");
            api_password = GetConfigValue("api_password", "");
            note = GetConfigValue("note", "");
            api_url = GetConfigValue("api_url", "");
        }
        public static string merchant_id { get; set; }
        public static string api_user { get; set; }
        public static string api_password { get; set; }
        public static string note { get; set; }
        public static string api_url { get; set; }
        private static T GetConfigValue<T>(string configKey, T defaultValue)
        {
            var value = defaultValue;
            var converter = TypeDescriptor.GetConverter(typeof(T));
            try
            {
                if (converter != null)
                {
                    var setting = GetConfigValueAsString(configKey.ToString());
                    if (!string.IsNullOrEmpty(setting))
                    {
                        value = (T)converter.ConvertFromString(setting);
                    }
                }
            }
            catch
            {
                value = defaultValue;
            }
            return value;
        }
        public static string GetConfigValueAsString(string configKey)
        {
            string configKeyValue = string.Empty;
            try
            {
                string json = File.ReadAllText("appsettings.json");
                JObject jsonObject = JObject.Parse(json);
                configKeyValue = (string)jsonObject["AppSettings"][configKey];
            }
            catch { }

            return configKeyValue;
        }
    }
}
