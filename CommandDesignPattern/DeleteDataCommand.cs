using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class DeleteDataCommand : ICommand
    {
        public string Command { get; set; }

        public DeleteDataCommand(string command)
        {
            Command = command;
        }
        public bool Execute()
        {
            try
            {
                Console.WriteLine($"Executing given command {this.GetType().Name} {Command}...");
                // DELETE FROM Command
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
                // INSERT INTO Command
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
