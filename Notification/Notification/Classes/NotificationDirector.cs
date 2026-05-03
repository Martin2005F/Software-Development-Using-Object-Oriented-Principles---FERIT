using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Classes
{
    public class NotificationDirector
    {
        private IBuilder builder;
        public NotificationDirector(IBuilder builder) 
        {
            this.builder = builder;
        }

        public ConsoleNotification CreateDefaultInfo(string author)
        {
            return builder.SetAuthor(author)
                .SetTitle("Information")
                .SetText("This is a standard info message.")
                .SetTime(DateTime.Now)
                .SetLevel(Category.INFO)
                .SetColor(ConsoleColor.Cyan)
                .Build();
        }

        public ConsoleNotification CreateDefaultAlert(string author)
        {
            return builder.SetAuthor(author)
                          .SetTitle("Security Alert")
                          .SetText("Potential security threat detected!")
                          .SetTime(DateTime.Now)
                          .SetLevel(Category.ALERT)
                          .SetColor(ConsoleColor.Yellow)
                          .Build();
        }

        public ConsoleNotification CreateDefaultError(string author)
        {
            return builder.SetAuthor(author)
                          .SetTitle("System Error")
                          .SetText("A critical error has occurred in the application.")
                          .SetTime(DateTime.Now)
                          .SetLevel(Category.ERROR)
                          .SetColor(ConsoleColor.Red)
                          .Build();
        }
    }
}
