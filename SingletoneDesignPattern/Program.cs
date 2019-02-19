using System;
using System.Configuration;
using System.Diagnostics;

namespace SingletoneDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // get value as string:
            string stringValFromConfig = AppConfigManager.Instance.AppSettings["integerSetting"];
            Console.WriteLine(stringValFromConfig);

            // get value as any other type:
            bool boolValFromConfigFromManager = AppConfigManager.Instance.GetAppSetting<bool>("boolSetting");
            Console.WriteLine(boolValFromConfigFromManager);

            Console.ReadLine();
        }
    }
}
