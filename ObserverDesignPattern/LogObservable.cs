using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class LogObservable
    {
        public event EventHandler NewLogEntry;

        public void WriteLog(string log) => NewLogEntry?.Invoke(log, EventArgs.Empty);
    }
}
