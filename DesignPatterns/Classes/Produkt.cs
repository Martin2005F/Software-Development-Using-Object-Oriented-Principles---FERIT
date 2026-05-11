using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Classes
{
    public class Product : IShipable
    {
        private double price;
        private string description;
        private double weight;
        public Product(string description, double price, double weight)
        {
            this.description = description;
            this.price = price;
            this.weight = weight;
        }
        public double Price { get { return this.price; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }

        public double Weight { get { return weight; } }
    }
}
