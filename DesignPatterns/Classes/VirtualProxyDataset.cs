using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatterns.Classes
{
    public class VirtualProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        public VirtualProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }
    }
}
