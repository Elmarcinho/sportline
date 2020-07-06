namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListaDescuento = new System.Windows.Forms.Button();
            this.btnNuevoDescuento = new System.Windows.Forms.Button();
            this.dgvDescuento = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarEmpresa = new System.Windows.Forms.Button();
            this.CodigoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuDescuento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarDescuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuento)).BeginInit();
            this.contextMenuDescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnMostrarListaDescuento);
            this.groupBox1.Controls.Add(this.dgvDescuento);
            this.groupBox1.Controls.Add(this.btnNuevoDescuento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 285);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuentos";
            // 
            // btnMostrarListaDescuento
            // 
            this.btnMostrarListaDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMostrarListaDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaDescuento.Location = new System.Drawing.Point(144, 33);
            this.btnMostrarListaDescuento.Name = "btnMostrarListaDescuento";
            this.btnMostrarListaDescuento.Size = new System.Drawing.Size(124, 36);
            this.btnMostrarListaDescuento.TabIndex = 77;
            this.btnMostrarListaDescuento.Text = "Ver Lista";
            this.btnMostrarListaDescuento.UseVisualStyleBackColor = true;
            this.btnMostrarListaDescuento.Click += new System.EventHandler(this.btnMostrarListaDescuento_Click);
            // 
            // btnNuevoDescuento
            // 
            this.btnNuevoDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoDescuento.Enabled = false;
            this.btnNuevoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDescuento.Location = new System.Drawing.Point(16, 33);
            this.btnNuevoDescuento.Name = "btnNuevoDescuento";
            this.btnNuevoDescuento.Size = new System.Drawing.Size(122, 36);
            this.btnNuevoDescuento.TabIndex = 73;
            this.btnNuevoDescuento.Text = "Nuevo";
            this.btnNuevoDescuento.UseVisualStyleBackColor = true;
            this.btnNuevoDescuento.Click += new System.EventHandler(this.btnNuevoDescuento_Click);
            // 
            // dgvDescuento
            // 
            this.dgvDescuento.AllowUserToAddRows = false;
            this.dgvDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDescuento.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescuento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDescuento,
            this.NombreDes,
            this.MontoDescuento,
            this.EstadoDescuento});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescuento.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDescuento.Location = new System.Drawing.Point(6, 98);
            this.dgvDescuento.Name = "dgvDescuento";
            this.dgvDescuento.Size = new System.Drawing.Size(385, 168);
            this.dgvDescuento.TabIndex = 96;
            this.dgvDescuento.Visible = false;
            this.dgvDescuento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuento_CellClick);
            this.dgvDescuento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDescuento_CellMouseClick);
            this.dgvDescuento.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDescuento_CellMouseDown);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(280, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 40);
            this.label16.TabIndex = 95;
            this.label16.Text = "EMPRESA";
            // 
            // btnCerrarEmpresa
            // 
            this.btnCerrarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarEmpresa.Location = new System.Drawing.Point(678, 10);
            this.btnCerrarEmpresa.Name = "btnCerrarEmpresa";
            this.btnCerrarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarEmpresa.TabIndex = 94;
            this.btnCerrarEmpresa.Text = "X";
            this.btnCerrarEmpresa.UseVisualStyleBackColor = true;
            this.btnCerrarEmpresa.Click += new System.EventHandler(this.btnCerrarEmpresa_Click);
            // 
            // CodigoDescuento
            // 
            this.CodigoDescuento.DataPropertyName = "IdDescuento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodigoDescuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoDescuento.HeaderText = "IdDescuento";
            this.CodigoDescuento.Name = "CodigoDescuento";
            this.CodigoDescuento.Visible = false;
            this.CodigoDescuento.Width = 55;
            // 
            // NombreDes
            // 
            this.NombreDes.DataPropertyName = "NombreDescuento";
            this.NombreDes.HeaderText = "Descripcion Descuento";
            this.NombreDes.Name = "NombreDes";
            this.NombreDes.ReadOnly = true;
            this.NombreDes.Width = 200;
            // 
            // MontoDescuento
            // 
            this.MontoDescuento.DataPropertyName = "Monto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MontoDescuento.DefaultCellStyle = dataGridViewCellStyle3;
            this.MontoDescuento.HeaderText = "Monto";
            this.MontoDescuento.Name = "MontoDescuento";
            this.MontoDescuento.ReadOnly = true;
            this.MontoDescuento.Width = 70;
            // 
            // EstadoDescuento
            // 
            this.EstadoDescuento.DataPropertyName = "Estado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EstadoDescuento.DefaultCellStyle = dataGridViewCellStyle4;
            this.EstadoDescuento.HeaderText = "Estado";
            this.EstadoDescuento.Name = "EstadoDescuento";
            this.EstadoDescuento.ReadOnly = true;
            this.EstadoDescuento.Width = 70;
            // 
            // contextMenuDescuento
            // 
            this.contextMenuDescuento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarDescuentoToolStripMenuItem,
            this.AltaBajaToolStripMenuItem});
            this.contextMenuDescuento.Name = "contextMenuDescuento";
            this.contextMenuDescuento.Size = new System.Drawing.Size(153, 70);
            // 
            // ModificarDescuentoToolStripMenuItem
            // 
            this.ModificarDescuentoToolStripMenuItem.Name = "ModificarDescuentoToolStripMenuItem";
            this.ModificarDescuentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ModificarDescuentoToolStripMenuItem.Text = "Editar";
            this.ModificarDescuentoToolStripMenuItem.Click += new System.EventHandler(this.ModificarDescuentoToolStripMenuItem_Click);
            // 
            // AltaBajaToolStripMenuItem
            // 
            this.AltaBajaToolStripMenuItem.Name = "AltaBajaToolStripMenuItem";
            this.AltaBajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AltaBajaToolStripMenuItem.Text = "Alta/Baja";
            this.AltaBajaToolStripMenuItem.Click += new System.EventHandler(this.AltaBajaToolStripMenuItem_Click);
            // 
            // FrmGestionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionEmpresa";
            this.Load += new System.EventHandler(this.FrmGestionEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuento)).EndInit();
            this.contextMenuDescuento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarListaDescuento;
        private System.Windows.Forms.Button btnNuevoDescuento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarEmpresa;
        private System.Windows.Forms.DataGridView dgvDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDescuento;
        private System.Windows.Forms.ContextMenuStrip contextMenuDescuento;
        private System.Windows.Forms.ToolStripMenuItem ModificarDescuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AltaBajaToolStripMenuItem;
    }
}