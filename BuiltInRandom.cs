﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorResearchPseudorandomNumbers
{
    class BuiltInRandom
    {
        private int sequenceLength;
        private Dictionary<int, double> valueProbabilityDictionary = new Dictionary<int, double>();
        private double mathExpectation;
        private double dispersion;
        public BuiltInRandom(int sequenceLength)
        {
            this.sequenceLength = sequenceLength;
        }

        public Dictionary<int, double> GetValueProbabilityDictionary()
        {
            return valueProbabilityDictionary;
        }

        public int[] GenerateRandomArray(int minValue, int maxValue)
        {
            int[] randomArray = new int[sequenceLength];
            Random random = new Random();

            for (int i = 0; i < sequenceLength; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }

            CreateDictionaryOfProbabilities(randomArray);

            return randomArray;
        }

        /// <summary>
        /// Возвращает словарь с вероятностями появления каждого числа интервала [minValue, maxValue]
        /// </summary>
        private void CreateDictionaryOfProbabilities(int[] data)
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
            
            foreach (KeyValuePair<int, int> valueRatePair in valueRateDictionary)
            {
                double first = valueRatePair.Value;
                double second = sequenceLength;
                probability = first / second;
                //probability = valueRatePair.Value / sequenceLength; // Лол, а так он не делит, так получается ноль всегда, ладно,
                valueProbabilityDictionary.Add(valueRatePair.Key, Math.Round(probability, 5));
            }
        }

        public void CalculateMathExpectation()
        {

        }
        
        public void CalculateDispersion()
        {

        }
    }
}