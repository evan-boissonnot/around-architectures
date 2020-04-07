using DesignPatterns.Examples.Core.PatternCommand;
using System;

namespace DesignPatterns.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN COMMAND ===");

            Invoker invoker = new Invoker();
            invoker.Command = new ConcreteCommand(new Receiver());

            invoker.Execute();
        }
    }
}
