using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Interfaces
{
    public interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
