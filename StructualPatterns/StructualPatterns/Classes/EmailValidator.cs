using StructualPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Classes
{
    public class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {
            if (string.IsNullOrEmpty(candidate))
            {
                return false;
            }

            return HasAtSign(candidate) && HasValidDomain(candidate);
        }

        private bool HasAtSign(string candidate)
        {
            return candidate.Contains("@");
        }

        private bool HasValidDomain(string candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }
    }
}
