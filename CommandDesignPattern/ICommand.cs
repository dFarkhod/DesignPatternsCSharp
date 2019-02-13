using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public interface ICommand
    {
        string Command { get; set; }
        bool Execute();
        bool UnExecute();
    }

}
