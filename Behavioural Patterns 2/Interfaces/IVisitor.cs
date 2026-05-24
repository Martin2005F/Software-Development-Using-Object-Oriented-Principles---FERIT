using Behavioural_Patterns_2.Classes.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Interfaces
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);

        double Visit(Book BookItem);
    }
}
