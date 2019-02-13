using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class HostAdapter
    {
        private IHost Host = null;

        public HostAdapter(IHost host)
        {
            this.Host = host;
        }
        public void SendRequestToHost()
        {
            Host.SendMessage("Hello there");
        }
    }
}
