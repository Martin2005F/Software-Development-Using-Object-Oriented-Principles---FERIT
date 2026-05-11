using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Interfaces;
namespace DesignPatterns.Classes
{
    internal class DarkTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }

    }
}
