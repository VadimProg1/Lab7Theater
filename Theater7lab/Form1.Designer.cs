
namespace Theater7lab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_partActorsMinSalary = new System.Windows.Forms.NumericUpDown();
            this.numeric_actorsPopularity = new System.Windows.Forms.NumericUpDown();
            this.numeric_financingPerMonth = new System.Windows.Forms.NumericUpDown();
            this.stop_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_partActorsMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_actorsPopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_financingPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numeric_partActorsMinSalary);
            this.splitContainer1.Panel1.Controls.Add(this.numeric_actorsPopularity);
            this.splitContainer1.Panel1.Controls.Add(this.numeric_financingPerMonth);
            this.splitContainer1.Panel1.Controls.Add(this.stop_button);
            this.splitContainer1.Panel1.Controls.Add(this.start_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Part of actors who works for minimal salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actors popularity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Financing per month";
            // 
            // numeric_partActorsMinSalary
            // 
            this.numeric_partActorsMinSalary.Location = new System.Drawing.Point(32, 399);
            this.numeric_partActorsMinSalary.Name = "numeric_partActorsMinSalary";
            this.numeric_partActorsMinSalary.Size = new System.Drawing.Size(120, 22);
            this.numeric_partActorsMinSalary.TabIndex = 4;
            // 
            // numeric_actorsPopularity
            // 
            this.numeric_actorsPopularity.Location = new System.Drawing.Point(32, 295);
            this.numeric_actorsPopularity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_actorsPopularity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_actorsPopularity.Name = "numeric_actorsPopularity";
            this.numeric_actorsPopularity.Size = new System.Drawing.Size(120, 22);
            this.numeric_actorsPopularity.TabIndex = 3;
            this.numeric_actorsPopularity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numeric_financingPerMonth
            // 
            this.numeric_financingPerMonth.Location = new System.Drawing.Point(32, 215);
            this.numeric_financingPerMonth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_financingPerMonth.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_financingPerMonth.Name = "numeric_financingPerMonth";
            this.numeric_financingPerMonth.Size = new System.Drawing.Size(120, 22);
            this.numeric_financingPerMonth.TabIndex = 2;
            this.numeric_financingPerMonth.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(54, 98);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 1;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(54, 38);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(581, 421);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_partActorsMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_actorsPopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_financingPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_partActorsMinSalary;
        private System.Windows.Forms.NumericUpDown numeric_actorsPopularity;
        private System.Windows.Forms.NumericUpDown numeric_financingPerMonth;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

