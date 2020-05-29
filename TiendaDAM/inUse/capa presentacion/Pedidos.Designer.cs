namespace capa_presentacion
{
    partial class Pedidos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.dtpFechaB = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txbUsuB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalSinIVA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLinped = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbArt = new System.Windows.Forms.ComboBox();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsu = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEli = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetFilters);
            this.groupBox2.Controls.Add(this.dtpFechaB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbUsuB);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 138);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR PEDIDO";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetFilters.Location = new System.Drawing.Point(259, 40);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(91, 66);
            this.btnResetFilters.TabIndex = 3;
            this.btnResetFilters.Text = "BORRAR FILTROS";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // dtpFechaB
            // 
            this.dtpFechaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaB.Location = new System.Drawing.Point(105, 82);
            this.dtpFechaB.MaxDate = new System.DateTime(2020, 5, 26, 0, 0, 0, 0);
            this.dtpFechaB.MinDate = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            this.dtpFechaB.Name = "dtpFechaB";
            this.dtpFechaB.Size = new System.Drawing.Size(138, 27);
            this.dtpFechaB.TabIndex = 2;
            this.dtpFechaB.Value = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            this.dtpFechaB.ValueChanged += new System.EventHandler(this.dtpFechaB_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Usuario";
            // 
            // txbUsuB
            // 
            this.txbUsuB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsuB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuB.Location = new System.Drawing.Point(105, 34);
            this.txbUsuB.MaxLength = 35;
            this.txbUsuB.Name = "txbUsuB";
            this.txbUsuB.Size = new System.Drawing.Size(138, 27);
            this.txbUsuB.TabIndex = 1;
            this.txbUsuB.TextChanged += new System.EventHandler(this.txbUsuB_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Fecha";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 165);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPedidos.RowHeadersWidth = 25;
            this.dgvPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(368, 592);
            this.dgvPedidos.StandardTab = true;
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.Click += new System.EventHandler(this.dgvPedidos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEli);
            this.groupBox1.Controls.Add(this.btnIns);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblIVA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTotalSinIVA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbUsu);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.groupBox1.Location = new System.Drawing.Point(394, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 745);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PEDIDO";
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIns.Location = new System.Drawing.Point(356, 668);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(140, 50);
            this.btnIns.TabIndex = 52;
            this.btnIns.Text = "INSERTAR";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(159, 647);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "0.00 €";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(96, 647);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(15)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 612);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "__________________";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.White;
            this.lblIVA.Location = new System.Drawing.Point(159, 592);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(54, 20);
            this.lblIVA.TabIndex = 48;
            this.lblIVA.Text = "0.00 €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "IVA (21%)";
            // 
            // lblTotalSinIVA
            // 
            this.lblTotalSinIVA.AutoSize = true;
            this.lblTotalSinIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSinIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSinIVA.ForeColor = System.Drawing.Color.White;
            this.lblTotalSinIVA.Location = new System.Drawing.Point(159, 553);
            this.lblTotalSinIVA.Name = "lblTotalSinIVA";
            this.lblTotalSinIVA.Size = new System.Drawing.Size(54, 20);
            this.lblTotalSinIVA.TabIndex = 46;
            this.lblTotalSinIVA.Text = "0.00 €";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Total sin IVA";
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnMod.Enabled = false;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(520, 668);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(145, 50);
            this.btnMod.TabIndex = 45;
            this.btnMod.Text = "MODIFICAR";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Artículos del pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLinped);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.cbArt);
            this.groupBox3.Controls.Add(this.nudCant);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbTipo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(20, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 404);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // dgvLinped
            // 
            this.dgvLinped.AllowUserToAddRows = false;
            this.dgvLinped.AllowUserToDeleteRows = false;
            this.dgvLinped.AllowUserToResizeColumns = false;
            this.dgvLinped.AllowUserToResizeRows = false;
            this.dgvLinped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLinped.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLinped.BackgroundColor = System.Drawing.Color.Black;
            this.dgvLinped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLinped.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLinped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinped.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvLinped.Enabled = false;
            this.dgvLinped.Location = new System.Drawing.Point(27, 75);
            this.dgvLinped.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLinped.MultiSelect = false;
            this.dgvLinped.Name = "dgvLinped";
            this.dgvLinped.ReadOnly = true;
            this.dgvLinped.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvLinped.RowHeadersWidth = 25;
            this.dgvLinped.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLinped.RowTemplate.Height = 24;
            this.dgvLinped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinped.Size = new System.Drawing.Size(702, 304);
            this.dgvLinped.StandardTab = true;
            this.dgvLinped.TabIndex = 32;
            this.dgvLinped.Click += new System.EventHandler(this.dgvLinped_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnDel.Enabled = false;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.Location = new System.Drawing.Point(748, 119);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(38, 38);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "-";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(748, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbArt
            // 
            this.cbArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbArt.FormattingEnabled = true;
            this.cbArt.Location = new System.Drawing.Point(410, 32);
            this.cbArt.Name = "cbArt";
            this.cbArt.Size = new System.Drawing.Size(162, 28);
            this.cbArt.TabIndex = 7;
            // 
            // nudCant
            // 
            this.nudCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCant.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudCant.Location = new System.Drawing.Point(693, 33);
            this.nudCant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudCant.Size = new System.Drawing.Size(64, 26);
            this.nudCant.TabIndex = 8;
            this.nudCant.ThousandsSeparator = true;
            this.nudCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tipo de artículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(598, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cantidad";
            // 
            // cbTipo
            // 
            this.cbTipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.ItemHeight = 20;
            this.cbTipo.Location = new System.Drawing.Point(194, 32);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(115, 28);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.RellenarArticulos);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Artículo";
            // 
            // cbUsu
            // 
            this.cbUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbUsu.FormattingEnabled = true;
            this.cbUsu.Location = new System.Drawing.Point(214, 49);
            this.cbUsu.Name = "cbUsu";
            this.cbUsu.Size = new System.Drawing.Size(244, 28);
            this.cbUsu.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpFecha.Location = new System.Drawing.Point(561, 49);
            this.dtpFecha.MaxDate = new System.DateTime(2020, 5, 26, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(169, 26);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.Value = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(132, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(479, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha";
            // 
            // btnEli
            // 
            this.btnEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEli.ForeColor = System.Drawing.Color.Black;
            this.btnEli.Location = new System.Drawing.Point(687, 668);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(140, 50);
            this.btnEli.TabIndex = 53;
            this.btnEli.Text = "ELIMINAR";
            this.btnEli.UseVisualStyleBackColor = false;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1254, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbUsuB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUsu;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvLinped;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSinIVA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnEli;
    }
}