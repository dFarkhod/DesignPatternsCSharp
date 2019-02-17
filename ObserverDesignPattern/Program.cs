using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LogObservable observable = new LogObservable();
            ConsoleObserver console = new ConsoleObserver();
            observable.NewLogEntry += console.WriteLog;
            WindowsEventLogObserver eventLog = new WindowsEventLogObserver();
            observable.NewLogEntry += eventLog.WriteLog;

            observable.WriteLog("Application has been started.");
            Console.ReadLine();
        }
    }
}
