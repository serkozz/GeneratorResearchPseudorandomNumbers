using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorResearchPseudorandomNumbers
{
    class FixedDataNoRandom
    {
        private int[] fixedArray;

        private SortedDictionary<int, double> valueProbabilityDictionary = new SortedDictionary<int, double>();
        private SortedDictionary<int, double> distributionFunctionOfRandomVariableDictionary = new SortedDictionary<int, double>();

        private double mathExpectation = 0;
        private double dispersion = 0;
        private double standartDeviation;
        public FixedDataNoRandom()
        {
            fixedArray = GenerateFixedArray();
        }
        private int[] GenerateFixedArray()
        {
            return new int[] { 12, 12, 12, 12, 5 };
        }

        public void General()
        {
            valueProbabilityDictionary = CreateDictionaryOfProbabilities(fixedArray);
            distributionFunctionOfRandomVariableDictionary = CreateDictionaryForDistributionFunctionOfRandomVariable(valueProbabilityDictionary);
            mathExpectation = CalculateMathExpectation(valueProbabilityDictionary);
            dispersion = CalculateDispersion(valueProbabilityDictionary);
            standartDeviation = CalculateStandartDeviation(dispersion);
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

        /// <summary>
        /// Возвращает словарь с вероятностями появления каждого числа интервала [minValue, maxValue]
        /// </summary>
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
                double second = fixedArray.Length;
                probability = first / second;
                //probability = valueRatePair.Value / sequenceLength; // Лол, а так он не делит, так получается ноль всегда, ладно,
                valueProbabilityDictionary.Add(valueRatePair.Key, Math.Round(probability, 5));
            }
            SortedDictionary<int, double> sortedByKeyProbabilityDictionary = new SortedDictionary<int, double>(valueProbabilityDictionary);
            
            return sortedByKeyProbabilityDictionary;
        }

        /*        F(x≤1) = 0
                F(1< x ≤2) = 0.2
                F(2< x ≤3) = 0.2 + 0.2 = 0.4
                F(3< x ≤4) = 0.2 + 0.4 = 0.6
                F(4< x ≤5) = 0.2 + 0.6 = 0.8
                F(x>5) = 1*/

        private SortedDictionary<int, double> CreateDictionaryForDistributionFunctionOfRandomVariable(SortedDictionary<int, double> valueProbabilityDictionary)
        {
            SortedDictionary<int, double> distributionFunctionOfRandomVariableDictionary = new SortedDictionary<int, double>(); // {значение, вероятность того, что следующее значение будет меньше чем текущее}
            double probabilitySum = 0;
            /*            bool isNowFirstElementOfTheDictionary = true;
                        bool isNowLastElementOfTheDictionary = false;*/

            /// Подумать над этим, пока выберу более легкое
            /*            foreach (KeyValuePair<int, double> keyValuePair in sortedByKeyValueProbabilityDictionary)
                        {
                            if(isNowFirstElementOfTheDictionary)
                            {
                                distributionFunctionOfRandomVariableDictionary.Add(keyValuePair.Key - 1, probabilitySum);
                                isNowFirstElementOfTheDictionary = false;
                            }
                            else if (isNowLastElementOfTheDictionary)
                            {
                                distributionFunctionOfRandomVariableDictionary.Add(keyValuePair.Key + 1, probabilitySum);
                                isNowLastElementOfTheDictionary = false;
                            }
                            else
                            {
                                if(keyValuePair.Key + 1 == sortedByKeyValueProbabilityDictionary)
                                distributionFunctionOfRandomVariableDictionary.Add(keyValuePair.Key, probabilitySum);
                            }
                            probabilitySum += keyValuePair.Value;
                        }*/
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
