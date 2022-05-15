using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorResearchPseudorandomNumbers
{
    class LehmerRNG
    {
        private const int a = 48271;
        private const int m = 2147483647;
        private const int q = 127773;
        private const int r = 2836;
        private int seed;

        private int sequenceLength;
        private int[] randomArray;

        private SortedDictionary<int, double> valueProbabilityDictionary = new SortedDictionary<int, double>();
        private SortedDictionary<int, double> distributionFunctionOfRandomVariableDictionary = new SortedDictionary<int, double>();

        private double mathExpectation = 0;
        private double dispersion = 0;
        private double standartDeviation;

        public LehmerRNG(int seed, int sequenceLength)
        {
            if (seed <= 0 || seed == int.MaxValue)
                throw new Exception("Bad seed");
            this.seed = seed;
            this.sequenceLength = sequenceLength;
        }
        /// <summary>
        /// Генерирует случайное число из диапазона [0, 1] используя алгоритм Лемера
        /// </summary>
        /// <returns></returns>
        public double Next()
        {
            int maxValue = seed / q;
            int minValue = seed % q;
            seed = (a * minValue) - (r * maxValue);
            if (seed <= 0)
                seed = seed + m;
            return (seed * 1.0) / m;
        }

        public int[] GetRandomArray()
        {
            return randomArray;
        }
        public SortedDictionary<int, double> GetValueProbabilityDictionary()
        {
            return valueProbabilityDictionary;
        }

        public SortedDictionary<int, double> GetDistributionFunctionOfRandomVariableDictionary()
        {
            return distributionFunctionOfRandomVariableDictionary;
        }

        public double GetMathExpectation()
        {
            return mathExpectation;
        }

        public double GetDispersion()
        {
            return dispersion;
        }

        public double GetStandartDeviation()
        {
            return standartDeviation;
        }

        public void General()
        {
            randomArray = GenerateRandomArray(0, 100);
            valueProbabilityDictionary = CreateDictionaryOfProbabilities(randomArray);
            distributionFunctionOfRandomVariableDictionary = CreateDictionaryForDistributionFunctionOfRandomVariable(valueProbabilityDictionary);
            mathExpectation = CalculateMathExpectation(valueProbabilityDictionary);
            dispersion = CalculateDispersion(valueProbabilityDictionary);
            standartDeviation = CalculateStandartDeviation(dispersion);
        }

        private int[] GenerateRandomArray(int minValue, int maxValue)
        {
            int[] randomArray = new int[sequenceLength];

            for (int i = 0; i < sequenceLength; ++i)
            {
                double lehmerRNGValue = Next();
                int lehmerValue = (int)((maxValue - minValue) * lehmerRNGValue + minValue); // [minValue, maxValue - 1]
                randomArray[i] = lehmerValue;
            }

            return randomArray;
        }
        private SortedDictionary<int, double> CreateDictionaryOfProbabilities(int[] data)
        {
            Dictionary<int, int> valueRateDictionary = new Dictionary<int, int>(); // {значение, количество появлений}
            double probability;

            for (int i = 0; i < data.Length; i++)
            {
                if (!valueRateDictionary.ContainsKey(data[i]))
                    valueRateDictionary.Add(data[i], 1);
                else if (valueRateDictionary.ContainsKey(data[i]))
                    valueRateDictionary[data[i]]++;
            }

            Dictionary<int, double> valueProbabilityDictionary = new Dictionary<int, double>(); // {значение, вероятность появления}
            foreach (KeyValuePair<int, int> valueRatePair in valueRateDictionary)
            {
                double first = valueRatePair.Value;
                double second = sequenceLength;
                probability = first / second;
                //probability = valueRatePair.Value / sequenceLength; // Лол, а так он не делит, так получается ноль всегда, ладно,
                valueProbabilityDictionary.Add(valueRatePair.Key, Math.Round(probability, 5));
            }
            SortedDictionary<int, double> sortedByKeyProbabilityDictionary = new SortedDictionary<int, double>(valueProbabilityDictionary);

            return sortedByKeyProbabilityDictionary;
        }

        private SortedDictionary<int, double> CreateDictionaryForDistributionFunctionOfRandomVariable(SortedDictionary<int, double> valueProbabilityDictionary)
        {
            SortedDictionary<int, double> distributionFunctionOfRandomVariableDictionary = new SortedDictionary<int, double>(); // {значение, вероятность того, что следующее значение будет меньше чем текущее}
            double probabilitySum = 0;

            foreach (KeyValuePair<int, double> keyValuePair in valueProbabilityDictionary)
            {
                probabilitySum += Math.Round(keyValuePair.Value, 5);
                distributionFunctionOfRandomVariableDictionary.Add(keyValuePair.Key, probabilitySum);
            }

            return distributionFunctionOfRandomVariableDictionary;
        }
        private double CalculateMathExpectation(SortedDictionary<int, double> valueProbabilityDictionary)
        {
            double mathExpectation = 0;

            foreach (KeyValuePair<int, double> keyValuePair in valueProbabilityDictionary)
            {
                mathExpectation += keyValuePair.Key * keyValuePair.Value;
            }

            return mathExpectation;
        }

        private double CalculateDispersion(SortedDictionary<int, double> valueProbabilityDictionary)
        {
            double mathExpectation = 0;
            double mathExpectationFromXInSquare = 0;

            foreach (KeyValuePair<int, double> keyValuePair in valueProbabilityDictionary)
            {
                mathExpectation += keyValuePair.Key * keyValuePair.Value;
                mathExpectationFromXInSquare += Math.Pow(keyValuePair.Key, 2) * keyValuePair.Value;
            }

            return Math.Round(mathExpectationFromXInSquare - Math.Pow(mathExpectation, 2), 2);
        }

        private double CalculateStandartDeviation(double dispersion)
        {
            return Math.Round(Math.Sqrt(dispersion), 2);
        }
    }
}