namespace Proyecto.Presentacion.Formulario
{
    partial class FrmListaProducto
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
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaProducto = new System.Windows.Forms.DataGridView();
            this.txbBuscarProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(185, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(316, 40);
            this.label16.TabIndex = 79;
            this.label16.Text = "Lista de Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Buscar por Nombre";
            // 
            // dgvListaProducto
            // 
            this.dgvListaProducto.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProducto.Location = new System.Drawing.Point(5, 91);
            this.dgvListaProducto.Name = "dgvListaProducto";
            this.dgvListaProducto.RowHeadersWidth = 30;
            this.dgvListaProducto.Size = new System.Drawing.Size(691, 222);
            this.dgvListaProducto.TabIndex = 77;
            this.dgvListaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProducto_CellContentClick);
            this.dgvListaProducto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaProducto_CellFormatting);
            this.dgvListaProducto.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProducto_CellMouseEnter);
            this.dgvListaProducto.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProducto_CellMouseLeave);
            this.dgvListaProducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListaProductoServicio_CellPainting);
            // 
            // txbBuscarProducto
            // 
            this.txbBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarProducto.Location = new System.Drawing.Point(132, 60);
            this.txbBuscarProducto.Name = "txbBuscarProducto";
            this.txbBuscarProducto.Size = new System.Drawing.Size(199, 22);
            this.txbBuscarProducto.TabIndex = 76;
            this.txbBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscarProducto_KeyPress);
            // 
            // FrmListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(702, 320);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaProducto);
            this.Controls.Add(this.txbBuscarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(370, 30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FrmListaProductoServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.TextBox txbBuscarProducto;
    }
}