using StructualPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Classes
{
    public class DiscountedItem : RentableDecorator
    {
        private readonly double DiscountedItemProcent = 20;

        public DiscountedItem(IRentable rentable) : base(rentable)
        {

        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice() - (base.CalculatePrice() * (this.DiscountedItemProcent / 100));
        }

        public override string Description
        {
            get { return base.Description + $" now at [{DiscountedItemProcent}]% off"; }
        }
    }
}
