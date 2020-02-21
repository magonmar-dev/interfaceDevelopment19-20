namespace capa_presentacion
{
    partial class Usuarios
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.txbDir1 = new System.Windows.Forms.TextBox();
            this.txbDir2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbRepPass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPueblo = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.MaskedTextBox();
            this.mtxbTel = new System.Windows.Forms.MaskedTextBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbDniB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbEmailB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbNomB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbApeB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(716, 754);
            this.dataGridView.TabIndex = 0;
            // 
            // txbEmail
            // 
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbEmail.Location = new System.Drawing.Point(204, 40);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(239, 24);
            this.txbEmail.TabIndex = 1;
            this.txbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txbEmail_Validating);
            // 
            // txbPass
            // 
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Location = new System.Drawing.Point(204, 70);
            this.txbPass.MaxLength = 100;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(239, 24);
            this.txbPass.TabIndex = 2;
            this.txbPass.Validating += new System.ComponentModel.CancelEventHandler(this.txbPass_Validating);
            // 
            // txbNom
            // 
            this.txbNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNom.Location = new System.Drawing.Point(204, 130);
            this.txbNom.MaxLength = 35;
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(239, 24);
            this.txbNom.TabIndex = 4;
            this.txbNom.Validating += new System.ComponentModel.CancelEventHandler(this.txbNom_Validating);
            // 
            // txbApe
            // 
            this.txbApe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApe.Location = new System.Drawing.Point(204, 160);
            this.txbApe.MaxLength = 55;
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(239, 24);
            this.txbApe.TabIndex = 5;
            this.txbApe.Validating += new System.ComponentModel.CancelEventHandler(this.txbApe_Validating);
            // 
            // txbDNI
            // 
            this.txbDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDNI.Location = new System.Drawing.Point(204, 190);
            this.txbDNI.MaxLength = 12;
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(239, 24);
            this.txbDNI.TabIndex = 6;
            this.txbDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txbDNI_Validating);
            // 
            // txbDir1
            // 
            this.txbDir1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDir1.Location = new System.Drawing.Point(204, 250);
            this.txbDir1.MaxLength = 45;
            this.txbDir1.Name = "txbDir1";
            this.txbDir1.Size = new System.Drawing.Size(239, 24);
            this.txbDir1.TabIndex = 8;
            // 
            // txbDir2
            // 
            this.txbDir2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDir2.Location = new System.Drawing.Point(204, 280);
            this.txbDir2.MaxLength = 45;
            this.txbDir2.Name = "txbDir2";
            this.txbDir2.Size = new System.Drawing.Size(239, 24);
            this.txbDir2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(117, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "DNI/NIE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(114, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(74, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Código Postal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // dtpNac
            // 
            this.dtpNac.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dtpNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNac.Location = new System.Drawing.Point(204, 404);
            this.dtpNac.MaxDate = new System.DateTime(2019, 11, 12, 0, 0, 0, 0);
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.Size = new System.Drawing.Size(239, 24);
            this.dtpNac.TabIndex = 13;
            this.dtpNac.Value = new System.DateTime(2019, 11, 12, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbRepPass);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbPueblo);
            this.groupBox1.Controls.Add(this.cbProvincia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbCod);
            this.groupBox1.Controls.Add(this.mtxbTel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNac);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbPass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbDir2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDir1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbApe);
            this.groupBox1.Controls.Add(this.txbDNI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(760, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 455);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL NUEVO USUARIO";
            // 
            // txbRepPass
            // 
            this.txbRepPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRepPass.Location = new System.Drawing.Point(204, 100);
            this.txbRepPass.MaxLength = 100;
            this.txbRepPass.Name = "txbRepPass";
            this.txbRepPass.PasswordChar = '*';
            this.txbRepPass.Size = new System.Drawing.Size(239, 24);
            this.txbRepPass.TabIndex = 3;
            this.txbRepPass.Validating += new System.ComponentModel.CancelEventHandler(this.txbRepPass_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Repita la contraseña";
            // 
            // cbPueblo
            // 
            this.cbPueblo.FormattingEnabled = true;
            this.cbPueblo.Location = new System.Drawing.Point(204, 372);
            this.cbPueblo.Name = "cbPueblo";
            this.cbPueblo.Size = new System.Drawing.Size(239, 26);
            this.cbPueblo.TabIndex = 12;
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(204, 340);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(239, 26);
            this.cbProvincia.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(127, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pueblo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(109, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Provincia";
            // 
            // txbCod
            // 
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCod.Location = new System.Drawing.Point(204, 310);
            this.txbCod.Mask = "99999";
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(239, 24);
            this.txbCod.TabIndex = 10;
            this.txbCod.ValidatingType = typeof(int);
            // 
            // mtxbTel
            // 
            this.mtxbTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxbTel.Location = new System.Drawing.Point(204, 220);
            this.mtxbTel.Mask = "000000000";
            this.mtxbTel.Name = "mtxbTel";
            this.mtxbTel.Size = new System.Drawing.Size(239, 24);
            this.mtxbTel.TabIndex = 7;
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIns.Location = new System.Drawing.Point(764, 706);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(134, 43);
            this.btnIns.TabIndex = 24;
            this.btnIns.Text = "INSERTAR";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnEli
            // 
            this.btnEli.BackColor = System.Drawing.Color.Aqua;
            this.btnEli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEli.Location = new System.Drawing.Point(1092, 706);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(134, 43);
            this.btnEli.TabIndex = 25;
            this.btnEli.Text = "ELIMINAR";
            this.btnEli.UseVisualStyleBackColor = false;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Aqua;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(928, 706);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(134, 43);
            this.btnMod.TabIndex = 26;
            this.btnMod.Text = "MODIFICAR";
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txbDniB);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txbEmailB);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbNomB);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txbApeB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(760, 497);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 173);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR USUARIO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(116, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "DNI/NIE";
            // 
            // txbDniB
            // 
            this.txbDniB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDniB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDniB.Location = new System.Drawing.Point(204, 126);
            this.txbDniB.MaxLength = 12;
            this.txbDniB.Name = "txbDniB";
            this.txbDniB.Size = new System.Drawing.Size(239, 24);
            this.txbDniB.TabIndex = 23;
            this.txbDniB.TextChanged += new System.EventHandler(this.txbDniB_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(135, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Email";
            // 
            // txbEmailB
            // 
            this.txbEmailB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmailB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbEmailB.Location = new System.Drawing.Point(204, 96);
            this.txbEmailB.MaxLength = 50;
            this.txbEmailB.Name = "txbEmailB";
            this.txbEmailB.Size = new System.Drawing.Size(239, 24);
            this.txbEmailB.TabIndex = 21;
            this.txbEmailB.TextChanged += new System.EventHandler(this.txbEmailB_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(118, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Nombre";
            // 
            // txbNomB
            // 
            this.txbNomB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomB.Location = new System.Drawing.Point(204, 36);
            this.txbNomB.MaxLength = 35;
            this.txbNomB.Name = "txbNomB";
            this.txbNomB.Size = new System.Drawing.Size(239, 24);
            this.txbNomB.TabIndex = 17;
            this.txbNomB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNomB_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(109, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Apellidos";
            // 
            // txbApeB
            // 
            this.txbApeB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApeB.Location = new System.Drawing.Point(204, 66);
            this.txbApeB.MaxLength = 55;
            this.txbApeB.Name = "txbApeB";
            this.txbApeB.Size = new System.Drawing.Size(239, 24);
            this.txbApeB.TabIndex = 18;
            this.txbApeB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApeB_KeyPress);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1254, 778);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbApe;
        private System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.TextBox txbDir1;
        private System.Windows.Forms.TextBox txbDir2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtxbTel;
        private System.Windows.Forms.MaskedTextBox txbCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPueblo;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.TextBox txbRepPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbDniB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbEmailB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbNomB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbApeB;
    }
}