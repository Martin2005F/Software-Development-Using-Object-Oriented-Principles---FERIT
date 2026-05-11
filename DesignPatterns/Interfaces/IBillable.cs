using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IBillable
    {
        double Price { get; }
        string Description(int depth = 0);
    }
}
