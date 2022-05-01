
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
            ((System.ComponentModel.ISupportInitialize)(this.frequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
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
            this.label2.Size = new System.Drawing.Size(87, 16);
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
            this.label3.Size = new System.Drawing.Size(94, 16);
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
            // 
            // frequencyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.frequencyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frequencyChart.Legends.Add(legend1);
            this.frequencyChart.Location = new System.Drawing.Point(233, 12);
            this.frequencyChart.Name = "frequencyChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 0;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.frequencyChart.Series.Add(series1);
            this.frequencyChart.Size = new System.Drawing.Size(555, 210);
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
            this.valueChart.Location = new System.Drawing.Point(233, 235);
            this.valueChart.Name = "valueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.valueChart.Series.Add(series2);
            this.valueChart.Size = new System.Drawing.Size(555, 210);
            this.valueChart.TabIndex = 11;
            this.valueChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Интегральная функция распределения";
            this.valueChart.Titles.Add(title2);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

