using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class ShippingService
    {
        private decimal unitPrice = 0.5m;

        public ShippingService() { }

        public decimal CalculateShippingCost(IShipable item)
        {
            return (decimal)item.Weight*unitPrice;
        }
    }
}
