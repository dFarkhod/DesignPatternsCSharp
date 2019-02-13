using System;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CommandInvoker invoker = new CommandInvoker();
            ICommand COMMAND1 = invoker.GetCommand("134");
            if (COMMAND1 != null)
                COMMAND1.Execute();
            else
                Console.WriteLine("Command not found");

            ICommand DCmd = invoker.GetCommand("2");
            if (DCmd != null)
                DCmd.Execute();

            Console.Read();
        }
    }
}
