using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class InsertDataCommand : ICommand
    {
        public string Command { get; set; }

        public InsertDataCommand(string command)
        {
            Command = command;
        }
        public bool Execute()
        {
            try
            {
                Console.WriteLine($"Executing given command {this.GetType().Name} {Command}...");
                // insert into
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UnExecute()
        {
            try
            {
                Console.WriteLine($"UnExecuting given command {Command}...");
                // delete from
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
