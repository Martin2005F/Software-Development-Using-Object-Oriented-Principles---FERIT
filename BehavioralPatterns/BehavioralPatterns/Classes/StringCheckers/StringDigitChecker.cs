using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.StringCheckers
{
     public class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char c in stringToCheck)
            {
                if (char.IsDigit(c)) return true; 
            }
            return false;
        }
    }
}
