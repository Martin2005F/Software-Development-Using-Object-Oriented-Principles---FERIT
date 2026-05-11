using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
