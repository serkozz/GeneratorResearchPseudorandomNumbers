using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorResearchPseudorandomNumbers
{
    public class GaussianRandom
    {
        private int sequenceLength;
        private bool _hasDeviate;
        private double _storedDeviate;
        private int[] randomArray;

        private int mu = 0;
        private int sigma = 1;

        private Random builtInRandom;
        private LehmerRNG lehmerRNG;
        private GeneratorType generatorType = GeneratorType.BuiltIn;

        private SortedDictionary<int, double> valueProbabilityDictionary = new SortedDictionary<int, double>();
        private SortedDictionary<int, double> distributionFunctionOfRandomVariableDictionary = new SortedDictionary<int, double>();

        private double mathExpectation = 0;
        private double dispersion = 0;
        private double standartDeviation;

        public GaussianRandom(GeneratorType generatorType, int sequenceLength, int mu, int sigma)
        {
            this.sequenceLength = sequenceLength;
            this.mu = mu;
            this.sigma = sigma;
            this.generatorType = generatorType;

            if (generatorType == GeneratorType.BuiltIn)
                builtInRandom = new Random();
            if (generatorType == GeneratorType.Lehmer)
                lehmerRNG = new LehmerRNG(DateTime.Now.Second + DateTime.UtcNow.Hour, sequenceLength);
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

        /// <summary>
        /// Obtains normally (Gaussian) distributed random numbers, using the Box-Muller
        /// transformation.  This transformation takes two uniformly distributed deviates
        /// within the unit circle, and transforms them into two independently
        /// distributed normal deviates.
        /// </summary>
        /// <param name="mu">The mean of the distribution.  Default is zero.</param>
        /// <param name="sigma">The standard deviation of the distribution.  Default is one.</param>
        /// <returns></returns>
        public double NextGaussian(double mu = 0, double sigma = 1)
        {
            if (sigma <= 0)
                throw new ArgumentOutOfRangeException("sigma", "Must be greater than zero.");

            if (_hasDeviate)
            {
                _hasDeviate = false;
                return _storedDeviate * sigma + mu;
            }

            double v1 = 0, v2 = 0, rSquared = 0;
            do
            {
                if (generatorType == GeneratorType.BuiltIn)
                {
                    // two random values between -1.0 and 1.0
                    v1 = 2 * builtInRandom.NextDouble() - 1;
                    v2 = 2 * builtInRandom.NextDouble() - 1;
                }
                if (generatorType == GeneratorType.Lehmer)
                {
                    // two random values between -1.0 and 1.0
                    v1 = 2 * lehmerRNG.Next() - 1;
                    v2 = 2 * lehmerRNG.Next() - 1;
                }
                rSquared = v1 * v1 + v2 * v2;
                // ensure within the unit circle
            } while (rSquared >= 1 || rSquared == 0);

            // calculate polar tranformation for each deviate
            var polar = Math.Sqrt(-2 * Math.Log(rSquared) / rSquared);
            // store first deviate
            _storedDeviate = v2 * polar;
            _hasDeviate = true;
            // return second deviate
            return v1 * polar * sigma + mu;
        }

        private int[] GenerateRandomArray(int minValue, int maxValue)
        {
            int[] randomArray = new int[sequenceLength];

            for (int i = 0; i < sequenceLength; i++)
            {
                double gausianRNGValue = NextGaussian(mu, sigma);
                int gausianValue = (int)((maxValue - minValue) * gausianRNGValue + minValue); // [minValue, maxValue - 1]
                randomArray[i] = gausianValue;
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
