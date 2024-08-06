using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class OnCommand : ICommand
    {
        Television Television { get; set; }

        public OnCommand(Television tv)
        {
            Television = tv;
        }
        public void Execute()
        {

           Television.On();
        }
    }
}
