using System;
using System.IO;

namespace DependencyInjection_Worksheet
{
    public class FileWriter : IWriter
    {
        private readonly string _path;

        public FileWriter(string path)
        {
            _path = path;
        }

        public void WriteLine(string input)
        {
            File.AppendAllText(_path, string.Format("{0} - {1}{2}", DateTime.Now.ToShortTimeString(), input, Environment.NewLine));
            Console.WriteLine(input);
        }
    }
}