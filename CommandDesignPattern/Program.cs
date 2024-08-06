using CommandDesignPattern.Models;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();
            ICommand onCommand = new OnCommand(tv);
            RemoteControl remoteON = new RemoteControl(onCommand);

            remoteON.PressButton();
            ICommand offCommand = new OffCommand(tv);

            remoteON.SetCommand(offCommand);
            remoteON.SetCommand(onCommand);

        }
    }
}
