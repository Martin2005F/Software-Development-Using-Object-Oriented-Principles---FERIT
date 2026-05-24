using Behavioural_Patterns_2.Classes.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Interfaces
{
    interface Logger
    {
        void Log(SimpleSystemDataProvider provider);
    }
}
