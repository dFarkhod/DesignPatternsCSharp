using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class ConsoleObserver
    {
        public void WriteLog(object sender, EventArgs args)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff")} : {sender}");
        }
    }
}
