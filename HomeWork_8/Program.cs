using System;
using System.Configuration;

namespace HomeWork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            //{
            //    Console.WriteLine("Введите имя пользователя: ");
            //    Properties.Settings.Default.UserName = Console.ReadLine();
            //    Properties.Settings.Default.Save();
            //}

            //ReadAllSettings();
            //ReadSetting("Setting1");
            //ReadSetting("NotValid");
            //AddUpdateAppSettings("NewSetting", "May 7, 2014");
            //AddUpdateAppSettings("Setting1", "May 8, 2014");
            //ReadAllSettings();

            string UserName, Age, Occupation;

            if (NullArgument("UserName"))
            {
                Console.Write("Имя: ");
                ReadSetting("UserName");
            }
            else
            {
                Console.Write("Введите имя пользователя: ");
                UserName = Console.ReadLine();
                AddUpdateAppSettings("UserName", UserName);
            }
            if (NullArgument("Age"))
            {
                Console.Write("Возраст: ");
                ReadSetting("Age");
            }
            else
            {
                Console.Write("Введите возраст: ");
                Age = Console.ReadLine();
                AddUpdateAppSettings("Age", Age);
            }
            if (NullArgument("Occupation"))
            {
                Console.Write("Род деятельности: ");
                ReadSetting("Occupation");
            }
            else
            {
                Console.Write("Введите роде деятельности: ");
                Occupation = Console.ReadLine();
                AddUpdateAppSettings("Occupation", Occupation);
            }








        }
        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static bool NullArgument(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            if (result != "Not Found")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
