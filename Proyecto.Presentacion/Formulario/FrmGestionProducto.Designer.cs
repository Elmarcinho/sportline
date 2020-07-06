namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarListaProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuProducto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txbBuscarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuProducto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(286, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(222, 40);
            this.label16.TabIndex = 78;
            this.label16.Text = "PRODUCTOS";
            // 
            // btnCerrarListaProducto
            // 
            this.btnCerrarListaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaProducto.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaProducto.Name = "btnCerrarListaProducto";
            this.btnCerrarListaProducto.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaProducto.TabIndex = 77;
            this.btnCerrarListaProducto.Text = "X";
            this.btnCerrarListaProducto.UseVisualStyleBackColor = true;
            this.btnCerrarListaProducto.Click += new System.EventHandler(this.btnCerrarListaProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoProducto.Enabled = false;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(16, 35);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(122, 36);
            this.btnNuevoProducto.TabIndex = 73;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombrePro,
            this.Descripcion,
            this.CodPrecio,
            this.PrecioC,
            this.PrecioV,
            this.StockProducto,
            this.CodCategoria,
            this.Categoria,
            this.EstadoProducto});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducto.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvProducto.Location = new System.Drawing.Point(58, 196);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(705, 347);
            this.dgvProducto.TabIndex = 72;
            this.dgvProducto.Visible = false;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            this.dgvProducto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducto_CellMouseClick);
            this.dgvProducto.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducto_CellMouseDown);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdProducto";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle30;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 55;
            // 
            // NombrePro
            // 
            this.NombrePro.DataPropertyName = "NombreProducto";
            this.NombrePro.HeaderText = "Nombre Producto";
            this.NombrePro.Name = "NombrePro";
            this.NombrePro.ReadOnly = true;
            this.NombrePro.Width = 185;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DescripcionProducto";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 225;
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioV.DefaultCellStyle = dataGridViewCellStyle31;
            this.PrecioV.HeaderText = "Precio";
            this.PrecioV.Name = "PrecioV";
            this.PrecioV.ReadOnly = true;
            this.PrecioV.Width = 60;
            // 
            // StockProducto
            // 
            this.StockProducto.DataPropertyName = "Stock";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StockProducto.DefaultCellStyle = dataGridViewCellStyle32;
            this.StockProducto.HeaderText = "Stock";
            this.StockProducto.Name = "StockProducto";
            this.StockProducto.ReadOnly = true;
            this.StockProducto.Width = 60;
            // 
            // CodCategoria
            // 
            this.CodCategoria.DataPropertyName = "IdCategoria";
            this.CodCategoria.HeaderText = "CodCategoria";
            this.CodCategoria.Name = "CodCategoria";
            this.CodCategoria.ReadOnly = true;
            this.CodCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "NombreCategoria";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle33;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 140;
            // 
            // EstadoProducto
            // 
            this.EstadoProducto.DataPropertyName = "Estado";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EstadoProducto.DefaultCellStyle = dataGridViewCellStyle34;
            this.EstadoProducto.HeaderText = "Estado";
            this.EstadoProducto.Name = "EstadoProducto";
            this.EstadoProducto.ReadOnly = true;
            this.EstadoProducto.Width = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnNuevoProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 93);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // contextMenuProducto
            // 
            this.contextMenuProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarProductoToolStripMenuItem,
            this.EliminarProductoToolStripMenuItem});
            this.contextMenuProducto.Name = "contextMenuProducto";
            this.contextMenuProducto.Size = new System.Drawing.Size(123, 48);
            // 
            // ModificarProductoToolStripMenuItem
            // 
            this.ModificarProductoToolStripMenuItem.Enabled = false;
            this.ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem";
            this.ModificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ModificarProductoToolStripMenuItem.Text = "Editar";
            this.ModificarProductoToolStripMenuItem.Click += new System.EventHandler(this.ModificarProductoToolStripMenuItem_Click);
            // 
            // EliminarProductoToolStripMenuItem
            // 
            this.EliminarProductoToolStripMenuItem.Enabled = false;
            this.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem";
            this.EliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.EliminarProductoToolStripMenuItem.Text = "Alta/Baja";
            this.EliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.EliminarProductoToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.txbBuscarProducto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 93);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Productos";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(200, 51);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarProducto.TabIndex = 90;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txbBuscarProducto
            // 
            this.txbBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarProducto.Location = new System.Drawing.Point(18, 54);
            this.txbBuscarProducto.Name = "txbBuscarProducto";
            this.txbBuscarProducto.Size = new System.Drawing.Size(166, 22);
            this.txbBuscarProducto.TabIndex = 20;
            this.txbBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarProducto_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buscar por Nombre";
            // 
            // FrmGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaProducto);
            this.Controls.Add(this.dgvProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionProducto";
            this.Load += new System.EventHandler(this.FrmListaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuProducto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarListaProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        public System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuProducto;
        private System.Windows.Forms.ToolStripMenuItem ModificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarProductoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txbBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProducto;
    }
}