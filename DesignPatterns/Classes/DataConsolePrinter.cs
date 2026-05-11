using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatterns.Classes
{
    public class DataConsolePrinter
    {
        public void Print(ReadOnlyCollection<List<string>> data)
        {
            if(data == null)
            {
                Console.WriteLine("Access Denied: You do not have permission to view this data.");
                return;
            }
            foreach (List<string> row in data)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
    }
}
