
namespace GeneratorResearchPseudorandomNumbers
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.sequenceLengthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.builtInGeneratorTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.ownGeneratorTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.statsTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.frequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.valueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pointsSquareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculatePiButton = new System.Windows.Forms.Button();
            this.noPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.muTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sigmaTextBox = new System.Windows.Forms.TextBox();
            this.normalDistributionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSquareChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина последовательности";
            // 
            // sequenceLengthTextBox
            // 
            this.sequenceLengthTextBox.Location = new System.Drawing.Point(20, 34);
            this.sequenceLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sequenceLengthTextBox.Name = "sequenceLengthTextBox";
            this.sequenceLengthTextBox.Size = new System.Drawing.Size(281, 22);
            this.sequenceLengthTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Генератор";
            // 
            // builtInGeneratorTypeRadioButton
            // 
            this.builtInGeneratorTypeRadioButton.AutoSize = true;
            this.builtInGeneratorTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.builtInGeneratorTypeRadioButton.Location = new System.Drawing.Point(20, 84);
            this.builtInGeneratorTypeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.builtInGeneratorTypeRadioButton.Name = "builtInGeneratorTypeRadioButton";
            this.builtInGeneratorTypeRadioButton.Size = new System.Drawing.Size(120, 21);
            this.builtInGeneratorTypeRadioButton.TabIndex = 3;
            this.builtInGeneratorTypeRadioButton.TabStop = true;
            this.builtInGeneratorTypeRadioButton.Text = "Встроенный";
            this.builtInGeneratorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ownGeneratorTypeRadioButton
            // 
            this.ownGeneratorTypeRadioButton.AutoSize = true;
            this.ownGeneratorTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownGeneratorTypeRadioButton.Location = new System.Drawing.Point(20, 106);
            this.ownGeneratorTypeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ownGeneratorTypeRadioButton.Name = "ownGeneratorTypeRadioButton";
            this.ownGeneratorTypeRadioButton.Size = new System.Drawing.Size(128, 21);
            this.ownGeneratorTypeRadioButton.TabIndex = 4;
            this.ownGeneratorTypeRadioButton.TabStop = true;
            this.ownGeneratorTypeRadioButton.Text = "Собственный";
            this.ownGeneratorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статистика";
            // 
            // statsTextBox
            // 
            this.statsTextBox.Location = new System.Drawing.Point(20, 234);
            this.statsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statsTextBox.Multiline = true;
            this.statsTextBox.Name = "statsTextBox";
            this.statsTextBox.Size = new System.Drawing.Size(281, 205);
            this.statsTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(20, 448);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(283, 28);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Запуск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(20, 484);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(283, 28);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(20, 519);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(283, 28);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // frequencyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.frequencyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frequencyChart.Legends.Add(legend1);
            this.frequencyChart.Location = new System.Drawing.Point(311, 15);
            this.frequencyChart.Margin = new System.Windows.Forms.Padding(4);
            this.frequencyChart.Name = "frequencyChart";
            this.frequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.frequencyChart.Series.Add(series1);
            this.frequencyChart.Size = new System.Drawing.Size(740, 258);
            this.frequencyChart.TabIndex = 10;
            this.frequencyChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Относительные частоты появления значений";
            this.frequencyChart.Titles.Add(title1);
            // 
            // valueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.valueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.valueChart.Legends.Add(legend2);
            this.valueChart.Location = new System.Drawing.Point(311, 289);
            this.valueChart.Margin = new System.Windows.Forms.Padding(4);
            this.valueChart.Name = "valueChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.valueChart.Series.Add(series2);
            this.valueChart.Size = new System.Drawing.Size(740, 258);
            this.valueChart.TabIndex = 11;
            this.valueChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Интегральная функция распределения";
            this.valueChart.Titles.Add(title2);
            // 
            // pointsSquareChart
            // 
            chartArea3.Name = "ChartArea1";
            this.pointsSquareChart.ChartAreas.Add(chartArea3);
            this.pointsSquareChart.Location = new System.Drawing.Point(1063, 11);
            this.pointsSquareChart.Margin = new System.Windows.Forms.Padding(4);
            this.pointsSquareChart.Name = "pointsSquareChart";
            this.pointsSquareChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.pointsSquareChart.Series.Add(series3);
            this.pointsSquareChart.Size = new System.Drawing.Size(367, 338);
            this.pointsSquareChart.TabIndex = 13;
            this.pointsSquareChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Квадрат значений";
            this.pointsSquareChart.Titles.Add(title3);
            // 
            // calculatePiButton
            // 
            this.calculatePiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatePiButton.Location = new System.Drawing.Point(1063, 357);
            this.calculatePiButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculatePiButton.Name = "calculatePiButton";
            this.calculatePiButton.Size = new System.Drawing.Size(367, 28);
            this.calculatePiButton.TabIndex = 14;
            this.calculatePiButton.Text = "Посчитать число pi";
            this.calculatePiButton.UseVisualStyleBackColor = true;
            this.calculatePiButton.Click += new System.EventHandler(this.calculatePiButton_Click);
            // 
            // noPointsCheckBox
            // 
            this.noPointsCheckBox.AutoSize = true;
            this.noPointsCheckBox.Location = new System.Drawing.Point(1063, 393);
            this.noPointsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.noPointsCheckBox.Name = "noPointsCheckBox";
            this.noPointsCheckBox.Size = new System.Drawing.Size(235, 20);
            this.noPointsCheckBox.TabIndex = 15;
            this.noPointsCheckBox.Text = "Не отображать точки (быстрее)";
            this.noPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // muTextBox
            // 
            this.muTextBox.Location = new System.Drawing.Point(162, 154);
            this.muTextBox.Name = "muTextBox";
            this.muTextBox.Size = new System.Drawing.Size(100, 22);
            this.muTextBox.TabIndex = 16;
            this.muTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(104, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "mu =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(79, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "sigma =";
            // 
            // sigmaTextBox
            // 
            this.sigmaTextBox.Location = new System.Drawing.Point(162, 182);
            this.sigmaTextBox.Name = "sigmaTextBox";
            this.sigmaTextBox.Size = new System.Drawing.Size(100, 22);
            this.sigmaTextBox.TabIndex = 18;
            this.sigmaTextBox.Text = "1";
            // 
            // normalDistributionCheckBox
            // 
            this.normalDistributionCheckBox.AutoSize = true;
            this.normalDistributionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalDistributionCheckBox.Location = new System.Drawing.Point(21, 128);
            this.normalDistributionCheckBox.Name = "normalDistributionCheckBox";
            this.normalDistributionCheckBox.Size = new System.Drawing.Size(241, 20);
            this.normalDistributionCheckBox.TabIndex = 20;
            this.normalDistributionCheckBox.Text = "Нормальное распределение";
            this.normalDistributionCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 554);
            this.Controls.Add(this.normalDistributionCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sigmaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.muTextBox);
            this.Controls.Add(this.noPointsCheckBox);
            this.Controls.Add(this.calculatePiButton);
            this.Controls.Add(this.pointsSquareChart);
            this.Controls.Add(this.valueChart);
            this.Controls.Add(this.frequencyChart);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ownGeneratorTypeRadioButton);
            this.Controls.Add(this.builtInGeneratorTypeRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sequenceLengthTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frequencyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSquareChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sequenceLengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton builtInGeneratorTypeRadioButton;
        private System.Windows.Forms.RadioButton ownGeneratorTypeRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statsTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart frequencyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart valueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointsSquareChart;
        private System.Windows.Forms.Button calculatePiButton;
        private System.Windows.Forms.CheckBox noPointsCheckBox;
        private System.Windows.Forms.TextBox muTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sigmaTextBox;
        private System.Windows.Forms.CheckBox normalDistributionCheckBox;
    }
}

