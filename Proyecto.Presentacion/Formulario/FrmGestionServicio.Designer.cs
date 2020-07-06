namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarListaServicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListaServicio = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.contextMenuServicio = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodigoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioQuincena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangoDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            this.contextMenuServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(290, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 40);
            this.label16.TabIndex = 78;
            this.label16.Text = "SERVICIOS";
            // 
            // btnCerrarListaServicio
            // 
            this.btnCerrarListaServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaServicio.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaServicio.Name = "btnCerrarListaServicio";
            this.btnCerrarListaServicio.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaServicio.TabIndex = 77;
            this.btnCerrarListaServicio.Text = "X";
            this.btnCerrarListaServicio.UseVisualStyleBackColor = true;
            this.btnCerrarListaServicio.Click += new System.EventHandler(this.btnCerrarListaServicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnMostrarListaServicio);
            this.groupBox1.Controls.Add(this.btnNuevoServicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 93);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btnMostrarListaServicio
            // 
            this.btnMostrarListaServicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMostrarListaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaServicio.Location = new System.Drawing.Point(144, 35);
            this.btnMostrarListaServicio.Name = "btnMostrarListaServicio";
            this.btnMostrarListaServicio.Size = new System.Drawing.Size(124, 36);
            this.btnMostrarListaServicio.TabIndex = 77;
            this.btnMostrarListaServicio.Text = "Ver Lista";
            this.btnMostrarListaServicio.UseVisualStyleBackColor = true;
            this.btnMostrarListaServicio.Click += new System.EventHandler(this.btnMostrarListaServicio_Click);
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoServicio.Enabled = false;
            this.btnNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoServicio.Location = new System.Drawing.Point(16, 35);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(122, 36);
            this.btnNuevoServicio.TabIndex = 73;
            this.btnNuevoServicio.Text = "Nuevo Servicio";
            this.btnNuevoServicio.UseVisualStyleBackColor = true;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // dgvServicio
            // 
            this.dgvServicio.AllowUserToAddRows = false;
            this.dgvServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoServicio,
            this.NombreSer,
            this.DescripcionServicio,
            this.CodigoPrecio,
            this.PrecioDia,
            this.PrecioQuincena,
            this.PrecioMes,
            this.Estado,
            this.HoraInicio,
            this.HoraFin,
            this.RangoDia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicio.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServicio.Location = new System.Drawing.Point(58, 196);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.Size = new System.Drawing.Size(620, 347);
            this.dgvServicio.TabIndex = 92;
            this.dgvServicio.Visible = false;
            this.dgvServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicio_CellClick);
            this.dgvServicio.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvServicio_CellMouseClick);
            this.dgvServicio.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvServicio_CellMouseDown);
            // 
            // contextMenuServicio
            // 
            this.contextMenuServicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarServicioToolStripMenuItem});
            this.contextMenuServicio.Name = "contextMenuServicio";
            this.contextMenuServicio.Size = new System.Drawing.Size(105, 26);
            // 
            // ModificarServicioToolStripMenuItem
            // 
            this.ModificarServicioToolStripMenuItem.Name = "ModificarServicioToolStripMenuItem";
            this.ModificarServicioToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ModificarServicioToolStripMenuItem.Text = "Editar";
            this.ModificarServicioToolStripMenuItem.Click += new System.EventHandler(this.ModificarServicioToolStripMenuItem_Click);
            // 
            // CodigoServicio
            // 
            this.CodigoServicio.DataPropertyName = "IdServicio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodigoServicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoServicio.HeaderText = "Código";
            this.CodigoServicio.Name = "CodigoServicio";
            this.CodigoServicio.ReadOnly = true;
            this.CodigoServicio.Width = 55;
            // 
            // NombreSer
            // 
            this.NombreSer.DataPropertyName = "NombreServicio";
            this.NombreSer.HeaderText = "Nombre Servicio";
            this.NombreSer.Name = "NombreSer";
            this.NombreSer.ReadOnly = true;
            this.NombreSer.Width = 160;
            // 
            // DescripcionServicio
            // 
            this.DescripcionServicio.DataPropertyName = "Descripción";
            this.DescripcionServicio.HeaderText = "Descripción";
            this.DescripcionServicio.Name = "DescripcionServicio";
            this.DescripcionServicio.ReadOnly = true;
            this.DescripcionServicio.Width = 270;
            // 
            // CodigoPrecio
            // 
            this.CodigoPrecio.DataPropertyName = "IdPrecio";
            this.CodigoPrecio.HeaderText = "CodPrecio";
            this.CodigoPrecio.Name = "CodigoPrecio";
            this.CodigoPrecio.ReadOnly = true;
            this.CodigoPrecio.Visible = false;
            // 
            // PrecioDia
            // 
            this.PrecioDia.DataPropertyName = "PrecioDiario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioDia.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioDia.HeaderText = "Precio Diario";
            this.PrecioDia.Name = "PrecioDia";
            this.PrecioDia.ReadOnly = true;
            this.PrecioDia.Width = 80;
            // 
            // PrecioQuincena
            // 
            this.PrecioQuincena.DataPropertyName = "PrecioQuincenal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioQuincena.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecioQuincena.HeaderText = "Precio Quincenal";
            this.PrecioQuincena.Name = "PrecioQuincena";
            this.PrecioQuincena.ReadOnly = true;
            this.PrecioQuincena.Width = 80;
            // 
            // PrecioMes
            // 
            this.PrecioMes.DataPropertyName = "PrecioMensual";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioMes.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrecioMes.HeaderText = "Precio Mensual";
            this.PrecioMes.Name = "PrecioMes";
            this.PrecioMes.ReadOnly = true;
            this.PrecioMes.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "EstadoServicio";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 60;
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "HoraFin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 60;
            // 
            // RangoDia
            // 
            this.RangoDia.DataPropertyName = "RangoDia";
            this.RangoDia.HeaderText = "Dias";
            this.RangoDia.Name = "RangoDia";
            this.RangoDia.ReadOnly = true;
            this.RangoDia.Width = 110;
            // 
            // FrmGestionServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvServicio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionServicio";
            this.Load += new System.EventHandler(this.FrmListaServicio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
            this.contextMenuServicio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarListaServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarListaServicio;
        private System.Windows.Forms.Button btnNuevoServicio;
        public System.Windows.Forms.DataGridView dgvServicio;
        private System.Windows.Forms.ContextMenuStrip contextMenuServicio;
        private System.Windows.Forms.ToolStripMenuItem ModificarServicioToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioQuincena;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangoDia;
    }
}