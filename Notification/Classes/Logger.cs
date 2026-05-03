using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Classes
{
    public class Logger
    {
        private static Logger instance;
        private string filePath;
        private Logger()
        {
            filePath = "data.txt";
        }

        public static Logger GetInstance()
        {
            if (instance == null) 
            {
                instance = new Logger();
            }
            return instance;
        }

        public string FilePath{
            get { return filePath; }
            set { filePath = value; }
        }

        public void Log(string message) 
        {
            string logMessage = $"[{DateTime.Now}] {message}";
            System.IO.File.AppendAllText(this.filePath, logMessage + Environment.NewLine);

        }
    }
}
