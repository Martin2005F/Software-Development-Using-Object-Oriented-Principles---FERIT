using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }

}
