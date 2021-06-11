namespace Lab18
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edNumber = new System.Windows.Forms.NumericUpDown();
            this.edT = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edLambda = new System.Windows.Forms.NumericUpDown();
            this.edMu = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.edOperators = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.edNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOperators)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simmulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time=";
            // 
            // edNumber
            // 
            this.edNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edNumber.Location = new System.Drawing.Point(780, 125);
            this.edNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edNumber.Name = "edNumber";
            this.edNumber.Size = new System.Drawing.Size(47, 20);
            this.edNumber.TabIndex = 3;
            this.edNumber.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // edT
            // 
            this.edT.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edT.Location = new System.Drawing.Point(780, 151);
            this.edT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edT.Name = "edT";
            this.edT.Size = new System.Drawing.Size(47, 20);
            this.edT.TabIndex = 4;
            this.edT.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "λ=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "μ=";
            // 
            // edLambda
            // 
            this.edLambda.DecimalPlaces = 2;
            this.edLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edLambda.Location = new System.Drawing.Point(780, 177);
            this.edLambda.Name = "edLambda";
            this.edLambda.Size = new System.Drawing.Size(47, 20);
            this.edLambda.TabIndex = 7;
            this.edLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edMu
            // 
            this.edMu.DecimalPlaces = 2;
            this.edMu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edMu.Location = new System.Drawing.Point(780, 203);
            this.edMu.Name = "edMu";
            this.edMu.Size = new System.Drawing.Size(47, 20);
            this.edMu.TabIndex = 8;
            this.edMu.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-1, 54);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(321, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(326, 54);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(342, 300);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Operators=";
            // 
            // edOperators
            // 
            this.edOperators.Location = new System.Drawing.Point(780, 229);
            this.edOperators.Name = "edOperators";
            this.edOperators.Size = new System.Drawing.Size(47, 20);
            this.edOperators.TabIndex = 13;
            this.edOperators.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 354);
            this.Controls.Add(this.edOperators);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.edMu);
            this.Controls.Add(this.edLambda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edT);
            this.Controls.Add(this.edNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edOperators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edNumber;
        private System.Windows.Forms.NumericUpDown edT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edLambda;
        private System.Windows.Forms.NumericUpDown edMu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edOperators;
    }
}

