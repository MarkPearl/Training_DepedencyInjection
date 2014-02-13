using System;

namespace DependencyInjection_Worksheet
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}