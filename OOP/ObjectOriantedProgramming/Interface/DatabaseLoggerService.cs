using System;

namespace Interface
{
    internal class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
}
