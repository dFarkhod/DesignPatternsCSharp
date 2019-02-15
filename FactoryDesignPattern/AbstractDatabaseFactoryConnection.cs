using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryDesignPattern
{
    public abstract class AbstractDatabaseFactoryConnection : IDatabaseConnection
    {
        public virtual void Connect()
        {
            Thread.Sleep(new Random().Next(3000));
        }

        public virtual void Disconnect()
        {
            Thread.Sleep(new Random().Next(2000));
        }
    }
}
