namespace Proyecto.Presentacion.Formulario
{
    partial class FrmDescuento
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
            this.lbTituloDescuento = new System.Windows.Forms.Label();
            this.btnGuardarDescuento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoDescuento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTituloDescuento
            // 
            this.lbTituloDescuento.AutoSize = true;
            this.lbTituloDescuento.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloDescuento.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbTituloDescuento.Location = new System.Drawing.Point(13, 3);
            this.lbTituloDescuento.Name = "lbTituloDescuento";
            this.lbTituloDescuento.Size = new System.Drawing.Size(313, 33);
            this.lbTituloDescuento.TabIndex = 83;
            this.lbTituloDescuento.Text = "Registro de Descuento";
            // 
            // btnGuardarDescuento
            // 
            this.btnGuardarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDescuento.Location = new System.Drawing.Point(137, 256);
            this.btnGuardarDescuento.Name = "btnGuardarDescuento";
            this.btnGuardarDescuento.Size = new System.Drawing.Size(94, 33);
            this.btnGuardarDescuento.TabIndex = 82;
            this.btnGuardarDescuento.Text = "Guardar";
            this.btnGuardarDescuento.UseVisualStyleBackColor = true;
            this.btnGuardarDescuento.Click += new System.EventHandler(this.btnGuardarDescuento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Descripcion";
            // 
            // txtNombreDescuento
            // 
            this.txtNombreDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDescuento.Location = new System.Drawing.Point(101, 118);
            this.txtNombreDescuento.Multiline = true;
            this.txtNombreDescuento.Name = "txtNombreDescuento";
            this.txtNombreDescuento.Size = new System.Drawing.Size(225, 48);
            this.txtNombreDescuento.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 93;
            this.label5.Text = "Monto";
            // 
            // txtMontoDescuento
            // 
            this.txtMontoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDescuento.Location = new System.Drawing.Point(101, 182);
            this.txtMontoDescuento.Name = "txtMontoDescuento";
            this.txtMontoDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtMontoDescuento.TabIndex = 92;
            this.txtMontoDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoDescuento_KeyPress);
            // 
            // FrmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(343, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoDescuento);
            this.Controls.Add(this.lbTituloDescuento);
            this.Controls.Add(this.btnGuardarDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreDescuento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarDescuento;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombreDescuento;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtMontoDescuento;
        public System.Windows.Forms.Label lbTituloDescuento;
    }
}