using System;
using System.Threading;

namespace FactoryDesignPattern
{
    public class PostgreSQLConnection : AbstractDatabaseFactoryConnection
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