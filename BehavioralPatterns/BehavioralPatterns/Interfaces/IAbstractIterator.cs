using BehavioralPatterns.Classes.Iterators;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Interfaces
{
    public interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
