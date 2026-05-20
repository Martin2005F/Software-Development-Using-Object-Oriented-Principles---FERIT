using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.StringCheckers
{
    public class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char c in stringToCheck)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }
    }
}
