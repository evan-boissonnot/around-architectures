using System;

namespace DesignPatterns.Examples.Core.PatternCommand
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("One action of receiver");
        }
    }
}