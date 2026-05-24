using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Search
{
    abstract class SearchStrategy
    {
        public abstract int Search(double[] array, double target);
    }
}
