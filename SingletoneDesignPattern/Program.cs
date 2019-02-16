using System;
using System.Configuration;
using System.Diagnostics;

namespace SingletoneDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            // get value as string:
            string stringValFromConfig = AppConfigManager.Instance.AppSettings["integerSetting"];
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(stringValFromConfig);
            Console.WriteLine($"Elapsed time: {elapsedMs} ms.");


            watch = Stopwatch.StartNew();
            // get value as any other type:
            bool boolValFromConfigFromManager = AppConfigManager.Instance.GetAppSetting<bool>("boolSetting");
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(boolValFromConfigFromManager);
            Console.WriteLine($"Elapsed time: {elapsedMs} ms.");


            watch = Stopwatch.StartNew();
            string stringValueFromConfigFile = ConfigurationManager.AppSettings["stringSetting"];
            Console.WriteLine(stringValueFromConfigFile);
            Console.WriteLine($"Elapsed time: {elapsedMs} ms.");

            Console.ReadLine();

            watch = Stopwatch.StartNew();
            stringValueFromConfigFile = ConfigurationManager.AppSettings["stringSetting"];
            Console.WriteLine(stringValueFromConfigFile);
            Console.WriteLine($"Elapsed time: {elapsedMs} ms.");

            Console.ReadLine();
        }
    }
}
