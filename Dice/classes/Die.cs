using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.classes
{
    public class Die
    {
        private int numberOfSides;
        
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
           
        }

        public int GetNumberOfSides
        {
            get { return numberOfSides; }
        }
        public int Roll()
        {
            return RandomGenerator.GetInstance().NextInt(1, numberOfSides + 1);
           
        }
    }

}
