using StructualPatterns.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructualPatterns.Interfaces
{
    public interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }

}
