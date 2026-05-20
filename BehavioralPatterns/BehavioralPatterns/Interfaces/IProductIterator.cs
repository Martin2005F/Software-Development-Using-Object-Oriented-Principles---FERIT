using BehavioralPatterns.Classes.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Interfaces
{
    public interface IProductIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current {  get; }
    }
}
