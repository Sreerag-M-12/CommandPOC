using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class RemoteControl
    {
        public ICommand Command { get; set; }
        public RemoteControl(ICommand command) 
        {
            Command = command;
        }
        public void PressButton()
        {
            Command.Execute();
        }
        public void SetCommand(ICommand command)
        {
            Command = command;
            Command.Execute();
        }
    }
}
