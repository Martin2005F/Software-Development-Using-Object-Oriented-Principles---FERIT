using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Interfaces
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
