using StructualPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Classes
{
    public class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine(items.Sum(r => r.CalculatePrice()));
        }
        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(r.Description));
        }
    }
}
