using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Classes
{
    public class ConsoleLogger
    {
        private static ConsoleLogger instance;

        private ConsoleLogger() { }

        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}]: {message}");
        }
    }
}
