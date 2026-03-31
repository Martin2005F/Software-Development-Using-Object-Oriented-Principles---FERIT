using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.classes
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random random;
        private RandomGenerator()
        {
            this.random = new Random();
        }

        public static RandomGenerator GetInstance()
        {
            if (instance == null)
                instance = new RandomGenerator();
            return instance;
        }
        public int NextInt(int lowerBound, int upperBound)
        {
            return random.Next(lowerBound, upperBound);
        }

    }
}
