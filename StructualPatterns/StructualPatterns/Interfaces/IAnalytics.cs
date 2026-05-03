using StructualPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Interfaces
{
    public interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
