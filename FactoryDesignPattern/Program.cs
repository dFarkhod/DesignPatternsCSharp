using System;
using System.Threading;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initiating database connection...");
            var dbConnection = DatabaseConnectionFactory.Create();
            dbConnection.Connect();
            Console.WriteLine("Doing some cool stuff with database.");
            int i = 0;
            while (i < new Random().Next(20))
            {
                Console.Write(".");
                i++;
                Thread.Sleep(i * 100);
            }
            Console.WriteLine();
            dbConnection.Disconnect();
            Console.Read();
        }
    }
}
