using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ObserverDesignPattern
{
    public class WindowsEventLogObserver
    {

        public void WriteLog(object sender, EventArgs args)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry($"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff")} : {sender}", EventLogEntryType.Information, 101, 1);
            }
        }
    }
}
