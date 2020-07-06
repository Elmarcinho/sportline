namespace Proyecto.Presentacion.Formulario
{
    partial class FrmPagoServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPagoServicio = new System.Windows.Forms.DataGridView();
            this.CodSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbModificarCliente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCedulaNit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagarServicio = new System.Windows.Forms.Button();
            this.contextMenuPago = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClienteServicio = new System.Windows.Forms.DataGridView();
            this.CodServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoServicio)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.contextMenuPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteServicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPagoServicio
            // 
            this.dgvPagoServicio.AllowUserToAddRows = false;
            this.dgvPagoServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagoServicio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagoServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodSolicitud,
            this.FechaSolicitud,
            this.CodPago,
            this.NombreCliente,
            this.Cedula,
            this.NombrePlan});
            this.dgvPagoServicio.Location = new System.Drawing.Point(16, 24);
            this.dgvPagoServicio.Name = "dgvPagoServicio";
            this.dgvPagoServicio.Size = new System.Drawing.Size(563, 164);
            this.dgvPagoServicio.TabIndex = 82;
            this.dgvPagoServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagoServicio_CellClick);
            this.dgvPagoServicio.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPagoServicio_CellMouseClick);
            this.dgvPagoServicio.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPagoServicio_CellMouseDown);
            // 
            // CodSolicitud
            // 
            this.CodSolicitud.DataPropertyName = "IdSolicitud";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodSolicitud.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodSolicitud.HeaderText = "Nº Solicitud";
            this.CodSolicitud.Name = "CodSolicitud";
            this.CodSolicitud.ReadOnly = true;
            this.CodSolicitud.Width = 86;
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.DataPropertyName = "FechaSolicitud";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaSolicitud.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaSolicitud.HeaderText = "Fecha Solicitud";
            this.FechaSolicitud.Name = "FechaSolicitud";
            this.FechaSolicitud.ReadOnly = true;
            // 
            // CodPago
            // 
            this.CodPago.DataPropertyName = "Código";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodPago.DefaultCellStyle = dataGridViewCellStyle4;
            this.CodPago.HeaderText = "IdCliente";
            this.CodPago.Name = "CodPago";
            this.CodPago.ReadOnly = true;
            this.CodPago.Visible = false;
            this.CodPago.Width = 85;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 193;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CédulaIdentidad";
            this.Cedula.HeaderText = "C.I";
            this.Cedula.Name = "Cedula";
            this.Cedula.Visible = false;
            // 
            // NombrePlan
            // 
            this.NombrePlan.DataPropertyName = "Planes";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NombrePlan.DefaultCellStyle = dataGridViewCellStyle5;
            this.NombrePlan.HeaderText = "Plan";
            this.NombrePlan.Name = "NombrePlan";
            this.NombrePlan.ReadOnly = true;
            this.NombrePlan.Width = 140;
            // 
            // lbModificarCliente
            // 
            this.lbModificarCliente.AutoSize = true;
            this.lbModificarCliente.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarCliente.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbModificarCliente.Location = new System.Drawing.Point(174, 3);
            this.lbModificarCliente.Name = "lbModificarCliente";
            this.lbModificarCliente.Size = new System.Drawing.Size(257, 36);
            this.lbModificarCliente.TabIndex = 81;
            this.lbModificarCliente.Text = "Pago de Servicio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCedulaNit);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnBuscarCliente);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 95);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLIENTE";
            // 
            // txtCedulaNit
            // 
            this.txtCedulaNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaNit.Location = new System.Drawing.Point(135, 29);
            this.txtCedulaNit.Name = "txtCedulaNit";
            this.txtCedulaNit.Size = new System.Drawing.Size(144, 22);
            this.txtCedulaNit.TabIndex = 11;
            this.txtCedulaNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedulaNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaNit_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "CI / NIT:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(313, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(93, 25);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscador";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(135, 62);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(271, 22);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sr (a):";
            // 
            // btnPagarServicio
            // 
            this.btnPagarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarServicio.Location = new System.Drawing.Point(261, 575);
            this.btnPagarServicio.Name = "btnPagarServicio";
            this.btnPagarServicio.Size = new System.Drawing.Size(107, 38);
            this.btnPagarServicio.TabIndex = 85;
            this.btnPagarServicio.Text = "Pagar Servicio";
            this.btnPagarServicio.UseVisualStyleBackColor = true;
            this.btnPagarServicio.Click += new System.EventHandler(this.btnPagarServicio_Click);
            // 
            // contextMenuPago
            // 
            this.contextMenuPago.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPagosToolStripMenuItem});
            this.contextMenuPago.Name = "contextMenuPago";
            this.contextMenuPago.Size = new System.Drawing.Size(127, 26);
            // 
            // verPagosToolStripMenuItem
            // 
            this.verPagosToolStripMenuItem.Name = "verPagosToolStripMenuItem";
            this.verPagosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.verPagosToolStripMenuItem.Text = "Ver Pagos";
            this.verPagosToolStripMenuItem.Click += new System.EventHandler(this.verPagosToolStripMenuItem_Click);
            // 
            // dgvClienteServicio
            // 
            this.dgvClienteServicio.AllowUserToAddRows = false;
            this.dgvClienteServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClienteServicio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClienteServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodServicio,
            this.NombreServicio,
            this.IdPrecio,
            this.PrecioServicio});
            this.dgvClienteServicio.Location = new System.Drawing.Point(16, 23);
            this.dgvClienteServicio.Name = "dgvClienteServicio";
            this.dgvClienteServicio.Size = new System.Drawing.Size(563, 123);
            this.dgvClienteServicio.TabIndex = 89;
            this.dgvClienteServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteServicio_CellClick);
            // 
            // CodServicio
            // 
            this.CodServicio.DataPropertyName = "IdServicio";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodServicio.DefaultCellStyle = dataGridViewCellStyle7;
            this.CodServicio.HeaderText = "IdServicio";
            this.CodServicio.Name = "CodServicio";
            this.CodServicio.Visible = false;
            this.CodServicio.Width = 86;
            // 
            // NombreServicio
            // 
            this.NombreServicio.DataPropertyName = "NombreServicio";
            this.NombreServicio.HeaderText = "Servicio";
            this.NombreServicio.Name = "NombreServicio";
            this.NombreServicio.ReadOnly = true;
            this.NombreServicio.Width = 200;
            // 
            // IdPrecio
            // 
            this.IdPrecio.DataPropertyName = "IdPrecio";
            this.IdPrecio.HeaderText = "IdPrecio";
            this.IdPrecio.Name = "IdPrecio";
            this.IdPrecio.Visible = false;
            // 
            // PrecioServicio
            // 
            this.PrecioServicio.DataPropertyName = "Precio";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioServicio.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrecioServicio.HeaderText = "Precio";
            this.PrecioServicio.Name = "PrecioServicio";
            this.PrecioServicio.ReadOnly = true;
            this.PrecioServicio.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPagoServicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 204);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SOLICITUDES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClienteServicio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 163);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVICIOS";
            // 
            // FrmPagoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(630, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPagarServicio);
            this.Controls.Add(this.lbModificarCliente);
            this.Location = new System.Drawing.Point(310, 105);
            this.MaximizeBox = false;
            this.Name = "FrmPagoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de Pago de Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoServicio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteServicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvPagoServicio;
        public System.Windows.Forms.Label lbModificarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtCedulaNit;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPagarServicio;
        private System.Windows.Forms.ContextMenuStrip contextMenuPago;
        private System.Windows.Forms.ToolStripMenuItem verPagosToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvClienteServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioServicio;
    }
}