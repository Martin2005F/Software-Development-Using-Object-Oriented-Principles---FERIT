using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Classes
{
    public class Box : IShipable
    {
        private List<IShipable> items;
        private string name;
        public Box(string name)
        {
            this.items = new List<IShipable>();
            this.name = name;
        }
        public void Add(IShipable item)
        {
            this.items.Add(item);
        }
        public void Remove(IShipable item)
        {
            this.items.Remove(item);
        }
        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IShipable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }
        public string Description(int depth = 0)
        {
            StringBuilder builder =
           new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IShipable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }

        public double Weight
        {
            get
            {
                double totalWeight = 0;
                foreach (IShipable item in items)
                {
                    if (item is IShipable shipableItem)
                    {
                        totalWeight += shipableItem.Weight;
                    }
                }
                return totalWeight;
            }
        }
    }
}
