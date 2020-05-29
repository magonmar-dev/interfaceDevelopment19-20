namespace capa_presentacion
{
    partial class Estadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTipo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sinDatosDia = new System.Windows.Forms.Label();
            this.sinDatosTipo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMes
            // 
            this.dtpMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.Location = new System.Drawing.Point(223, 30);
            this.dtpMes.MaxDate = new System.DateTime(2020, 5, 26, 0, 0, 0, 0);
            this.dtpMes.MinDate = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.ShowUpDown = true;
            this.dtpMes.Size = new System.Drawing.Size(222, 28);
            this.dtpMes.TabIndex = 2;
            this.dtpMes.Value = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            this.dtpMes.ValueChanged += new System.EventHandler(this.dtpMes_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(29, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "SELECCIONAR MES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpMes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 83);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sinDatosTipo);
            this.groupBox2.Controls.Add(this.sinDatosDia);
            this.groupBox2.Controls.Add(this.chartTipo);
            this.groupBox2.Controls.Add(this.chartDia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1230, 652);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(835, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "PEDIDOS POR TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "PEDIDOS POR DÍA";
            // 
            // chartDia
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDia.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDia.Legends.Add(legend4);
            this.chartDia.Location = new System.Drawing.Point(33, 73);
            this.chartDia.Name = "chartDia";
            this.chartDia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDia.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))))};
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDia.Series.Add(series4);
            this.chartDia.Size = new System.Drawing.Size(570, 544);
            this.chartDia.TabIndex = 21;
            // 
            // chartTipo
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTipo.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTipo.Legends.Add(legend3);
            this.chartTipo.Location = new System.Drawing.Point(632, 73);
            this.chartTipo.Name = "chartTipo";
            this.chartTipo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTipo.Series.Add(series3);
            this.chartTipo.Size = new System.Drawing.Size(570, 544);
            this.chartTipo.TabIndex = 22;
            this.chartTipo.Text = "chart1";
            // 
            // sinDatosDia
            // 
            this.sinDatosDia.AutoSize = true;
            this.sinDatosDia.BackColor = System.Drawing.Color.White;
            this.sinDatosDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinDatosDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.sinDatosDia.Location = new System.Drawing.Point(197, 307);
            this.sinDatosDia.Name = "sinDatosDia";
            this.sinDatosDia.Size = new System.Drawing.Size(211, 39);
            this.sinDatosDia.TabIndex = 23;
            this.sinDatosDia.Text = "SIN DATOS";
            this.sinDatosDia.Visible = false;
            // 
            // sinDatosTipo
            // 
            this.sinDatosTipo.AutoSize = true;
            this.sinDatosTipo.BackColor = System.Drawing.Color.White;
            this.sinDatosTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinDatosTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.sinDatosTipo.Location = new System.Drawing.Point(818, 307);
            this.sinDatosTipo.Name = "sinDatosTipo";
            this.sinDatosTipo.Size = new System.Drawing.Size(211, 39);
            this.sinDatosTipo.TabIndex = 24;
            this.sinDatosTipo.Text = "SIN DATOS";
            this.sinDatosTipo.Visible = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1254, 778);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTipo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDia;
        private System.Windows.Forms.Label sinDatosTipo;
        private System.Windows.Forms.Label sinDatosDia;
    }
}