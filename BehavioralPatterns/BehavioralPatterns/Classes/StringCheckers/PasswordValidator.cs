using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BehavioralPatterns.Classes.StringCheckers
{
    public class PasswordValidator
    {
        private StringChecker firstChecker;
        private StringChecker lastChecker;

        public PasswordValidator(StringChecker firstChecker)
        {
            this.firstChecker = firstChecker;
            this.lastChecker = firstChecker;
        }

        public void AddChecker(StringChecker nextChecker)
        {
            if (nextChecker != null && this.lastChecker != null)
            {
                this.lastChecker.SetNext(nextChecker);

                this.lastChecker = nextChecker;
            }
        }

        public bool Validate(string password)
        {
            if (this.firstChecker == null) return false;

            return this.firstChecker.Check(password);
        }
    }
}
