namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionAsistencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevaAsistencia = new System.Windows.Forms.Button();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txbBuscarCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarAsistencia = new System.Windows.Forms.Button();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbNombreDias = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnNuevaAsistencia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 93);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btnNuevaAsistencia
            // 
            this.btnNuevaAsistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevaAsistencia.Enabled = false;
            this.btnNuevaAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaAsistencia.Location = new System.Drawing.Point(16, 35);
            this.btnNuevaAsistencia.Name = "btnNuevaAsistencia";
            this.btnNuevaAsistencia.Size = new System.Drawing.Size(140, 36);
            this.btnNuevaAsistencia.TabIndex = 73;
            this.btnNuevaAsistencia.Text = "Registrar Asistencia";
            this.btnNuevaAsistencia.UseVisualStyleBackColor = true;
            this.btnNuevaAsistencia.Click += new System.EventHandler(this.btnNuevaAsistencia_Click);
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsistencia.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.Cedula,
            this.FechaAsistencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencia.Location = new System.Drawing.Point(58, 204);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(574, 347);
            this.dgvAsistencia.TabIndex = 100;
            this.dgvAsistencia.Visible = false;
            this.dgvAsistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellClick);
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 300;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CédulaIdentidad";
            this.Cedula.HeaderText = "C.I.";
            this.Cedula.Name = "Cedula";
            this.Cedula.Visible = false;
            // 
            // FechaAsistencia
            // 
            this.FechaAsistencia.DataPropertyName = "FechaAsistencia";
            this.FechaAsistencia.HeaderText = "Fecha de Asistencia";
            this.FechaAsistencia.Name = "FechaAsistencia";
            this.FechaAsistencia.ReadOnly = true;
            this.FechaAsistencia.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txbBuscarCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(339, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 93);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Asistencia";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(272, 51);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(113, 22);
            this.dtpFechaFin.TabIndex = 103;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(124, 54);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarCliente.TabIndex = 90;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txbBuscarCliente
            // 
            this.txbBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.txbBuscarCliente.Location = new System.Drawing.Point(24, 26);
            this.txbBuscarCliente.Name = "txbBuscarCliente";
            this.txbBuscarCliente.Size = new System.Drawing.Size(181, 22);
            this.txbBuscarCliente.TabIndex = 20;
            this.txbBuscarCliente.Text = "Nombre del Cliente";
            this.txbBuscarCliente.Enter += new System.EventHandler(this.txbBuscarCliente_Enter);
            this.txbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarCliente_KeyPress);
            this.txbBuscarCliente.Leave += new System.EventHandler(this.txbBuscarCliente_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Al";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Del";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(272, 23);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(113, 22);
            this.dtpFechaInicio.TabIndex = 102;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(347, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 40);
            this.label16.TabIndex = 98;
            this.label16.Text = "ASISTENCIA";
            // 
            // btnCerrarAsistencia
            // 
            this.btnCerrarAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarAsistencia.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarAsistencia.Name = "btnCerrarAsistencia";
            this.btnCerrarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarAsistencia.TabIndex = 97;
            this.btnCerrarAsistencia.Text = "X";
            this.btnCerrarAsistencia.UseVisualStyleBackColor = true;
            this.btnCerrarAsistencia.Click += new System.EventHandler(this.btnCerrarAsistencia_Click);
            // 
            // lbDias
            // 
            this.lbDias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDias.Location = new System.Drawing.Point(649, 267);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(53, 42);
            this.lbDias.TabIndex = 102;
            this.lbDias.Text = "Di";
            this.lbDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNombreDias
            // 
            this.lbNombreDias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNombreDias.AutoSize = true;
            this.lbNombreDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDias.ForeColor = System.Drawing.SystemColors.Window;
            this.lbNombreDias.Location = new System.Drawing.Point(631, 233);
            this.lbNombreDias.Name = "lbNombreDias";
            this.lbNombreDias.Size = new System.Drawing.Size(113, 25);
            this.lbNombreDias.TabIndex = 103;
            this.lbNombreDias.Text = "Saldo dias";
            this.lbNombreDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGestionAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.lbNombreDias);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarAsistencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionAsistencia";
            this.Text = "FrmGestionAsistencia";
            this.Load += new System.EventHandler(this.FrmGestionAsistencia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevaAsistencia;
        public System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txbBuscarCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarAsistencia;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAsistencia;
        private System.Windows.Forms.Label lbNombreDias;
    }
}