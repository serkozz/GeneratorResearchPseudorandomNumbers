using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneratorResearchPseudorandomNumbers
{
    public partial class MainForm : Form
    {
        private int sequenceLength;

        public MainForm()
        {
            InitializeComponent();
        }

        private enum GeneratorType
        {
            BuiltIn,
            Own
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            sequenceLength = TryParseInt(sequenceLengthTextBox.Text);

            if (builtInGeneratorTypeRadioButton.Checked)
            {
                BuiltInRandom builtInRandom = new BuiltInRandom(sequenceLength);
                builtInRandom.General();

                ClearCharts();
                CreateChart(frequencyChart, generatorType: GeneratorType.BuiltIn, isGapsAllowed: true, builtInRandom.GetValueProbabilityDictionary());
                CreateChart(valueChart, generatorType: GeneratorType.BuiltIn, isGapsAllowed: true, builtInRandom.GetDistributionFunctionOfRandomVariableDictionary());

                ClearStats();
                CreateStats(mathExpectation: builtInRandom.GetMathExpectation(), dispersion: builtInRandom.GetDispersion(), standartDeviation: builtInRandom.GetStandartDeviation());
            }

            else if (ownGeneratorTypeRadioButton.Checked)
            {
                OwnRandom ownRandom = new OwnRandom(sequenceLength);
                //CreateChart(valueChart, generatorType: GeneratorType.Own,);
            }

            else if (noGeneratorRadioButton.Checked) // Для дебагинга
            {
                FixedDataNoRandom noRandom = new FixedDataNoRandom();
                noRandom.General();

                ClearCharts();
                CreateChart(frequencyChart, generatorType: GeneratorType.BuiltIn, isGapsAllowed: true, noRandom.GetValueProbabilityDictionary());
                CreateChart(valueChart, generatorType: GeneratorType.BuiltIn, isGapsAllowed: true, noRandom.GetDistributionFunctionOfRandomVariableDictionary());

                ClearStats();
                CreateStats(mathExpectation: noRandom.GetMathExpectation(), dispersion: noRandom.GetDispersion(), standartDeviation: noRandom.GetStandartDeviation());
            }
        }

        private int TryParseInt(string text)
        {
            int value = 0;

            if (Int32.TryParse(text, out value))
            {
                Console.WriteLine("'{0}' --> {1}", text, value);
                sequenceLength = value;
            }

            return value;
        }

        private void CreateChart(Chart chart, GeneratorType generatorType, int[] data)
        {
            if (generatorType == GeneratorType.BuiltIn)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    chart.Series[0].Points.AddXY(i, data[i]);
                }
            }

            else if (generatorType == GeneratorType.Own)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    chart.Series[1].Points.AddXY(i, data[i]);
                }
            }
        }

        private void CreateChart(Chart chart, GeneratorType generatorType, bool isGapsAllowed, Dictionary<int, double> data)
        {
            if (generatorType == GeneratorType.BuiltIn)
            {
                if (isGapsAllowed)
                {
                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[0].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                    }
                }
                else // Подумать а надо ли
                {
                    int index = 0;

                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[0].Points.AddXY(index, keyValuePair.Value);
                        index++;
                    }
                }
            }

            else if (generatorType == GeneratorType.Own)
            {
                foreach (KeyValuePair<int, double> keyValuePair in data)
                {
                    chart.Series[1].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                }
            }
        }

        private void CreateChart(Chart chart, GeneratorType generatorType, bool isGapsAllowed, SortedDictionary<int, double> data)
        {
            if (generatorType == GeneratorType.BuiltIn)
            {
                if (isGapsAllowed)
                {
                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[0].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                    }
                }
                else // Подумать а надо ли
                {
                    int index = 0;

                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[0].Points.AddXY(index, keyValuePair.Value);
                        index++;
                    }
                }
            }

            else if (generatorType == GeneratorType.Own)
            {
                foreach (KeyValuePair<int, double> keyValuePair in data)
                {
                    chart.Series[1].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                }
            }
        }

        private void ClearCharts()
        {
            frequencyChart.Series[0].Points.Clear();
            valueChart.Series[0].Points.Clear();
        }
    
        private void CreateStats(double mathExpectation, double dispersion, double standartDeviation)
        {
            string mathExpectationString = "Математическое ожидание случайной величины: " + mathExpectation;
            string dispersionString = "Дисперсия случайной величины: " + dispersion;
            string standartDeviationString = "Средневадратичное отклонение (стандартное отклонение): " + standartDeviation;
            statsTextBox.Text = mathExpectationString + Environment.NewLine +
                                Environment.NewLine + dispersionString +
                                Environment.NewLine + Environment.NewLine +
                                standartDeviationString;
        }

        private void ClearStats()
        {
            statsTextBox.Text = String.Empty;
        }
    }
}
