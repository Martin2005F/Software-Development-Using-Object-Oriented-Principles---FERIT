using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatterns.Classes
{
    public class LoggingProxyDataset : IDataset
    {
        private Dataset dataset;
        private string filePath;

        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            ConsoleLogger.GetInstance().Log($"Acces to file: {filePath}");

            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }

            return dataset.GetData();
        }
    }
}
