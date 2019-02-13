using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CommandDesignPattern
{
    public class CommandInvoker
    {
        private Dictionary<ICommand, string> Commands = new Dictionary<ICommand, string>();

        public CommandInvoker()
        {
            // load all the ICommand implementations by reflections and add to Commands list
            Commands.Add(new InsertDataCommand("1"), "INSERT INTO USERS");
            Commands.Add(new DeleteDataCommand("2"), "DELETE FROM SALES");
        }

        public ICommand GetCommand(string command)
        {
            ICommand result = Commands.Keys.FirstOrDefault(cmd => cmd != null && cmd.Command.Equals(command));
            return result;
        }
    }
}

