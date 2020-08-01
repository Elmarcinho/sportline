namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrarListaCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimientoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoCli = new System.Windows.Forms.DataGridViewImageColumn();
            this.PesoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstaturaCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZonaCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucursalCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbBuscarCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.contextMenuCliente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lbNombreDias = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.pbcListaCliente = new Proyecto.Presentacion.Help.PictureCircular();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.contextMenuCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarListaCliente
            // 
            this.btnCerrarListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaCliente.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaCliente.Name = "btnCerrarListaCliente";
            this.btnCerrarListaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaCliente.TabIndex = 27;
            this.btnCerrarListaCliente.Text = "X";
            this.btnCerrarListaCliente.UseVisualStyleBackColor = true;
            this.btnCerrarListaCliente.Click += new System.EventHandler(this.btnCerrarListaCliente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buscar por Nombre o CI";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NombreCli,
            this.NombrePer,
            this.App,
            this.Apm,
            this.Cedula,
            this.TelefonoCli,
            this.SexoCli,
            this.FechaNacimientoCli,
            this.email,
            this.FotoCli,
            this.PesoCli,
            this.EstaturaCli,
            this.DireccionCli,
            this.ZonaCli,
            this.CiudadCli,
            this.SucursalCli});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCliente.Location = new System.Drawing.Point(58, 196);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(574, 347);
            this.dgvCliente.TabIndex = 21;
            this.dgvCliente.Visible = false;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_CellMouseClick);
            this.dgvCliente.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_CellMouseDown);
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "Código";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdCliente.HeaderText = "Código";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 55;
            // 
            // NombreCli
            // 
            this.NombreCli.DataPropertyName = "NombreCliente";
            this.NombreCli.HeaderText = "Nombre Cliente";
            this.NombreCli.Name = "NombreCli";
            this.NombreCli.ReadOnly = true;
            this.NombreCli.Width = 180;
            // 
            // NombrePer
            // 
            this.NombrePer.DataPropertyName = "NombrePersona";
            this.NombrePer.HeaderText = "Persona";
            this.NombrePer.Name = "NombrePer";
            this.NombrePer.Visible = false;
            // 
            // App
            // 
            this.App.DataPropertyName = "ApellidoPaterno";
            this.App.HeaderText = "APaterno";
            this.App.Name = "App";
            this.App.Visible = false;
            // 
            // Apm
            // 
            this.Apm.DataPropertyName = "ApellidoMaterno";
            this.Apm.HeaderText = "AMaterno";
            this.Apm.Name = "Apm";
            this.Apm.Visible = false;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CédulaIdentidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cedula.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cedula.HeaderText = "C.I.";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 90;
            // 
            // TelefonoCli
            // 
            this.TelefonoCli.DataPropertyName = "Teléfono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TelefonoCli.DefaultCellStyle = dataGridViewCellStyle4;
            this.TelefonoCli.HeaderText = "Teléfono";
            this.TelefonoCli.Name = "TelefonoCli";
            this.TelefonoCli.ReadOnly = true;
            this.TelefonoCli.Width = 80;
            // 
            // SexoCli
            // 
            this.SexoCli.DataPropertyName = "Sexo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SexoCli.DefaultCellStyle = dataGridViewCellStyle5;
            this.SexoCli.HeaderText = "Sexo";
            this.SexoCli.Name = "SexoCli";
            this.SexoCli.ReadOnly = true;
            this.SexoCli.Width = 50;
            // 
            // FechaNacimientoCli
            // 
            this.FechaNacimientoCli.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaNacimientoCli.DefaultCellStyle = dataGridViewCellStyle6;
            this.FechaNacimientoCli.HeaderText = "Fecha Nac.";
            this.FechaNacimientoCli.Name = "FechaNacimientoCli";
            this.FechaNacimientoCli.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "CorreoElectronico";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // FotoCli
            // 
            this.FotoCli.DataPropertyName = "Foto";
            this.FotoCli.HeaderText = "Foto";
            this.FotoCli.Name = "FotoCli";
            this.FotoCli.ReadOnly = true;
            // 
            // PesoCli
            // 
            this.PesoCli.DataPropertyName = "Peso";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PesoCli.DefaultCellStyle = dataGridViewCellStyle7;
            this.PesoCli.HeaderText = "Peso";
            this.PesoCli.Name = "PesoCli";
            this.PesoCli.ReadOnly = true;
            this.PesoCli.Width = 60;
            // 
            // EstaturaCli
            // 
            this.EstaturaCli.DataPropertyName = "Estatura";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EstaturaCli.DefaultCellStyle = dataGridViewCellStyle8;
            this.EstaturaCli.HeaderText = "Estatura";
            this.EstaturaCli.Name = "EstaturaCli";
            this.EstaturaCli.ReadOnly = true;
            this.EstaturaCli.Width = 60;
            // 
            // DireccionCli
            // 
            this.DireccionCli.DataPropertyName = "direccion";
            this.DireccionCli.HeaderText = "Dirección";
            this.DireccionCli.Name = "DireccionCli";
            this.DireccionCli.ReadOnly = true;
            // 
            // ZonaCli
            // 
            this.ZonaCli.DataPropertyName = "Zona";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ZonaCli.DefaultCellStyle = dataGridViewCellStyle9;
            this.ZonaCli.HeaderText = "Zona";
            this.ZonaCli.Name = "ZonaCli";
            this.ZonaCli.ReadOnly = true;
            // 
            // CiudadCli
            // 
            this.CiudadCli.DataPropertyName = "Ciudad";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CiudadCli.DefaultCellStyle = dataGridViewCellStyle10;
            this.CiudadCli.HeaderText = "Ciudad";
            this.CiudadCli.Name = "CiudadCli";
            this.CiudadCli.ReadOnly = true;
            // 
            // SucursalCli
            // 
            this.SucursalCli.DataPropertyName = "Sucursal";
            this.SucursalCli.HeaderText = "Sucursal";
            this.SucursalCli.Name = "SucursalCli";
            this.SucursalCli.ReadOnly = true;
            this.SucursalCli.Width = 120;
            // 
            // txbBuscarCliente
            // 
            this.txbBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarCliente.Location = new System.Drawing.Point(18, 54);
            this.txbBuscarCliente.Name = "txbBuscarCliente";
            this.txbBuscarCliente.Size = new System.Drawing.Size(166, 22);
            this.txbBuscarCliente.TabIndex = 20;
            this.txbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarCliente_KeyPress);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(297, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 40);
            this.label16.TabIndex = 69;
            this.label16.Text = "CLIENTES";
            // 
            // contextMenuCliente
            // 
            this.contextMenuCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarClienteToolStripMenuItem});
            this.contextMenuCliente.Name = "contextMenuCliente";
            this.contextMenuCliente.Size = new System.Drawing.Size(105, 26);
            // 
            // ModificarClienteToolStripMenuItem
            // 
            this.ModificarClienteToolStripMenuItem.Enabled = false;
            this.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem";
            this.ModificarClienteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ModificarClienteToolStripMenuItem.Text = "Editar";
            this.ModificarClienteToolStripMenuItem.Click += new System.EventHandler(this.ModificarClienteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnNuevoCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 93);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txbBuscarCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 93);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Clientes";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(200, 51);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarCliente.TabIndex = 90;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lbNombreDias
            // 
            this.lbNombreDias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNombreDias.AutoSize = true;
            this.lbNombreDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDias.ForeColor = System.Drawing.SystemColors.Window;
            this.lbNombreDias.Location = new System.Drawing.Point(650, 394);
            this.lbNombreDias.Name = "lbNombreDias";
            this.lbNombreDias.Size = new System.Drawing.Size(113, 25);
            this.lbNombreDias.TabIndex = 105;
            this.lbNombreDias.Text = "Saldo dias";
            this.lbNombreDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDias
            // 
            this.lbDias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDias.Location = new System.Drawing.Point(668, 428);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(53, 42);
            this.lbDias.TabIndex = 104;
            this.lbDias.Text = "Di";
            this.lbDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoCliente.Enabled = false;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(16, 35);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(121, 36);
            this.btnNuevoCliente.TabIndex = 22;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // pbcListaCliente
            // 
            this.pbcListaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcListaCliente.Image = global::Proyecto.Presentacion.Properties.Resources.user;
            this.pbcListaCliente.Location = new System.Drawing.Point(638, 196);
            this.pbcListaCliente.Name = "pbcListaCliente";
            this.pbcListaCliente.Size = new System.Drawing.Size(148, 159);
            this.pbcListaCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcListaCliente.TabIndex = 70;
            this.pbcListaCliente.TabStop = false;
            this.pbcListaCliente.Visible = false;
            // 
            // FrmGestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.lbNombreDias);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbcListaCliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaCliente);
            this.Controls.Add(this.dgvCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionCliente";
            this.Load += new System.EventHandler(this.FrmListaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.contextMenuCliente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarListaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txbBuscarCliente;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuCliente;
        private System.Windows.Forms.ToolStripMenuItem ModificarClienteToolStripMenuItem;
        private Help.PictureCircular pbcListaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePer;
        private System.Windows.Forms.DataGridViewTextBoxColumn App;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimientoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewImageColumn FotoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstaturaCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZonaCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucursalCli;
        private System.Windows.Forms.Label lbNombreDias;
        private System.Windows.Forms.Label lbDias;
    }
}