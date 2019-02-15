using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
    }
}
