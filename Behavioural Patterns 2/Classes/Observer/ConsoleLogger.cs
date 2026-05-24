using Behavioural_Patterns_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Observer
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(DateTime.Now + "-> CPU load: " + provider.CPULoad + "% | Available RAM: " + provider.AvailableRAM + " MB");
        }
    }
}
