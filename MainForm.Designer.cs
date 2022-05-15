
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.noGeneratorRadioButton = new System.Windows.Forms.RadioButton();
            this.pointsSquareChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculatePiButton = new System.Windows.Forms.Button();
            this.noPointsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSquareChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина последовательности";
            // 
            // sequenceLengthTextBox
            // 
            this.sequenceLengthTextBox.Location = new System.Drawing.Point(15, 28);
            this.sequenceLengthTextBox.Name = "sequenceLengthTextBox";
            this.sequenceLengthTextBox.Size = new System.Drawing.Size(212, 20);
            this.sequenceLengthTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Генератор";
            // 
            // builtInGeneratorTypeRadioButton
            // 
            this.builtInGeneratorTypeRadioButton.AutoSize = true;
            this.builtInGeneratorTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.builtInGeneratorTypeRadioButton.Location = new System.Drawing.Point(15, 106);
            this.builtInGeneratorTypeRadioButton.Name = "builtInGeneratorTypeRadioButton";
            this.builtInGeneratorTypeRadioButton.Size = new System.Drawing.Size(97, 17);
            this.builtInGeneratorTypeRadioButton.TabIndex = 3;
            this.builtInGeneratorTypeRadioButton.TabStop = true;
            this.builtInGeneratorTypeRadioButton.Text = "Встроенный";
            this.builtInGeneratorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ownGeneratorTypeRadioButton
            // 
            this.ownGeneratorTypeRadioButton.AutoSize = true;
            this.ownGeneratorTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownGeneratorTypeRadioButton.Location = new System.Drawing.Point(15, 129);
            this.ownGeneratorTypeRadioButton.Name = "ownGeneratorTypeRadioButton";
            this.ownGeneratorTypeRadioButton.Size = new System.Drawing.Size(104, 17);
            this.ownGeneratorTypeRadioButton.TabIndex = 4;
            this.ownGeneratorTypeRadioButton.TabStop = true;
            this.ownGeneratorTypeRadioButton.Text = "Собственный";
            this.ownGeneratorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статистика";
            // 
            // statsTextBox
            // 
            this.statsTextBox.Location = new System.Drawing.Point(15, 171);
            this.statsTextBox.Multiline = true;
            this.statsTextBox.Name = "statsTextBox";
            this.statsTextBox.Size = new System.Drawing.Size(212, 187);
            this.statsTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(15, 364);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(212, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Запуск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(15, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(212, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(15, 422);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(212, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // frequencyChart
            // 
            chartArea4.Name = "ChartArea1";
            this.frequencyChart.ChartAreas.Add(chartArea4);
            legend3.Name = "Legend1";
            this.frequencyChart.Legends.Add(legend3);
            this.frequencyChart.Location = new System.Drawing.Point(233, 12);
            this.frequencyChart.Name = "frequencyChart";
            this.frequencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.frequencyChart.Series.Add(series4);
            this.frequencyChart.Size = new System.Drawing.Size(555, 210);
            this.frequencyChart.TabIndex = 10;
            this.frequencyChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "Относительные частоты появления значений";
            this.frequencyChart.Titles.Add(title4);
            // 
            // valueChart
            // 
            chartArea5.Name = "ChartArea1";
            this.valueChart.ChartAreas.Add(chartArea5);
            legend4.Name = "Legend1";
            this.valueChart.Legends.Add(legend4);
            this.valueChart.Location = new System.Drawing.Point(233, 235);
            this.valueChart.Name = "valueChart";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.valueChart.Series.Add(series5);
            this.valueChart.Size = new System.Drawing.Size(555, 210);
            this.valueChart.TabIndex = 11;
            this.valueChart.Text = "chart2";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.Name = "Title1";
            title5.Text = "Интегральная функция распределения";
            this.valueChart.Titles.Add(title5);
            // 
            // noGeneratorRadioButton
            // 
            this.noGeneratorRadioButton.AutoSize = true;
            this.noGeneratorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noGeneratorRadioButton.Location = new System.Drawing.Point(15, 67);
            this.noGeneratorRadioButton.Name = "noGeneratorRadioButton";
            this.noGeneratorRadioButton.Size = new System.Drawing.Size(171, 17);
            this.noGeneratorRadioButton.TabIndex = 12;
            this.noGeneratorRadioButton.TabStop = true;
            this.noGeneratorRadioButton.Text = "Фиксированные данные";
            this.noGeneratorRadioButton.UseVisualStyleBackColor = true;
            // 
            // pointsSquareChart
            // 
            chartArea6.Name = "ChartArea1";
            this.pointsSquareChart.ChartAreas.Add(chartArea6);
            this.pointsSquareChart.Location = new System.Drawing.Point(797, 9);
            this.pointsSquareChart.Name = "pointsSquareChart";
            this.pointsSquareChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.IsVisibleInLegend = false;
            series6.Name = "Series1";
            this.pointsSquareChart.Series.Add(series6);
            this.pointsSquareChart.Size = new System.Drawing.Size(275, 275);
            this.pointsSquareChart.TabIndex = 13;
            this.pointsSquareChart.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.Name = "Title1";
            title6.Text = "Квадрат значений";
            this.pointsSquareChart.Titles.Add(title6);
            // 
            // calculatePiButton
            // 
            this.calculatePiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatePiButton.Location = new System.Drawing.Point(797, 290);
            this.calculatePiButton.Name = "calculatePiButton";
            this.calculatePiButton.Size = new System.Drawing.Size(275, 23);
            this.calculatePiButton.TabIndex = 14;
            this.calculatePiButton.Text = "Посчитать число pi";
            this.calculatePiButton.UseVisualStyleBackColor = true;
            this.calculatePiButton.Click += new System.EventHandler(this.calculatePiButton_Click);
            // 
            // noPointsCheckBox
            // 
            this.noPointsCheckBox.AutoSize = true;
            this.noPointsCheckBox.Location = new System.Drawing.Point(797, 319);
            this.noPointsCheckBox.Name = "noPointsCheckBox";
            this.noPointsCheckBox.Size = new System.Drawing.Size(186, 17);
            this.noPointsCheckBox.TabIndex = 15;
            this.noPointsCheckBox.Text = "Не отображать точки (быстрее)";
            this.noPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.noPointsCheckBox);
            this.Controls.Add(this.calculatePiButton);
            this.Controls.Add(this.pointsSquareChart);
            this.Controls.Add(this.noGeneratorRadioButton);
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
        private System.Windows.Forms.RadioButton noGeneratorRadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointsSquareChart;
        private System.Windows.Forms.Button calculatePiButton;
        private System.Windows.Forms.CheckBox noPointsCheckBox;
    }
}

