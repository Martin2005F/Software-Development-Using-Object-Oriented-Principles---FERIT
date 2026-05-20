using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Interfaces
{
    public interface IProductCollection
    {
        IProductIterator GetProductIterator();
    }
}
