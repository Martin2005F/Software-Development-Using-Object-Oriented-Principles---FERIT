using Dice.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.Interfaces
{
    public interface IFlexibleDiceRoller : IDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();

    }
}
