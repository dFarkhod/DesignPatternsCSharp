using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHost silverlakeHost = new SilverlakeHost();
            HostAdapter hostAdapter = new HostAdapter(silverlakeHost);
            hostAdapter.SendRequestToHost();
            Console.Read();
        }
    }
}
