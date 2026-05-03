using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Interfaces
{
    public interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
