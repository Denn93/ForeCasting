namespace INDTA01_2.DennisBrian.CaseStudy3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOptimal = new System.Windows.Forms.Button();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.btnPlotAlpha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblStdError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBetaDes = new System.Windows.Forms.TextBox();
            this.txtAlphaDes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBeta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea2.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.mainChart.Legends.Add(legend2);
            this.mainChart.Location = new System.Drawing.Point(-2, 1);
            this.mainChart.Name = "mainChart";
            this.mainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Original";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "SES";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "DES";
            this.mainChart.Series.Add(series4);
            this.mainChart.Series.Add(series5);
            this.mainChart.Series.Add(series6);
            this.mainChart.Size = new System.Drawing.Size(548, 391);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "Chart";
            // 
            // btnOptimal
            // 
            this.btnOptimal.Location = new System.Drawing.Point(379, 412);
            this.btnOptimal.Name = "btnOptimal";
            this.btnOptimal.Size = new System.Drawing.Size(167, 39);
            this.btnOptimal.TabIndex = 1;
            this.btnOptimal.Text = "Plot SES";
            this.btnOptimal.UseVisualStyleBackColor = true;
            this.btnOptimal.Click += new System.EventHandler(this.btnOptimal_Click);
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(-2, 392);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(122, 20);
            this.txtAlpha.TabIndex = 2;
            // 
            // btnPlotAlpha
            // 
            this.btnPlotAlpha.Location = new System.Drawing.Point(-2, 412);
            this.btnPlotAlpha.Name = "btnPlotAlpha";
            this.btnPlotAlpha.Size = new System.Drawing.Size(122, 39);
            this.btnPlotAlpha.TabIndex = 3;
            this.btnPlotAlpha.Text = "Plot SES";
            this.btnPlotAlpha.UseVisualStyleBackColor = true;
            this.btnPlotAlpha.Click += new System.EventHandler(this.btnPlotAlpha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter alpha value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calculate with optimal  alpha value";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(426, 221);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(77, 13);
            this.lblAlpha.TabIndex = 6;
            this.lblAlpha.Text = "Optimal alpha: ";
            // 
            // lblStdError
            // 
            this.lblStdError.AutoSize = true;
            this.lblStdError.Location = new System.Drawing.Point(422, 267);
            this.lblStdError.Name = "lblStdError";
            this.lblStdError.Size = new System.Drawing.Size(81, 13);
            this.lblStdError.TabIndex = 7;
            this.lblStdError.Text = "Standard Error: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBetaDes);
            this.groupBox2.Controls.Add(this.txtAlphaDes);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(-2, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Calculate with optimal alpha and beta value";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Plot DES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter beta value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter alpha value";
            // 
            // txtBetaDes
            // 
            this.txtBetaDes.Location = new System.Drawing.Point(3, 42);
            this.txtBetaDes.Name = "txtBetaDes";
            this.txtBetaDes.Size = new System.Drawing.Size(119, 20);
            this.txtBetaDes.TabIndex = 2;
            // 
            // txtAlphaDes
            // 
            this.txtAlphaDes.Location = new System.Drawing.Point(3, 16);
            this.txtAlphaDes.Name = "txtAlphaDes";
            this.txtAlphaDes.Size = new System.Drawing.Size(119, 20);
            this.txtAlphaDes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Plot DES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPlotAlphaBeta_Click);
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(426, 244);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(72, 13);
            this.lblBeta.TabIndex = 10;
            this.lblBeta.Text = "Optimal beta: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 551);
            this.Controls.Add(this.lblBeta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblStdError);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlotAlpha);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.btnOptimal);
            this.Controls.Add(this.mainChart);
            this.Name = "Form1";
            this.Text = "INFDTA01-2 CaseStudy 3: Forecasting";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button btnOptimal;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Button btnPlotAlpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblStdError;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBetaDes;
        private System.Windows.Forms.TextBox txtAlphaDes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBeta;
    }
}

