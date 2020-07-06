namespace Proyecto.Presentacion.Formulario
{
    partial class FrmDisciplina
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
            this.txtPrecioVentaServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionServicio = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPlazo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPrecioVentaServicio
            // 
            this.txtPrecioVentaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaServicio.Location = new System.Drawing.Point(157, 236);
            this.txtPrecioVentaServicio.Name = "txtPrecioVentaServicio";
            this.txtPrecioVentaServicio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioVentaServicio.TabIndex = 111;
            this.txtPrecioVentaServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioVentaServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVentaServicio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Precio";
            // 
            // BtnGuardarServicio
            // 
            this.BtnGuardarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarServicio.Location = new System.Drawing.Point(174, 340);
            this.BtnGuardarServicio.Name = "BtnGuardarServicio";
            this.BtnGuardarServicio.Size = new System.Drawing.Size(106, 37);
            this.BtnGuardarServicio.TabIndex = 104;
            this.BtnGuardarServicio.Text = "Guardar";
            this.BtnGuardarServicio.UseVisualStyleBackColor = true;
            this.BtnGuardarServicio.Click += new System.EventHandler(this.BtnGuardarServicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nombre Disciplina";
            // 
            // txtDescripcionServicio
            // 
            this.txtDescripcionServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionServicio.Location = new System.Drawing.Point(157, 145);
            this.txtDescripcionServicio.Multiline = true;
            this.txtDescripcionServicio.Name = "txtDescripcionServicio";
            this.txtDescripcionServicio.Size = new System.Drawing.Size(240, 76);
            this.txtDescripcionServicio.TabIndex = 99;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(157, 106);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(240, 22);
            this.txtNombreServicio.TabIndex = 98;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(75, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(320, 36);
            this.label16.TabIndex = 97;
            this.label16.Text = "Registro de Disciplina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "Plan";
            // 
            // cbPlazo
            // 
            this.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlazo.FormattingEnabled = true;
            this.cbPlazo.Location = new System.Drawing.Point(157, 275);
            this.cbPlazo.Name = "cbPlazo";
            this.cbPlazo.Size = new System.Drawing.Size(144, 24);
            this.cbPlazo.TabIndex = 112;
            // 
            // FrmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(435, 410);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPlazo);
            this.Controls.Add(this.txtPrecioVentaServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGuardarServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Servicio";
            this.Load += new System.EventHandler(this.FrmServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPrecioVentaServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardarServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescripcionServicio;
        public System.Windows.Forms.TextBox txtNombreServicio;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPlazo;
    }
}