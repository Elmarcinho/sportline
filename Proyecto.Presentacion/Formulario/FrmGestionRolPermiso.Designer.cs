namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionRolPermiso
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
            this.btnCerrarListaRolPermiso = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.IdPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageListaRol = new System.Windows.Forms.TabPage();
            this.btnMostrarListaRol = new System.Windows.Forms.Button();
            this.btnNuevoRol = new System.Windows.Forms.Button();
            this.tabPageListaPermiso = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListaRolAsignar = new System.Windows.Forms.ComboBox();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.tabPageRolPermiso = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbListaRolDetalle = new System.Windows.Forms.ComboBox();
            this.dgvRolPermisos = new System.Windows.Forms.DataGridView();
            this.CodigoRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoRolPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckRolPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnModificarRolPermiso = new System.Windows.Forms.Button();
            this.contextMenuRol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageListaRol.SuspendLayout();
            this.tabPageListaPermiso.SuspendLayout();
            this.tabPageRolPermiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolPermisos)).BeginInit();
            this.contextMenuRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarListaRolPermiso
            // 
            this.btnCerrarListaRolPermiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaRolPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaRolPermiso.Location = new System.Drawing.Point(691, 1);
            this.btnCerrarListaRolPermiso.Name = "btnCerrarListaRolPermiso";
            this.btnCerrarListaRolPermiso.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaRolPermiso.TabIndex = 44;
            this.btnCerrarListaRolPermiso.Text = "X";
            this.btnCerrarListaRolPermiso.UseVisualStyleBackColor = true;
            this.btnCerrarListaRolPermiso.Click += new System.EventHandler(this.btnCerrarListaRolPermiso_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(268, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(284, 40);
            this.label16.TabIndex = 70;
            this.label16.Text = "ROL Y PERMISOS";
            // 
            // dgvRoles
            // 
            this.dgvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(0, 120);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.Size = new System.Drawing.Size(693, 295);
            this.dgvRoles.TabIndex = 72;
            this.dgvRoles.Visible = false;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            this.dgvRoles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoles_CellMouseClick);
            this.dgvRoles.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoles_CellMouseDown);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPermiso,
            this.NombrePermiso,
            this.CheckPermiso});
            this.dgvPermisos.Location = new System.Drawing.Point(2, 33);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(350, 376);
            this.dgvPermisos.TabIndex = 75;
            this.dgvPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellClick);
            // 
            // IdPermiso
            // 
            this.IdPermiso.DataPropertyName = "IdPermiso";
            this.IdPermiso.HeaderText = "Código";
            this.IdPermiso.Name = "IdPermiso";
            this.IdPermiso.ReadOnly = true;
            this.IdPermiso.Width = 57;
            // 
            // NombrePermiso
            // 
            this.NombrePermiso.DataPropertyName = "NombrePermiso";
            this.NombrePermiso.HeaderText = "Permiso";
            this.NombrePermiso.Name = "NombrePermiso";
            this.NombrePermiso.ReadOnly = true;
            this.NombrePermiso.Width = 160;
            // 
            // CheckPermiso
            // 
            this.CheckPermiso.FalseValue = "F";
            this.CheckPermiso.HeaderText = "Permitir";
            this.CheckPermiso.Name = "CheckPermiso";
            this.CheckPermiso.TrueValue = "T";
            this.CheckPermiso.Width = 75;
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlPrincipal.Controls.Add(this.tabPageListaRol);
            this.tabControlPrincipal.Controls.Add(this.tabPageListaPermiso);
            this.tabControlPrincipal.Controls.Add(this.tabPageRolPermiso);
            this.tabControlPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrincipal.Location = new System.Drawing.Point(51, 95);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(703, 443);
            this.tabControlPrincipal.TabIndex = 80;
            this.tabControlPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabControlPrincipal_SelectedIndexChanged);
            // 
            // tabPageListaRol
            // 
            this.tabPageListaRol.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageListaRol.Controls.Add(this.btnMostrarListaRol);
            this.tabPageListaRol.Controls.Add(this.btnNuevoRol);
            this.tabPageListaRol.Controls.Add(this.dgvRoles);
            this.tabPageListaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageListaRol.Location = new System.Drawing.Point(4, 24);
            this.tabPageListaRol.Name = "tabPageListaRol";
            this.tabPageListaRol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaRol.Size = new System.Drawing.Size(695, 415);
            this.tabPageListaRol.TabIndex = 0;
            this.tabPageListaRol.Text = "ROLES";
            // 
            // btnMostrarListaRol
            // 
            this.btnMostrarListaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaRol.Location = new System.Drawing.Point(147, 31);
            this.btnMostrarListaRol.Name = "btnMostrarListaRol";
            this.btnMostrarListaRol.Size = new System.Drawing.Size(122, 40);
            this.btnMostrarListaRol.TabIndex = 73;
            this.btnMostrarListaRol.Text = "Ver Lista";
            this.btnMostrarListaRol.UseVisualStyleBackColor = true;
            this.btnMostrarListaRol.Click += new System.EventHandler(this.btnMostrarListaRol_Click);
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRol.Location = new System.Drawing.Point(10, 31);
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.Size = new System.Drawing.Size(122, 40);
            this.btnNuevoRol.TabIndex = 38;
            this.btnNuevoRol.Text = "Nuevo Rol";
            this.btnNuevoRol.UseVisualStyleBackColor = true;
            this.btnNuevoRol.Click += new System.EventHandler(this.btnNuevoRol_Click);
            // 
            // tabPageListaPermiso
            // 
            this.tabPageListaPermiso.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageListaPermiso.Controls.Add(this.label1);
            this.tabPageListaPermiso.Controls.Add(this.cbListaRolAsignar);
            this.tabPageListaPermiso.Controls.Add(this.btnAsignarPermiso);
            this.tabPageListaPermiso.Controls.Add(this.dgvPermisos);
            this.tabPageListaPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageListaPermiso.Location = new System.Drawing.Point(4, 24);
            this.tabPageListaPermiso.Name = "tabPageListaPermiso";
            this.tabPageListaPermiso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaPermiso.Size = new System.Drawing.Size(695, 415);
            this.tabPageListaPermiso.TabIndex = 1;
            this.tabPageListaPermiso.Text = "PERMISOS DISPONIBLES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Rol";
            // 
            // cbListaRolAsignar
            // 
            this.cbListaRolAsignar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaRolAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaRolAsignar.FormattingEnabled = true;
            this.cbListaRolAsignar.Location = new System.Drawing.Point(477, 33);
            this.cbListaRolAsignar.Name = "cbListaRolAsignar";
            this.cbListaRolAsignar.Size = new System.Drawing.Size(176, 24);
            this.cbListaRolAsignar.TabIndex = 82;
            this.cbListaRolAsignar.Visible = false;
            this.cbListaRolAsignar.SelectedIndexChanged += new System.EventHandler(this.cbListaRolAsignar_SelectedIndexChanged);
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Enabled = false;
            this.btnAsignarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermiso.Location = new System.Drawing.Point(477, 94);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(176, 40);
            this.btnAsignarPermiso.TabIndex = 81;
            this.btnAsignarPermiso.Text = "Asignar Permisos";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Visible = false;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // tabPageRolPermiso
            // 
            this.tabPageRolPermiso.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageRolPermiso.Controls.Add(this.label4);
            this.tabPageRolPermiso.Controls.Add(this.cbListaRolDetalle);
            this.tabPageRolPermiso.Controls.Add(this.dgvRolPermisos);
            this.tabPageRolPermiso.Controls.Add(this.btnModificarRolPermiso);
            this.tabPageRolPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRolPermiso.Location = new System.Drawing.Point(4, 24);
            this.tabPageRolPermiso.Name = "tabPageRolPermiso";
            this.tabPageRolPermiso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRolPermiso.Size = new System.Drawing.Size(695, 415);
            this.tabPageRolPermiso.TabIndex = 2;
            this.tabPageRolPermiso.Text = "PERMISOS ASIGNADOS AL ROL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Rol";
            // 
            // cbListaRolDetalle
            // 
            this.cbListaRolDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaRolDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListaRolDetalle.FormattingEnabled = true;
            this.cbListaRolDetalle.Location = new System.Drawing.Point(477, 33);
            this.cbListaRolDetalle.Name = "cbListaRolDetalle";
            this.cbListaRolDetalle.Size = new System.Drawing.Size(176, 24);
            this.cbListaRolDetalle.TabIndex = 78;
            this.cbListaRolDetalle.Visible = false;
            this.cbListaRolDetalle.SelectedIndexChanged += new System.EventHandler(this.cbListaRol_SelectedIndexChanged);
            // 
            // dgvRolPermisos
            // 
            this.dgvRolPermisos.AllowUserToAddRows = false;
            this.dgvRolPermisos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRolPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoRol,
            this.NombreR,
            this.CodigoPermiso,
            this.NombrePer,
            this.EstadoRolPermiso,
            this.CheckRolPermiso});
            this.dgvRolPermisos.Location = new System.Drawing.Point(2, 33);
            this.dgvRolPermisos.Name = "dgvRolPermisos";
            this.dgvRolPermisos.Size = new System.Drawing.Size(350, 376);
            this.dgvRolPermisos.TabIndex = 71;
            // 
            // CodigoRol
            // 
            this.CodigoRol.DataPropertyName = "IdRol";
            this.CodigoRol.HeaderText = "IdRol";
            this.CodigoRol.Name = "CodigoRol";
            this.CodigoRol.Visible = false;
            // 
            // NombreR
            // 
            this.NombreR.DataPropertyName = "NombreRol";
            this.NombreR.HeaderText = "NombreRol";
            this.NombreR.Name = "NombreR";
            this.NombreR.Visible = false;
            // 
            // CodigoPermiso
            // 
            this.CodigoPermiso.DataPropertyName = "IdPermiso";
            this.CodigoPermiso.HeaderText = "Código";
            this.CodigoPermiso.Name = "CodigoPermiso";
            this.CodigoPermiso.ReadOnly = true;
            this.CodigoPermiso.Width = 57;
            // 
            // NombrePer
            // 
            this.NombrePer.DataPropertyName = "NombrePermiso";
            this.NombrePer.HeaderText = "Permiso";
            this.NombrePer.Name = "NombrePer";
            this.NombrePer.ReadOnly = true;
            this.NombrePer.Width = 160;
            // 
            // EstadoRolPermiso
            // 
            this.EstadoRolPermiso.DataPropertyName = "Estado";
            this.EstadoRolPermiso.HeaderText = "Estado";
            this.EstadoRolPermiso.Name = "EstadoRolPermiso";
            this.EstadoRolPermiso.Visible = false;
            // 
            // CheckRolPermiso
            // 
            this.CheckRolPermiso.FalseValue = "F";
            this.CheckRolPermiso.HeaderText = "Habilitado";
            this.CheckRolPermiso.Name = "CheckRolPermiso";
            this.CheckRolPermiso.TrueValue = "T";
            this.CheckRolPermiso.Width = 75;
            // 
            // btnModificarRolPermiso
            // 
            this.btnModificarRolPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRolPermiso.Location = new System.Drawing.Point(477, 94);
            this.btnModificarRolPermiso.Name = "btnModificarRolPermiso";
            this.btnModificarRolPermiso.Size = new System.Drawing.Size(176, 40);
            this.btnModificarRolPermiso.TabIndex = 77;
            this.btnModificarRolPermiso.Text = "Guardar Cambios";
            this.btnModificarRolPermiso.UseVisualStyleBackColor = true;
            this.btnModificarRolPermiso.Visible = false;
            this.btnModificarRolPermiso.Click += new System.EventHandler(this.btnModificarRolPermiso_Click);
            // 
            // contextMenuRol
            // 
            this.contextMenuRol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarToolStripMenuItem,
            this.EliminarToolStripMenuItem});
            this.contextMenuRol.Name = "contextMenuRol";
            this.contextMenuRol.Size = new System.Drawing.Size(118, 48);
            // 
            // ModificarToolStripMenuItem
            // 
            this.ModificarToolStripMenuItem.Enabled = false;
            this.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem";
            this.ModificarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ModificarToolStripMenuItem.Text = "Editar";
            this.ModificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Enabled = false;
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.EliminarToolStripMenuItem.Text = "Eliminar";
            this.EliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // FrmGestionRolPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 550);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaRolPermiso);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionRolPermiso";
            this.Load += new System.EventHandler(this.FrmListaRolPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageListaRol.ResumeLayout(false);
            this.tabPageListaPermiso.ResumeLayout(false);
            this.tabPageListaPermiso.PerformLayout();
            this.tabPageRolPermiso.ResumeLayout(false);
            this.tabPageRolPermiso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolPermisos)).EndInit();
            this.contextMenuRol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarListaRolPermiso;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNuevoRol;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageListaRol;
        private System.Windows.Forms.TabPage tabPageListaPermiso;
        private System.Windows.Forms.TabPage tabPageRolPermiso;
        private System.Windows.Forms.DataGridView dgvRolPermisos;
        private System.Windows.Forms.Button btnModificarRolPermiso;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbListaRolDetalle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbListaRolAsignar;
        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.ContextMenuStrip contextMenuRol;
        private System.Windows.Forms.ToolStripMenuItem ModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarToolStripMenuItem;
        private System.Windows.Forms.Button btnMostrarListaRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoRolPermiso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckRolPermiso;
    }
}