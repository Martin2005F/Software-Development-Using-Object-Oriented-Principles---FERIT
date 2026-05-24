using Behavioural_Patterns_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural_Patterns_2.Classes.Visitor
{
    internal class RentVisitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                return DVDItem.Price;
            }
            return DVDItem.Price * 0.10;
        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.10;
        }

        public double Visit(Book BookItem)
        {
            return BookItem.Price * 0.10;
        }

    }
}
