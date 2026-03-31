using Dice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.classes
{
    public class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath; 
        }
        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }
    }
}
