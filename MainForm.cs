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

        private const int maxChartSeriesPerRNGType = 3;

        private int builtInRNGFrequencyChartSeriesCount = 0;
        private int lehmerRNGFrequencyChartSeriesCount = 0;

        private int builtInRNGFunctionChartSeriesCount = 0;
        private int lehmerRNGFunctionChartSeriesCount = 0;

        List<PointF> squarePoints = new List<PointF>();
        private Color color = Color.Red;
        private int linesThickness = 35;

        public MainForm()
        {
            InitializeComponent();
        }

        private enum GeneratorType
        {
            BuiltIn,
            Lehmer
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            sequenceLength = TryParseInt(sequenceLengthTextBox.Text);
            Random rand = new Random();
            int r = rand.Next(0, 255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);
            color = Color.FromArgb(255, r, g, b);

            if (builtInGeneratorTypeRadioButton.Checked)
            {
                BuiltInRandom builtInRandom = new BuiltInRandom(sequenceLength);
                builtInRandom.General();

                CreateChartSeries(frequencyChart, generatorType: GeneratorType.BuiltIn, isFrequencyChart: true, builtInRandom.GetValueProbabilityDictionary());
                CreateChartSeries(valueChart, generatorType: GeneratorType.BuiltIn, isFrequencyChart: false, builtInRandom.GetDistributionFunctionOfRandomVariableDictionary());

                ClearStats();
                CreateStats(mathExpectation: builtInRandom.GetMathExpectation(), dispersion: builtInRandom.GetDispersion(), standartDeviation: builtInRandom.GetStandartDeviation(), null);
            }

            else if (ownGeneratorTypeRadioButton.Checked)
            {
                int lehmerSeed = DateTime.Now.Second + DateTime.UtcNow.Hour;
                LehmerRNG lehmerRandom = new LehmerRNG(lehmerSeed, sequenceLength);
                lehmerRandom.General();

                CreateChartSeries(frequencyChart, generatorType: GeneratorType.Lehmer, isFrequencyChart: true, lehmerRandom.GetValueProbabilityDictionary());
                CreateChartSeries(valueChart, generatorType: GeneratorType.Lehmer, isFrequencyChart: false, lehmerRandom.GetDistributionFunctionOfRandomVariableDictionary());

                ClearStats();
                CreateStats(mathExpectation: lehmerRandom.GetMathExpectation(), dispersion: lehmerRandom.GetDispersion(), standartDeviation: lehmerRandom.GetStandartDeviation(), null);
            }

            else if (noGeneratorRadioButton.Checked) // Для дебагинга
            {
                FixedDataNoRandom noRandom = new FixedDataNoRandom();
                noRandom.General();

                CreateChartSeries(frequencyChart, generatorType: GeneratorType.BuiltIn, isFrequencyChart: true, noRandom.GetValueProbabilityDictionary());
                CreateChartSeries(valueChart, generatorType: GeneratorType.BuiltIn, isFrequencyChart: false, noRandom.GetDistributionFunctionOfRandomVariableDictionary());

                ClearStats();
                CreateStats(mathExpectation: noRandom.GetMathExpectation(), dispersion: noRandom.GetDispersion(), standartDeviation: noRandom.GetStandartDeviation(), null);
            }
        }

        private int TryParseInt(string text)
        {
            int value = 0;

            if (Int32.TryParse(text, out value))
            {
                sequenceLength = value;
            }

            return value;
        }

        private void CreateChartSeries(Chart chart, GeneratorType generatorType, bool isFrequencyChart, SortedDictionary<int, double> data)
        {
            if (generatorType == GeneratorType.BuiltIn)
            {
                if (isFrequencyChart)
                {
                    if (builtInRNGFrequencyChartSeriesCount < maxChartSeriesPerRNGType)
                        chart.Series.Add(builtInRNGFrequencyChartSeriesCount + " BuiltIn. Length: " + data.Count);
                    else
                        return;

                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[builtInRNGFrequencyChartSeriesCount].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                        chart.Series[builtInRNGFrequencyChartSeriesCount]["PixelPointWidth"] = linesThickness.ToString();
                        chart.Series[builtInRNGFrequencyChartSeriesCount].Color = color;
                    }
                    builtInRNGFrequencyChartSeriesCount++;
                }
                else if (!isFrequencyChart)
                {
                    if (builtInRNGFunctionChartSeriesCount < maxChartSeriesPerRNGType)
                        chart.Series.Add(builtInRNGFunctionChartSeriesCount + " BuiltIn. Length: " + data.Count);
                    else
                        return;

                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[builtInRNGFunctionChartSeriesCount].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                        chart.Series[builtInRNGFunctionChartSeriesCount]["PixelPointWidth"] = linesThickness.ToString();
                        chart.Series[builtInRNGFunctionChartSeriesCount].Color = color;
                    }
                    builtInRNGFunctionChartSeriesCount++;
                }
            }

            else if (generatorType == GeneratorType.Lehmer)
            {
                if (isFrequencyChart)
                {
                    if (lehmerRNGFrequencyChartSeriesCount < maxChartSeriesPerRNGType)
                        chart.Series.Add(lehmerRNGFrequencyChartSeriesCount + " LehmerRNG. Length: " + data.Count);
                    else
                        return;

                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[lehmerRNGFrequencyChartSeriesCount].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                        chart.Series[lehmerRNGFrequencyChartSeriesCount]["PixelPointWidth"] = linesThickness.ToString();
                        chart.Series[lehmerRNGFrequencyChartSeriesCount].Color = color;
                    }
                    lehmerRNGFrequencyChartSeriesCount++;
                }
                else if (!isFrequencyChart)
                {
                    if (lehmerRNGFunctionChartSeriesCount < maxChartSeriesPerRNGType)
                        chart.Series.Add(lehmerRNGFunctionChartSeriesCount + " LehmerRNG. Length: " + data.Count);
                    else
                        return;

                    foreach (KeyValuePair<int, double> keyValuePair in data)
                    {
                        chart.Series[lehmerRNGFunctionChartSeriesCount].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
                        chart.Series[lehmerRNGFunctionChartSeriesCount]["PixelPointWidth"] = linesThickness.ToString();
                        chart.Series[lehmerRNGFunctionChartSeriesCount].Color = color;
                    }
                    lehmerRNGFunctionChartSeriesCount++;
                }
            }
        }
        private void ClearCharts()
        {
            valueChart.Series.Clear();
            frequencyChart.Series.Clear();
            pointsSquareChart.Series[0].Points.Clear();

            builtInRNGFrequencyChartSeriesCount = 0;
            lehmerRNGFrequencyChartSeriesCount = 0;
            builtInRNGFunctionChartSeriesCount = 0;
            lehmerRNGFunctionChartSeriesCount = 0;
        }
    
        private void CreateStats(double? mathExpectation, double? dispersion, double? standartDeviation, decimal? calculatedPiValue)
        {
            string mathExpectationString = "Математическое ожидание случайной величины: " + mathExpectation;
            string dispersionString = "Дисперсия случайной величины: " + dispersion;
            string standartDeviationString = "Средневадратичное отклонение (стандартное отклонение): " + standartDeviation;
            string calculatedPiValueString = "Вычисленное значение числа Pi: " + calculatedPiValue;
            statsTextBox.Text = mathExpectationString + Environment.NewLine +
                                Environment.NewLine + dispersionString +
                                Environment.NewLine + Environment.NewLine +
                                standartDeviationString + Environment.NewLine
                                + Environment.NewLine + calculatedPiValueString;
        }

        private void ClearStats()
        {
            statsTextBox.Text = String.Empty;
        }

        private void CreateSquareOfPointsList(GeneratorType generatorType)
        {
            LehmerRNG lehmerRNG = new LehmerRNG(DateTime.Now.Second + DateTime.UtcNow.Hour, sequenceLength);
            Random builtInRNG = new Random();

            for (int i = 0; i < sequenceLength; i++)
            {
                if (generatorType == GeneratorType.Lehmer)
                {
                    squarePoints.Add(new PointF((float)lehmerRNG.Next(), (float)lehmerRNG.Next()));
                }
                else
                {
                    squarePoints.Add(new PointF((float)builtInRNG.NextDouble(), (float)builtInRNG.NextDouble()));
                }
            }
        }
        
        private void ClearSquareOfPointsList()
        {
            squarePoints.Clear();
        }

        private void CreateSquareOfPointsChart(List<PointF> points)
        {
            pointsSquareChart.Series[0].Points.Clear();

            foreach (var point in points)
            {
                pointsSquareChart.Series[0].Points.AddXY(point.X, point.Y);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearCharts();
            ClearStats();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void calculatePiButton_Click(object sender, EventArgs e)
        {
            if (builtInGeneratorTypeRadioButton.Checked)
            {
                sequenceLength = TryParseInt(sequenceLengthTextBox.Text);
                ClearSquareOfPointsList();
                CreateSquareOfPointsList(generatorType: GeneratorType.BuiltIn);

                if (!noPointsCheckBox.Checked)
                {
                    CreateSquareOfPointsChart(squarePoints);
                }

                CalculatePi calculatePi = new CalculatePi(squarePoints);

                ClearStats();
                CreateStats(null, null, null, calculatePi.GetCalculatedPiValue());
            }
            else if (ownGeneratorTypeRadioButton.Checked)
            {
                sequenceLength = TryParseInt(sequenceLengthTextBox.Text);
                ClearSquareOfPointsList();
                CreateSquareOfPointsList(generatorType:GeneratorType.Lehmer);

                if (!noPointsCheckBox.Checked)
                {
                    CreateSquareOfPointsChart(squarePoints);
                }

                CalculatePi calculatePi = new CalculatePi(squarePoints);

                ClearStats();
                CreateStats(null, null, null, calculatePi.GetCalculatedPiValue());
            }
        }
    }
}
