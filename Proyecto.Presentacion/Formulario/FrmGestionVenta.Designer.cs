namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarListaVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVentaProducto = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarnetIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbBuscarVenta = new System.Windows.Forms.TextBox();
            this.btnVentaServicio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarSolicitud = new System.Windows.Forms.Button();
            this.CheckHabilitarFecha = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuVenta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DetalleVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(303, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 40);
            this.label16.TabIndex = 86;
            this.label16.Text = "VENTAS";
            // 
            // btnCerrarListaVenta
            // 
            this.btnCerrarListaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaVenta.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaVenta.Name = "btnCerrarListaVenta";
            this.btnCerrarListaVenta.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaVenta.TabIndex = 85;
            this.btnCerrarListaVenta.Text = "X";
            this.btnCerrarListaVenta.UseVisualStyleBackColor = true;
            this.btnCerrarListaVenta.Click += new System.EventHandler(this.btnCerrarListaVenta_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Ingresar C.I.";
            // 
            // btnVentaProducto
            // 
            this.btnVentaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentaProducto.Enabled = false;
            this.btnVentaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaProducto.Location = new System.Drawing.Point(15, 37);
            this.btnVentaProducto.Name = "btnVentaProducto";
            this.btnVentaProducto.Size = new System.Drawing.Size(109, 36);
            this.btnVentaProducto.TabIndex = 81;
            this.btnVentaProducto.Text = "Producto";
            this.btnVentaProducto.UseVisualStyleBackColor = true;
            this.btnVentaProducto.Click += new System.EventHandler(this.btnVentaProducto_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenta.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta,
            this.IdCliente,
            this.Cliente,
            this.CarnetIdentidad,
            this.FechaSol,
            this.EstadoSolicitud,
            this.TipoSol,
            this.Monto,
            this.TipoPa,
            this.User,
            this.CodDescuento,
            this.NombreDescuento,
            this.SubMonto});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvVenta.Location = new System.Drawing.Point(58, 209);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.Size = new System.Drawing.Size(699, 333);
            this.dgvVenta.TabIndex = 80;
            this.dgvVenta.Visible = false;
            this.dgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellClick);
            this.dgvVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVenta_CellFormatting);
            this.dgvVenta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVenta_CellMouseClick);
            this.dgvVenta.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVenta_CellMouseDown);
            // 
            // IdVenta
            // 
            this.IdVenta.DataPropertyName = "CodVenta";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdVenta.DefaultCellStyle = dataGridViewCellStyle12;
            this.IdVenta.HeaderText = "Nº Venta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Width = 86;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "CodCliente";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCliente.DefaultCellStyle = dataGridViewCellStyle13;
            this.IdCliente.HeaderText = "CodCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 86;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NombreCliente";
            this.Cliente.HeaderText = "Nombre Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 160;
            // 
            // CarnetIdentidad
            // 
            this.CarnetIdentidad.DataPropertyName = "CédulaIdentidad";
            this.CarnetIdentidad.HeaderText = "Cédula Identidad";
            this.CarnetIdentidad.Name = "CarnetIdentidad";
            this.CarnetIdentidad.ReadOnly = true;
            this.CarnetIdentidad.Visible = false;
            // 
            // FechaSol
            // 
            this.FechaSol.DataPropertyName = "FechaSolicitud";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = null;
            this.FechaSol.DefaultCellStyle = dataGridViewCellStyle14;
            this.FechaSol.HeaderText = "Fecha Sol.";
            this.FechaSol.Name = "FechaSol";
            this.FechaSol.ReadOnly = true;
            // 
            // EstadoSolicitud
            // 
            this.EstadoSolicitud.DataPropertyName = "Estado";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EstadoSolicitud.DefaultCellStyle = dataGridViewCellStyle15;
            this.EstadoSolicitud.HeaderText = "Estado";
            this.EstadoSolicitud.Name = "EstadoSolicitud";
            this.EstadoSolicitud.ReadOnly = true;
            // 
            // TipoSol
            // 
            this.TipoSol.DataPropertyName = "TipoSolicitud";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoSol.DefaultCellStyle = dataGridViewCellStyle16;
            this.TipoSol.HeaderText = "Tipo Sol.";
            this.TipoSol.Name = "TipoSol";
            this.TipoSol.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "MontoTotal";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle17;
            this.Monto.HeaderText = "Total";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // TipoPa
            // 
            this.TipoPa.DataPropertyName = "TipoPago";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoPa.DefaultCellStyle = dataGridViewCellStyle18;
            this.TipoPa.HeaderText = "Tipo Pago";
            this.TipoPa.Name = "TipoPa";
            this.TipoPa.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "Usuario";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.User.DefaultCellStyle = dataGridViewCellStyle19;
            this.User.HeaderText = "Usuario";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // CodDescuento
            // 
            this.CodDescuento.DataPropertyName = "IdDescuento";
            this.CodDescuento.HeaderText = "IdDescuento";
            this.CodDescuento.Name = "CodDescuento";
            this.CodDescuento.ReadOnly = true;
            this.CodDescuento.Visible = false;
            // 
            // NombreDescuento
            // 
            this.NombreDescuento.DataPropertyName = "MontoDescuento";
            this.NombreDescuento.HeaderText = "MontoDescuento";
            this.NombreDescuento.Name = "NombreDescuento";
            this.NombreDescuento.ReadOnly = true;
            this.NombreDescuento.Visible = false;
            // 
            // SubMonto
            // 
            this.SubMonto.DataPropertyName = "SubTotal";
            this.SubMonto.HeaderText = "SubTotal";
            this.SubMonto.Name = "SubMonto";
            this.SubMonto.ReadOnly = true;
            this.SubMonto.Visible = false;
            // 
            // txbBuscarVenta
            // 
            this.txbBuscarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarVenta.Location = new System.Drawing.Point(121, 61);
            this.txbBuscarVenta.Name = "txbBuscarVenta";
            this.txbBuscarVenta.Size = new System.Drawing.Size(113, 22);
            this.txbBuscarVenta.TabIndex = 79;
            this.txbBuscarVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarVenta_KeyPress);
            // 
            // btnVentaServicio
            // 
            this.btnVentaServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentaServicio.Enabled = false;
            this.btnVentaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaServicio.Location = new System.Drawing.Point(130, 37);
            this.btnVentaServicio.Name = "btnVentaServicio";
            this.btnVentaServicio.Size = new System.Drawing.Size(109, 36);
            this.btnVentaServicio.TabIndex = 87;
            this.btnVentaServicio.Text = "Servicio";
            this.btnVentaServicio.UseVisualStyleBackColor = true;
            this.btnVentaServicio.Click += new System.EventHandler(this.btnVentaServicio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpFechaVenta);
            this.groupBox2.Controls.Add(this.btnBuscarSolicitud);
            this.groupBox2.Controls.Add(this.CheckHabilitarFecha);
            this.groupBox2.Controls.Add(this.txbBuscarVenta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(447, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 95);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Ventas";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVenta.Location = new System.Drawing.Point(121, 27);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(113, 22);
            this.dtpFechaVenta.TabIndex = 91;
            // 
            // btnBuscarSolicitud
            // 
            this.btnBuscarSolicitud.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSolicitud.Location = new System.Drawing.Point(244, 58);
            this.btnBuscarSolicitud.Name = "btnBuscarSolicitud";
            this.btnBuscarSolicitud.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarSolicitud.TabIndex = 90;
            this.btnBuscarSolicitud.Text = "Buscar";
            this.btnBuscarSolicitud.UseVisualStyleBackColor = true;
            this.btnBuscarSolicitud.Click += new System.EventHandler(this.btnBuscarSolicitud_Click);
            // 
            // CheckHabilitarFecha
            // 
            this.CheckHabilitarFecha.AutoSize = true;
            this.CheckHabilitarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHabilitarFecha.Location = new System.Drawing.Point(21, 29);
            this.CheckHabilitarFecha.Name = "CheckHabilitarFecha";
            this.CheckHabilitarFecha.Size = new System.Drawing.Size(89, 20);
            this.CheckHabilitarFecha.TabIndex = 90;
            this.CheckHabilitarFecha.Text = "Por Fecha";
            this.CheckHabilitarFecha.UseVisualStyleBackColor = true;
            this.CheckHabilitarFecha.CheckedChanged += new System.EventHandler(this.CheckHabilitarFecha_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnVentaServicio);
            this.groupBox1.Controls.Add(this.btnVentaProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 95);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Venta de:";
            // 
            // contextMenuVenta
            // 
            this.contextMenuVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetalleVentaToolStripMenuItem,
            this.ModificarVentaToolStripMenuItem,
            this.CancelarVentaToolStripMenuItem});
            this.contextMenuVenta.Name = "contextMenuVenta";
            this.contextMenuVenta.Size = new System.Drawing.Size(176, 92);
            // 
            // DetalleVentaToolStripMenuItem
            // 
            this.DetalleVentaToolStripMenuItem.Name = "DetalleVentaToolStripMenuItem";
            this.DetalleVentaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.DetalleVentaToolStripMenuItem.Text = "Detalle de Solicitud";
            this.DetalleVentaToolStripMenuItem.Click += new System.EventHandler(this.DetalleVentaToolStripMenuItem_Click);
            // 
            // ModificarVentaToolStripMenuItem
            // 
            this.ModificarVentaToolStripMenuItem.Enabled = false;
            this.ModificarVentaToolStripMenuItem.Name = "ModificarVentaToolStripMenuItem";
            this.ModificarVentaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ModificarVentaToolStripMenuItem.Text = "Editar Solicitud";
            this.ModificarVentaToolStripMenuItem.Click += new System.EventHandler(this.ModificarVentaToolStripMenuItem_Click);
            // 
            // CancelarVentaToolStripMenuItem
            // 
            this.CancelarVentaToolStripMenuItem.Enabled = false;
            this.CancelarVentaToolStripMenuItem.Name = "CancelarVentaToolStripMenuItem";
            this.CancelarVentaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.CancelarVentaToolStripMenuItem.Text = "Anular Solicitud";
            this.CancelarVentaToolStripMenuItem.Click += new System.EventHandler(this.CancelarVentaToolStripMenuItem_Click);
            // 
            // FrmGestionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaVenta);
            this.Controls.Add(this.dgvVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionVenta";
            this.Load += new System.EventHandler(this.FrmListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuVenta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarListaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVentaProducto;
        public System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.TextBox txbBuscarVenta;
        private System.Windows.Forms.Button btnVentaServicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuVenta;
        private System.Windows.Forms.ToolStripMenuItem ModificarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelarVentaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.CheckBox CheckHabilitarFecha;
        private System.Windows.Forms.Button btnBuscarSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarnetIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubMonto;
        private System.Windows.Forms.ToolStripMenuItem DetalleVentaToolStripMenuItem;
    }
}