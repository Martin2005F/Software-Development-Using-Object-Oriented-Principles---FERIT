using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Search
{
    class LinearSearch : SearchStrategy
    {
       public override int Search(double[] array, double target)
        {
            for(int i=0; i< array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
