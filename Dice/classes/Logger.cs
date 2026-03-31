using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.classes
{
    class Logger
    {
        private string type;
        private string filePath;
        public Logger(string type, string filePath)
        {
            this.type = type;
            this.filePath = filePath;
        }
        public void Log(string message)
        {
            if (this.type.Equals("Console"))
                Console.WriteLine(message);
            else if (this.type.Equals("File"))
                using (System.IO.StreamWriter writer =
               new System.IO.StreamWriter(this.filePath))
                {
                    writer.WriteLine(message);
                }
            else
                throw new ArgumentException("Unkown type");
        }

    }
}
