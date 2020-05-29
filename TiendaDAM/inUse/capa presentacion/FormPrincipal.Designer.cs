namespace capa_presentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnProductos = new System.Windows.Forms.ToolStripButton();
            this.btnPedidos = new System.Windows.Forms.ToolStripButton();
            this.btnEstadisticas = new System.Windows.Forms.ToolStripButton();
            this.btnInformes = new System.Windows.Forms.ToolStripButton();
            this.btnAcerca = new System.Windows.Forms.ToolStripButton();
            this.lblUsuario = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOcultar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArchivo,
            this.btnUsuarios,
            this.btnProductos,
            this.btnPedidos,
            this.btnEstadisticas,
            this.btnInformes,
            this.btnAcerca,
            this.lblUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1262, 28);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnArchivo
            // 
            this.btnArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.btnArchivo.ForeColor = System.Drawing.Color.White;
            this.btnArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnArchivo.Image")));
            this.btnArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnArchivo.Size = new System.Drawing.Size(83, 24);
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 26);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(79, 24);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnProductos.Size = new System.Drawing.Size(89, 24);
            this.btnProductos.Text = "Productos";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPedidos.Size = new System.Drawing.Size(75, 24);
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEstadisticas.Size = new System.Drawing.Size(99, 24);
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = ((System.Drawing.Image)(resources.GetObject("btnInformes.Image")));
            this.btnInformes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInformes.Margin = new System.Windows.Forms.Padding(2);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnInformes.Size = new System.Drawing.Size(81, 24);
            this.btnInformes.Text = "Informes";
            // 
            // btnAcerca
            // 
            this.btnAcerca.ForeColor = System.Drawing.Color.White;
            this.btnAcerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAcerca.Size = new System.Drawing.Size(98, 24);
            this.btnAcerca.Text = "Acerca de...";
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.lblUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 24);
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus,
            this.lblHora,
            this.lblTimer,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 820);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1262, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1136, 20);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 20);
            this.lblHora.Text = "Hora";
            // 
            // lblTimer
            // 
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(47, 20);
            this.lblTimer.Text = "Timer";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel5.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TiendaDAM";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMostrar,
            this.btnOcultar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 52);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(129, 24);
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(129, 24);
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 786);
            this.panel1.TabIndex = 20;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnArchivo;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripButton btnProductos;
        private System.Windows.Forms.ToolStripButton btnPedidos;
        private System.Windows.Forms.ToolStripButton btnEstadisticas;
        private System.Windows.Forms.ToolStripButton btnInformes;
        private System.Windows.Forms.ToolStripButton btnAcerca;
        private System.Windows.Forms.ToolStripLabel lblUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMostrar;
        private System.Windows.Forms.ToolStripMenuItem btnOcultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
    }
}