using System;

namespace Interface
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
}
