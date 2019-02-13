using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern
{
    public class SilverlakeHost : IHost
    {

        void IHost.SendMessage(string message)
        {
            Console.WriteLine($"Sending message {message} via {this.GetType().Name}");
        }
    }
}
