using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Models
{
    internal class Television
    {
        public void On()
        {
            Console.WriteLine("TV Turns On");
        }
        public void Off() 
        { 
            Console.WriteLine("TV Turns Off"); 
        }
    }
}
