namespace Proyecto.Presentacion.Formulario
{
    partial class FrmCargarCredito
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
            this.txtCedulaNit = new System.Windows.Forms.TextBox();
            this.btnCargarRptCredito = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCedulaNit
            // 
            this.txtCedulaNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaNit.Location = new System.Drawing.Point(73, 119);
            this.txtCedulaNit.Name = "txtCedulaNit";
            this.txtCedulaNit.Size = new System.Drawing.Size(144, 24);
            this.txtCedulaNit.TabIndex = 14;
            this.txtCedulaNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedulaNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaNit_KeyPress);
            // 
            // btnCargarRptCredito
            // 
            this.btnCargarRptCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarRptCredito.Location = new System.Drawing.Point(82, 185);
            this.btnCargarRptCredito.Name = "btnCargarRptCredito";
            this.btnCargarRptCredito.Size = new System.Drawing.Size(129, 30);
            this.btnCargarRptCredito.TabIndex = 13;
            this.btnCargarRptCredito.Text = "Cargar Datos";
            this.btnCargarRptCredito.UseVisualStyleBackColor = true;
            this.btnCargarRptCredito.Click += new System.EventHandler(this.btnCargarRptCredito_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(6, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(273, 33);
            this.label16.TabIndex = 81;
            this.label16.Text = "Datos para Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Ingresar C.I. del Cliente";
            // 
            // FrmCargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCedulaNit);
            this.Controls.Add(this.btnCargarRptCredito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Cedula Identidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCedulaNit;
        private System.Windows.Forms.Button btnCargarRptCredito;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
    }
}