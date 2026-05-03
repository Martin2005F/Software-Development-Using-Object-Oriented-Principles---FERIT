using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Classes
{
    public class NotificationBuilder : IBuilder
    {
        private String author = "system";
        private String title = "Notification";
        private String text = "";
        private DateTime time = DateTime.Now;
        private Category level = Category.INFO;
        private ConsoleColor color = ConsoleColor.White;

        public IBuilder SetAuthor(String author)
        {
            this.author = author;
            return this;
        }
        public IBuilder SetTitle(String title) 
        {
            this.title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.text = text;
            return this;
        }

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }
    }
}
