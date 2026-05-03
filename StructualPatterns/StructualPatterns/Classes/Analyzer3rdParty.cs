using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Classes
{
    public class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }

        public double[] PerColumnAverage(double[][] data)
        {
            if (data.Length == 0) return new double[0];

            int rowCount = data.Length;
            int columnCount = data[0].Length;
            double[] columnAverages = new double[columnCount];

            for (int j = 0; j < columnCount; j++)
            {
                double columnSum = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    columnSum += data[i][j];
                }
                columnAverages[j] = columnSum / rowCount;

            }
            return columnAverages;
        }
    }
}
