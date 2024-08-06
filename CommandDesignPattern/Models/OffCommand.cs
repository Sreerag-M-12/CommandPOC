using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class OffCommand:ICommand
    {
         public Television Television {  get; set; }

         public OffCommand(Television tv)
        {
            Television = tv;
        }      
        public void Execute() 
        {
            Television.Off();           
        }
    }
}
