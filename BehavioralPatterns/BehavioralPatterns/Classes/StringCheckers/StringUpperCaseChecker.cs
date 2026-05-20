using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.StringCheckers
{
    public class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char c in stringToCheck)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }
    }
}
