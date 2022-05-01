using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorResearchPseudorandomNumbers
{
    class OwnRandom
    {
        private int  sequenceLength;

        public OwnRandom(int sequenceLength)
        {
            this.sequenceLength = sequenceLength;
        }

        public int[] GenerateRandomArray(int minValue, int maxValue)
        {
            int[] randomArray = new int[sequenceLength];
            Random random = new Random();

            for (int i = 0; i < sequenceLength; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }

            return randomArray;
        }
    }
}
