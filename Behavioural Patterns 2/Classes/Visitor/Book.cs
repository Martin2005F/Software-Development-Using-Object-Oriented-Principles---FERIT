using Behavioural_Patterns_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Visitor
{
    class Book : IItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return "Book: " + this.Title + Environment.NewLine + " -> Price: " + this.Price;
        }
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
