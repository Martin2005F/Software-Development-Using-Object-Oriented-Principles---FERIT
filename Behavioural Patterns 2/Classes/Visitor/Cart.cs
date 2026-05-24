using Behavioural_Patterns_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Visitor
{
    class Cart
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
           if(!this.items.Contains(item)) 
           {
                this.items.Add(item);
           }
        }

        public void RemoveItem(IItem item) 
        {
            if (this.items.Contains(item)) 
            {
                this.items.Remove(item);
            }
        }

        public double Accept(IVisitor visitor)
        {
            double total = 0;
            foreach (IItem item in this.items)
            {
                total += item.Accept(visitor);
            }
            return total;
        }
    }
}
