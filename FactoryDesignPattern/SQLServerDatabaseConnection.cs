using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading;

namespace FactoryDesignPattern
{
    public class SQLServerDatabaseConnection : AbstractDatabaseFactoryConnection
    {
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine($"{this.GetType().Name} has been connected.");
        }

        public override void Disconnect()
        {
            base.Disconnect();
            Console.WriteLine($"{this.GetType().Name} has been disconnected.");
        }
    }
}
