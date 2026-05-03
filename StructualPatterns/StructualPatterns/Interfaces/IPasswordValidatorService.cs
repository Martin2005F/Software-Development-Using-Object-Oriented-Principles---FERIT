using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Interfaces
{
    public interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
