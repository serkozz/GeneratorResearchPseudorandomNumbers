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
        private int[] builtInRandomArray;
        private int[] ownRandomArray;

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
                builtInRandomArray = builtInRandom.GenerateRandomArray(0, 100);
                //CreateChart(frequencyChart, generatorType: GeneratorType.BuiltIn, builtInRandomArray);
                ClearCharts();
                CreateChart(frequencyChart, generatorType: GeneratorType.BuiltIn, builtInRandom.GetValueProbabilityDictionary());
            }

            else if (ownGeneratorTypeRadioButton.Checked)
            {
                OwnRandom ownRandom = new OwnRandom(sequenceLength);
                ownRandomArray = ownRandom.GenerateRandomArray(0, 99);
                CreateChart(valueChart, generatorType: GeneratorType.Own, ownRandomArray);
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

        private void CreateChart(Chart chart, GeneratorType generatorType, Dictionary<int, double> data)
        {
            if (generatorType == GeneratorType.BuiltIn)
            {
                foreach (KeyValuePair<int, double> keyValuePair in data)
                {
                    chart.Series[0].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
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
    }
}
