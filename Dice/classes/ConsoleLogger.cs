using Dice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.classes
{
   public class ConsoleLogger : ILogger
    {
        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
