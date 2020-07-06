namespace Proyecto.Presentacion.Formulario
{
    partial class FrmPagoCredito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbModificarCliente = new System.Windows.Forms.Label();
            this.dgvCredito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnCredito = new System.Windows.Forms.Button();
            this.lbCreditoTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // lbModificarCliente
            // 
            this.lbModificarCliente.AutoSize = true;
            this.lbModificarCliente.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarCliente.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbModificarCliente.Location = new System.Drawing.Point(329, 2);
            this.lbModificarCliente.Name = "lbModificarCliente";
            this.lbModificarCliente.Size = new System.Drawing.Size(295, 36);
            this.lbModificarCliente.TabIndex = 74;
            this.lbModificarCliente.Text = "Cuentas por cobrar";
            // 
            // dgvCredito
            // 
            this.dgvCredito.AllowUserToAddRows = false;
            this.dgvCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCredito.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitud,
            this.IdCredito,
            this.NombreCliente,
            this.FechaSolicitud,
            this.FechaPlazo,
            this.MontoCredito,
            this.MontoCuota,
            this.SaldoCredito});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCredito.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCredito.Location = new System.Drawing.Point(8, 110);
            this.dgvCredito.Name = "dgvCredito";
            this.dgvCredito.Size = new System.Drawing.Size(893, 218);
            this.dgvCredito.TabIndex = 75;
            this.dgvCredito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCredito_CellClick);
            this.dgvCredito.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCredito_CellFormatting);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Buscar por Nombre o C.I.";
            // 
            // txbBuscarCliente
            // 
            this.txbBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarCliente.Location = new System.Drawing.Point(166, 78);
            this.txbBuscarCliente.Name = "txbBuscarCliente";
            this.txbBuscarCliente.Size = new System.Drawing.Size(191, 22);
            this.txbBuscarCliente.TabIndex = 76;
            this.txbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarCliente_KeyPress);
            // 
            // btnCredito
            // 
            this.btnCredito.Enabled = false;
            this.btnCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.Location = new System.Drawing.Point(413, 367);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(107, 38);
            this.btnCredito.TabIndex = 78;
            this.btnCredito.Text = "Pagar Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // lbCreditoTotal
            // 
            this.lbCreditoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCreditoTotal.AutoSize = true;
            this.lbCreditoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditoTotal.Location = new System.Drawing.Point(824, 335);
            this.lbCreditoTotal.Name = "lbCreditoTotal";
            this.lbCreditoTotal.Size = new System.Drawing.Size(36, 16);
            this.lbCreditoTotal.TabIndex = 79;
            this.lbCreditoTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Total Bs.-";
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.DataPropertyName = "CodVenta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdSolicitud.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdSolicitud.HeaderText = "Nº Solicitud";
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Width = 86;
            // 
            // IdCredito
            // 
            this.IdCredito.DataPropertyName = "CodCrédito";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCredito.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdCredito.HeaderText = "Nº Crédito";
            this.IdCredito.Name = "IdCredito";
            this.IdCredito.ReadOnly = true;
            this.IdCredito.Width = 94;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 170;
            // 
            // FechaSolicitud
            // 
            this.FechaSolicitud.DataPropertyName = "FechaCredito";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaSolicitud.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaSolicitud.HeaderText = "F. Crédito";
            this.FechaSolicitud.Name = "FechaSolicitud";
            this.FechaSolicitud.ReadOnly = true;
            // 
            // FechaPlazo
            // 
            this.FechaPlazo.DataPropertyName = "FechaPlazo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FechaPlazo.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaPlazo.HeaderText = "F. Plazo";
            this.FechaPlazo.Name = "FechaPlazo";
            this.FechaPlazo.ReadOnly = true;
            // 
            // MontoCredito
            // 
            this.MontoCredito.DataPropertyName = "MontoCrédito";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MontoCredito.DefaultCellStyle = dataGridViewCellStyle6;
            this.MontoCredito.HeaderText = "Monto Crédito";
            this.MontoCredito.Name = "MontoCredito";
            this.MontoCredito.ReadOnly = true;
            // 
            // MontoCuota
            // 
            this.MontoCuota.DataPropertyName = "MontoCuota";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MontoCuota.DefaultCellStyle = dataGridViewCellStyle7;
            this.MontoCuota.HeaderText = "Monto Cuota";
            this.MontoCuota.Name = "MontoCuota";
            this.MontoCuota.ReadOnly = true;
            // 
            // SaldoCredito
            // 
            this.SaldoCredito.DataPropertyName = "Saldo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.SaldoCredito.DefaultCellStyle = dataGridViewCellStyle8;
            this.SaldoCredito.HeaderText = "Saldo";
            this.SaldoCredito.Name = "SaldoCredito";
            this.SaldoCredito.ReadOnly = true;
            // 
            // FrmPagoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(909, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCreditoTotal);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBuscarCliente);
            this.Controls.Add(this.dgvCredito);
            this.Controls.Add(this.lbModificarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(310, 105);
            this.MaximizeBox = false;
            this.Name = "FrmPagoCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Información de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbModificarCliente;
        public System.Windows.Forms.DataGridView dgvCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCredito;
        public System.Windows.Forms.TextBox txbBuscarCliente;
        private System.Windows.Forms.Label lbCreditoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoCredito;
    }
}