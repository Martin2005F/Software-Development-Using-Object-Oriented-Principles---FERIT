using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.StringCheckers
{
    public class StringLengthChecker : StringChecker
    {
        private int minLength;

        public StringLengthChecker(int minLength)
        {
            this.minLength = minLength;
        }

        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck != null && stringToCheck.Length >= this.minLength;
        }
    }
}
