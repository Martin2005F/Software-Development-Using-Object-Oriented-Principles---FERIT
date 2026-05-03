using StructualPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Classes
{
    public class Book : IRentable
    {
        private readonly double BasedBookPrice = 3.99;
        public string Title {  get; private set; }
        public Book(string title)
        {
            this.Title = title;
        }
        public string Description { get { return this.Title; } }
        public double CalculatePrice()
        {
            return BasedBookPrice;
        }
    }
}
