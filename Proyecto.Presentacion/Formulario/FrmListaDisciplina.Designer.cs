namespace Proyecto.Presentacion.Formulario
{
    partial class FrmListaDisciplina
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
            this.dgvListaServicio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(206, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(290, 40);
            this.label16.TabIndex = 83;
            this.label16.Text = "Lista de Servicios";
            // 
            // dgvListaServicio
            // 
            this.dgvListaServicio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaServicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaServicio.Location = new System.Drawing.Point(6, 93);
            this.dgvListaServicio.Name = "dgvListaServicio";
            this.dgvListaServicio.RowHeadersWidth = 30;
            this.dgvListaServicio.Size = new System.Drawing.Size(673, 222);
            this.dgvListaServicio.TabIndex = 81;
            this.dgvListaServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicio_CellContentClick);
            this.dgvListaServicio.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicio_CellMouseEnter);
            this.dgvListaServicio.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicio_CellMouseLeave);
            this.dgvListaServicio.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListaServicio_CellPainting);
            // 
            // FrmListaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(685, 320);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvListaServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(370, 30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Servicio";
            this.Load += new System.EventHandler(this.FrmListaServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvListaServicio;
    }
}