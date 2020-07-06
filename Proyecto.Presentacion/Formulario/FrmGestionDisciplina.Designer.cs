namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionDisciplina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarListaServicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListaServicio = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
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
            this.label16.Size = new System.Drawing.Size(212, 40);
            this.label16.TabIndex = 78;
            this.label16.Text = "DISCIPLINAS";
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
            this.btnNuevoServicio.Text = "Nueva Disciplina";
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
            this.Codigo,
            this.NombreSer,
            this.DescripcionSer,
            this.NombrePlazo,
            this.CodPrecio,
            this.PrecioC,
            this.PrecioV,
            this.Estado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServicio.Location = new System.Drawing.Point(58, 196);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.Size = new System.Drawing.Size(620, 347);
            this.dgvServicio.TabIndex = 92;
            this.dgvServicio.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdServicio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 55;
            // 
            // NombreSer
            // 
            this.NombreSer.DataPropertyName = "NombreDisciplina";
            this.NombreSer.HeaderText = "Nombre Disciplina";
            this.NombreSer.Name = "NombreSer";
            this.NombreSer.ReadOnly = true;
            this.NombreSer.Width = 180;
            // 
            // DescripcionSer
            // 
            this.DescripcionSer.DataPropertyName = "Descripcion";
            this.DescripcionSer.HeaderText = "Descripción";
            this.DescripcionSer.Name = "DescripcionSer";
            this.DescripcionSer.ReadOnly = true;
            this.DescripcionSer.Width = 300;
            // 
            // NombrePlazo
            // 
            this.NombrePlazo.DataPropertyName = "Plazo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NombrePlazo.DefaultCellStyle = dataGridViewCellStyle3;
            this.NombrePlazo.HeaderText = "Plan";
            this.NombrePlazo.Name = "NombrePlazo";
            this.NombrePlazo.ReadOnly = true;
            // 
            // CodPrecio
            // 
            this.CodPrecio.DataPropertyName = "IdPrecio";
            this.CodPrecio.HeaderText = "CodPrecio";
            this.CodPrecio.Name = "CodPrecio";
            this.CodPrecio.ReadOnly = true;
            this.CodPrecio.Visible = false;
            // 
            // PrecioC
            // 
            this.PrecioC.DataPropertyName = "PrecioCompra";
            this.PrecioC.HeaderText = "Precio Compra";
            this.PrecioC.Name = "PrecioC";
            this.PrecioC.Visible = false;
            // 
            // PrecioV
            // 
            this.PrecioV.DataPropertyName = "PrecioVenta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioV.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecioV.HeaderText = "Precio";
            this.PrecioV.Name = "PrecioV";
            this.PrecioV.ReadOnly = true;
            this.PrecioV.Width = 90;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "EstadoServicio";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // FrmGestionDisciplina
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
            this.Name = "FrmGestionDisciplina";
            this.Load += new System.EventHandler(this.FrmListaServicio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}