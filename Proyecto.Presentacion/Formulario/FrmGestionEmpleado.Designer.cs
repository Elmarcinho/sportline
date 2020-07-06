namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrarListaEmpleado = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimientoEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngresoEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoEmple = new System.Windows.Forms.DataGridViewImageColumn();
            this.DireccionEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZonaEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucursalEmple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuEmpleado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbcListaEmpleado = new Proyecto.Presentacion.Help.PictureCircular();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txbBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcListaEmpleado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarListaEmpleado
            // 
            this.btnCerrarListaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaEmpleado.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaEmpleado.Name = "btnCerrarListaEmpleado";
            this.btnCerrarListaEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaEmpleado.TabIndex = 35;
            this.btnCerrarListaEmpleado.Text = "X";
            this.btnCerrarListaEmpleado.UseVisualStyleBackColor = true;
            this.btnCerrarListaEmpleado.Click += new System.EventHandler(this.btnCerrarListaEmpleado_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoEmpleado.Enabled = false;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(16, 35);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(122, 36);
            this.btnNuevoEmpleado.TabIndex = 30;
            this.btnNuevoEmpleado.Text = "Nuevo Empleado";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click_1);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.NombreEmple,
            this.Persona,
            this.APaterno,
            this.AMaterno,
            this.Cedula,
            this.TelefonoEmple,
            this.SexoEmple,
            this.FechaNacimientoEmple,
            this.FechaIngresoEmple,
            this.FotoEmple,
            this.DireccionEmple,
            this.ZonaEmple,
            this.CiudadEmple,
            this.SucursalEmple});
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle44;
            this.dgvEmpleado.Location = new System.Drawing.Point(58, 196);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(574, 347);
            this.dgvEmpleado.TabIndex = 29;
            this.dgvEmpleado.Visible = false;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellClick);
            this.dgvEmpleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleado_CellMouseClick);
            this.dgvEmpleado.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleado_CellMouseDown);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.DataPropertyName = "Código";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdEmpleado.DefaultCellStyle = dataGridViewCellStyle35;
            this.IdEmpleado.HeaderText = "Código";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Width = 55;
            // 
            // NombreEmple
            // 
            this.NombreEmple.DataPropertyName = "NombreEmpleado";
            this.NombreEmple.HeaderText = "Nombre Empleado";
            this.NombreEmple.Name = "NombreEmple";
            this.NombreEmple.ReadOnly = true;
            this.NombreEmple.Width = 180;
            // 
            // Persona
            // 
            this.Persona.DataPropertyName = "NombrePersona";
            this.Persona.HeaderText = "Persona";
            this.Persona.Name = "Persona";
            this.Persona.ReadOnly = true;
            this.Persona.Visible = false;
            // 
            // APaterno
            // 
            this.APaterno.DataPropertyName = "ApellidoPaterno";
            this.APaterno.HeaderText = "APaterno";
            this.APaterno.Name = "APaterno";
            this.APaterno.ReadOnly = true;
            this.APaterno.Visible = false;
            // 
            // AMaterno
            // 
            this.AMaterno.DataPropertyName = "ApellidoMaterno";
            this.AMaterno.HeaderText = "AMaterno";
            this.AMaterno.Name = "AMaterno";
            this.AMaterno.ReadOnly = true;
            this.AMaterno.Visible = false;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CédulaIdentidad";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cedula.DefaultCellStyle = dataGridViewCellStyle36;
            this.Cedula.HeaderText = "C.I.";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 90;
            // 
            // TelefonoEmple
            // 
            this.TelefonoEmple.DataPropertyName = "Teléfono";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TelefonoEmple.DefaultCellStyle = dataGridViewCellStyle37;
            this.TelefonoEmple.HeaderText = "Teléfono";
            this.TelefonoEmple.Name = "TelefonoEmple";
            this.TelefonoEmple.ReadOnly = true;
            this.TelefonoEmple.Width = 80;
            // 
            // SexoEmple
            // 
            this.SexoEmple.DataPropertyName = "Sexo";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SexoEmple.DefaultCellStyle = dataGridViewCellStyle38;
            this.SexoEmple.HeaderText = "Sexo";
            this.SexoEmple.Name = "SexoEmple";
            this.SexoEmple.ReadOnly = true;
            this.SexoEmple.Width = 50;
            // 
            // FechaNacimientoEmple
            // 
            this.FechaNacimientoEmple.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaNacimientoEmple.DefaultCellStyle = dataGridViewCellStyle39;
            this.FechaNacimientoEmple.HeaderText = "Fecha Nac.";
            this.FechaNacimientoEmple.Name = "FechaNacimientoEmple";
            this.FechaNacimientoEmple.ReadOnly = true;
            // 
            // FechaIngresoEmple
            // 
            this.FechaIngresoEmple.DataPropertyName = "FechaIngreso";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaIngresoEmple.DefaultCellStyle = dataGridViewCellStyle40;
            this.FechaIngresoEmple.HeaderText = "Fecha Ing.";
            this.FechaIngresoEmple.Name = "FechaIngresoEmple";
            this.FechaIngresoEmple.ReadOnly = true;
            // 
            // FotoEmple
            // 
            this.FotoEmple.DataPropertyName = "Foto";
            this.FotoEmple.HeaderText = "Foto";
            this.FotoEmple.Name = "FotoEmple";
            this.FotoEmple.ReadOnly = true;
            // 
            // DireccionEmple
            // 
            this.DireccionEmple.DataPropertyName = "Dirección";
            this.DireccionEmple.HeaderText = "Dirección";
            this.DireccionEmple.Name = "DireccionEmple";
            this.DireccionEmple.ReadOnly = true;
            // 
            // ZonaEmple
            // 
            this.ZonaEmple.DataPropertyName = "Zona";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ZonaEmple.DefaultCellStyle = dataGridViewCellStyle41;
            this.ZonaEmple.HeaderText = "Zona";
            this.ZonaEmple.Name = "ZonaEmple";
            this.ZonaEmple.ReadOnly = true;
            // 
            // CiudadEmple
            // 
            this.CiudadEmple.DataPropertyName = "NombreCiudad";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CiudadEmple.DefaultCellStyle = dataGridViewCellStyle42;
            this.CiudadEmple.HeaderText = "Ciudad";
            this.CiudadEmple.Name = "CiudadEmple";
            this.CiudadEmple.ReadOnly = true;
            // 
            // SucursalEmple
            // 
            this.SucursalEmple.DataPropertyName = "NombreSucursal";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SucursalEmple.DefaultCellStyle = dataGridViewCellStyle43;
            this.SucursalEmple.HeaderText = "Sucursal";
            this.SucursalEmple.Name = "SucursalEmple";
            this.SucursalEmple.ReadOnly = true;
            this.SucursalEmple.Width = 120;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(279, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(215, 40);
            this.label16.TabIndex = 70;
            this.label16.Text = "EMPLEADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnNuevoEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 93);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // contextMenuEmpleado
            // 
            this.contextMenuEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarEmpleadoToolStripMenuItem});
            this.contextMenuEmpleado.Name = "contextMenuEmpleado";
            this.contextMenuEmpleado.Size = new System.Drawing.Size(105, 26);
            // 
            // ModificarEmpleadoToolStripMenuItem
            // 
            this.ModificarEmpleadoToolStripMenuItem.Enabled = false;
            this.ModificarEmpleadoToolStripMenuItem.Name = "ModificarEmpleadoToolStripMenuItem";
            this.ModificarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ModificarEmpleadoToolStripMenuItem.Text = "Editar";
            this.ModificarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ModificarEmpleadoToolStripMenuItem_Click);
            // 
            // pbcListaEmpleado
            // 
            this.pbcListaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcListaEmpleado.Image = global::Proyecto.Presentacion.Properties.Resources.user;
            this.pbcListaEmpleado.Location = new System.Drawing.Point(642, 196);
            this.pbcListaEmpleado.Name = "pbcListaEmpleado";
            this.pbcListaEmpleado.Size = new System.Drawing.Size(146, 154);
            this.pbcListaEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcListaEmpleado.TabIndex = 71;
            this.pbcListaEmpleado.TabStop = false;
            this.pbcListaEmpleado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBuscarEmpleado);
            this.groupBox2.Controls.Add(this.txbBuscarEmpleado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 93);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Empleados";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(200, 51);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarEmpleado.TabIndex = 90;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txbBuscarEmpleado
            // 
            this.txbBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarEmpleado.Location = new System.Drawing.Point(18, 54);
            this.txbBuscarEmpleado.Name = "txbBuscarEmpleado";
            this.txbBuscarEmpleado.Size = new System.Drawing.Size(166, 22);
            this.txbBuscarEmpleado.TabIndex = 20;
            this.txbBuscarEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarEmpleado_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Buscar por Nombre o CI";
            // 
            // FrmGestionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbcListaEmpleado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaEmpleado);
            this.Controls.Add(this.dgvEmpleado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionEmpleado";
            this.Load += new System.EventHandler(this.FrmListaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcListaEmpleado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarListaEmpleado;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuEmpleado;
        private System.Windows.Forms.ToolStripMenuItem ModificarEmpleadoToolStripMenuItem;
        private Help.PictureCircular pbcListaEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox txbBuscarEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn APaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimientoEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngresoEmple;
        private System.Windows.Forms.DataGridViewImageColumn FotoEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZonaEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadEmple;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucursalEmple;
    }
}