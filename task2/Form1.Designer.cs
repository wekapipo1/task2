namespace task2
{
    partial class frmDiagrams
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.txtMasGist = new System.Windows.Forms.TextBox();
            this.txtMasRound = new System.Windows.Forms.TextBox();
            this.txtMinAge = new System.Windows.Forms.TextBox();
            this.dgvMasGist = new System.Windows.Forms.DataGridView();
            this.dgvMasRound = new System.Windows.Forms.DataGridView();
            this.chartDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateMasGist = new System.Windows.Forms.Button();
            this.btCreateMasRound = new System.Windows.Forms.Button();
            this.btCreateGist = new System.Windows.Forms.Button();
            this.btCreateRound = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCreateMasGist);
            this.groupBox1.Controls.Add(this.dgvMasGist);
            this.groupBox1.Controls.Add(this.txtMasGist);
            this.groupBox1.Controls.Add(this.txtMinYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(678, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(622, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані для гістограми";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCreateMasRound);
            this.groupBox2.Controls.Add(this.dgvMasRound);
            this.groupBox2.Controls.Add(this.txtMinAge);
            this.groupBox2.Controls.Add(this.txtMasRound);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(678, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(622, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дані для кругової діаграми";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть початковий рік:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть кількість років:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 53);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введіть кількість вікових категорій:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Введіть мінімальний вік:";
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(238, 34);
            this.txtMinYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(111, 26);
            this.txtMinYear.TabIndex = 2;
            this.txtMinYear.TextChanged += new System.EventHandler(this.txtMinYear_TextChanged);
            // 
            // txtMasGist
            // 
            this.txtMasGist.Location = new System.Drawing.Point(238, 77);
            this.txtMasGist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMasGist.Name = "txtMasGist";
            this.txtMasGist.Size = new System.Drawing.Size(111, 26);
            this.txtMasGist.TabIndex = 3;
            // 
            // txtMasRound
            // 
            this.txtMasRound.Location = new System.Drawing.Point(238, 41);
            this.txtMasRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMasRound.Name = "txtMasRound";
            this.txtMasRound.Size = new System.Drawing.Size(111, 26);
            this.txtMasRound.TabIndex = 2;
            // 
            // txtMinAge
            // 
            this.txtMinAge.Location = new System.Drawing.Point(238, 85);
            this.txtMinAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.Size = new System.Drawing.Size(111, 26);
            this.txtMinAge.TabIndex = 3;
            // 
            // dgvMasGist
            // 
            this.dgvMasGist.AllowUserToOrderColumns = true;
            this.dgvMasGist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasGist.Location = new System.Drawing.Point(22, 126);
            this.dgvMasGist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMasGist.Name = "dgvMasGist";
            this.dgvMasGist.RowHeadersWidth = 51;
            this.dgvMasGist.RowTemplate.Height = 24;
            this.dgvMasGist.Size = new System.Drawing.Size(554, 127);
            this.dgvMasGist.TabIndex = 4;
            // 
            // dgvMasRound
            // 
            this.dgvMasRound.AllowUserToOrderColumns = true;
            this.dgvMasRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasRound.Location = new System.Drawing.Point(22, 134);
            this.dgvMasRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMasRound.Name = "dgvMasRound";
            this.dgvMasRound.RowHeadersWidth = 51;
            this.dgvMasRound.RowTemplate.Height = 24;
            this.dgvMasRound.Size = new System.Drawing.Size(554, 94);
            this.dgvMasRound.TabIndex = 4;
            // 
            // chartDiagrams
            // 
            this.chartDiagrams.BackColor = System.Drawing.Color.PeachPuff;
            this.chartDiagrams.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartDiagrams.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(72)))), ((int)(((byte)(120)))));
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chartDiagrams.ChartAreas.Add(chartArea1);
            this.chartDiagrams.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartDiagrams.Legends.Add(legend1);
            this.chartDiagrams.Legends.Add(legend2);
            this.chartDiagrams.Location = new System.Drawing.Point(13, 11);
            this.chartDiagrams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartDiagrams.Name = "chartDiagrams";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Кількість учнів";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Sector";
            this.chartDiagrams.Series.Add(series1);
            this.chartDiagrams.Series.Add(series2);
            this.chartDiagrams.Size = new System.Drawing.Size(659, 532);
            this.chartDiagrams.TabIndex = 2;
            this.chartDiagrams.Text = "chart1";
            // 
            // btCreateMasGist
            // 
            this.btCreateMasGist.Location = new System.Drawing.Point(374, 40);
            this.btCreateMasGist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCreateMasGist.Name = "btCreateMasGist";
            this.btCreateMasGist.Size = new System.Drawing.Size(202, 60);
            this.btCreateMasGist.TabIndex = 5;
            this.btCreateMasGist.Text = "Згенерувати порожній масив";
            this.btCreateMasGist.UseVisualStyleBackColor = true;
            this.btCreateMasGist.Click += new System.EventHandler(this.btCreateMasGist_Click);
            // 
            // btCreateMasRound
            // 
            this.btCreateMasRound.Location = new System.Drawing.Point(374, 41);
            this.btCreateMasRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCreateMasRound.Name = "btCreateMasRound";
            this.btCreateMasRound.Size = new System.Drawing.Size(202, 60);
            this.btCreateMasRound.TabIndex = 5;
            this.btCreateMasRound.Text = "Згенерувати порожній масив";
            this.btCreateMasRound.UseVisualStyleBackColor = true;
            this.btCreateMasRound.Click += new System.EventHandler(this.btCreateMasRound_Click);
            // 
            // btCreateGist
            // 
            this.btCreateGist.Location = new System.Drawing.Point(35, 566);
            this.btCreateGist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCreateGist.Name = "btCreateGist";
            this.btCreateGist.Size = new System.Drawing.Size(267, 60);
            this.btCreateGist.TabIndex = 3;
            this.btCreateGist.Text = "Побудувати гістограму";
            this.btCreateGist.UseVisualStyleBackColor = true;
            this.btCreateGist.Click += new System.EventHandler(this.btCreateGist_Click);
            // 
            // btCreateRound
            // 
            this.btCreateRound.Location = new System.Drawing.Point(369, 566);
            this.btCreateRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCreateRound.Name = "btCreateRound";
            this.btCreateRound.Size = new System.Drawing.Size(268, 60);
            this.btCreateRound.TabIndex = 4;
            this.btCreateRound.Text = "Побудувати секторну діаграму";
            this.btCreateRound.UseVisualStyleBackColor = true;
            this.btCreateRound.Click += new System.EventHandler(this.btCreateRound_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(916, 566);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(152, 60);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmDiagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 664);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCreateRound);
            this.Controls.Add(this.btCreateGist);
            this.Controls.Add(this.chartDiagrams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDiagrams";
            this.Text = "Діаграми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCreateMasGist;
        private System.Windows.Forms.DataGridView dgvMasGist;
        private System.Windows.Forms.TextBox txtMasGist;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCreateMasRound;
        private System.Windows.Forms.DataGridView dgvMasRound;
        private System.Windows.Forms.TextBox txtMinAge;
        private System.Windows.Forms.TextBox txtMasRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagrams;
        private System.Windows.Forms.Button btCreateGist;
        private System.Windows.Forms.Button btCreateRound;
        private System.Windows.Forms.Button btExit;
    }
}

