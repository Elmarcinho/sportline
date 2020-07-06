namespace Proyecto.Presentacion.Formulario
{
    partial class FrmGestionPago
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
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrarListaPagos = new System.Windows.Forms.Button();
            this.btnPagoCredito = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPagoServicio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(347, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 40);
            this.label16.TabIndex = 89;
            this.label16.Text = "PAGOS";
            // 
            // btnCerrarListaPagos
            // 
            this.btnCerrarListaPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarListaPagos.Location = new System.Drawing.Point(688, 1);
            this.btnCerrarListaPagos.Name = "btnCerrarListaPagos";
            this.btnCerrarListaPagos.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarListaPagos.TabIndex = 88;
            this.btnCerrarListaPagos.Text = "X";
            this.btnCerrarListaPagos.UseVisualStyleBackColor = true;
            this.btnCerrarListaPagos.Click += new System.EventHandler(this.btnCerrarListaPagos_Click);
            // 
            // btnPagoCredito
            // 
            this.btnPagoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagoCredito.Enabled = false;
            this.btnPagoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoCredito.Location = new System.Drawing.Point(25, 29);
            this.btnPagoCredito.Name = "btnPagoCredito";
            this.btnPagoCredito.Size = new System.Drawing.Size(120, 40);
            this.btnPagoCredito.TabIndex = 84;
            this.btnPagoCredito.Text = "Crédito por Cobrar";
            this.btnPagoCredito.UseVisualStyleBackColor = true;
            this.btnPagoCredito.Click += new System.EventHandler(this.btnPagoCredito_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btnPagoServicio);
            this.groupBox1.Controls.Add(this.btnPagoCredito);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 85);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Pago de:";
            // 
            // btnPagoServicio
            // 
            this.btnPagoServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagoServicio.Enabled = false;
            this.btnPagoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoServicio.Location = new System.Drawing.Point(162, 29);
            this.btnPagoServicio.Name = "btnPagoServicio";
            this.btnPagoServicio.Size = new System.Drawing.Size(120, 40);
            this.btnPagoServicio.TabIndex = 85;
            this.btnPagoServicio.Text = "Servicio";
            this.btnPagoServicio.UseVisualStyleBackColor = true;
            this.btnPagoServicio.Click += new System.EventHandler(this.btnPagoServicio_Click);
            // 
            // FrmGestionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCerrarListaPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionPago";
            this.Load += new System.EventHandler(this.FrmListaPagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrarListaPagos;
        private System.Windows.Forms.Button btnPagoCredito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPagoServicio;
    }
}