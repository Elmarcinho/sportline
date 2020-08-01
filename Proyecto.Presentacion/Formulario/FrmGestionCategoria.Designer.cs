namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionCategoria
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
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarListaCategoria = new System.Windows.Forms.Button();
            this.btnNuevoCategoria = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListaCategoria = new System.Windows.Forms.Button();
            this.contextMenuCategoria = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModificarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(285, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(211, 40);
            this.label16.TabIndex = 89;
            this.label16.Text = "CATEGORIA";
            // 
            // btnCerrarListaCategoria
            // 
            this.btnCerrarListaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaCategoria.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaCategoria.Name = "btnCerrarListaCategoria";
            this.btnCerrarListaCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaCategoria.TabIndex = 88;
            this.btnCerrarListaCategoria.Text = "X";
            this.btnCerrarListaCategoria.UseVisualStyleBackColor = true;
            this.btnCerrarListaCategoria.Click += new System.EventHandler(this.btnCerrarListaCategoria_Click);
            // 
            // btnNuevoCategoria
            // 
            this.btnNuevoCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoCategoria.Enabled = false;
            this.btnNuevoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCategoria.Location = new System.Drawing.Point(16, 35);
            this.btnNuevoCategoria.Name = "btnNuevoCategoria";
            this.btnNuevoCategoria.Size = new System.Drawing.Size(118, 36);
            this.btnNuevoCategoria.TabIndex = 84;
            this.btnNuevoCategoria.Text = "Nuevo Categoria";
            this.btnNuevoCategoria.UseVisualStyleBackColor = true;
            this.btnNuevoCategoria.Click += new System.EventHandler(this.btnNuevoCategoria_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategoria.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoria.Location = new System.Drawing.Point(58, 196);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.Size = new System.Drawing.Size(472, 347);
            this.dgvCategoria.TabIndex = 83;
            this.dgvCategoria.Visible = false;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            this.dgvCategoria.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategoria_CellMouseClick);
            this.dgvCategoria.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategoria_CellMouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnMostrarListaCategoria);
            this.groupBox1.Controls.Add(this.btnNuevoCategoria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 93);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // btnMostrarListaCategoria
            // 
            this.btnMostrarListaCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMostrarListaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaCategoria.Location = new System.Drawing.Point(144, 35);
            this.btnMostrarListaCategoria.Name = "btnMostrarListaCategoria";
            this.btnMostrarListaCategoria.Size = new System.Drawing.Size(121, 36);
            this.btnMostrarListaCategoria.TabIndex = 71;
            this.btnMostrarListaCategoria.Text = "Ver Lista";
            this.btnMostrarListaCategoria.UseVisualStyleBackColor = true;
            this.btnMostrarListaCategoria.Click += new System.EventHandler(this.btnMostrarListaCategoria_Click);
            // 
            // contextMenuCategoria
            // 
            this.contextMenuCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModificarCategoriaToolStripMenuItem,
            this.EliminarCategoriaToolStripMenuItem});
            this.contextMenuCategoria.Name = "contextMenuCategoria";
            this.contextMenuCategoria.Size = new System.Drawing.Size(123, 48);
            // 
            // ModificarCategoriaToolStripMenuItem
            // 
            this.ModificarCategoriaToolStripMenuItem.Name = "ModificarCategoriaToolStripMenuItem";
            this.ModificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ModificarCategoriaToolStripMenuItem.Text = "Editar";
            this.ModificarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.ModificarCategoriaToolStripMenuItem_Click);
            // 
            // EliminarCategoriaToolStripMenuItem
            // 
            this.EliminarCategoriaToolStripMenuItem.Name = "EliminarCategoriaToolStripMenuItem";
            this.EliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.EliminarCategoriaToolStripMenuItem.Text = "Alta/Baja";
            this.EliminarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.EliminarCategoriaToolStripMenuItem_Click);
            // 
            // FrmGestionCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionCategoria";
            this.Load += new System.EventHandler(this.FrmListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuCategoria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarListaCategoria;
        private System.Windows.Forms.Button btnNuevoCategoria;
        public System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarListaCategoria;
        private System.Windows.Forms.ContextMenuStrip contextMenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem ModificarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarCategoriaToolStripMenuItem;
    }
}