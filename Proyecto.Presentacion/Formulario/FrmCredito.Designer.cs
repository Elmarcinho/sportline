namespace Proyecto.Presentacion.Formulario
{
    partial class FrmCredito
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
            this.txtCuotaPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardarCredito = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoSaldoCredito = new System.Windows.Forms.TextBox();
            this.CheckCreditoTotal = new System.Windows.Forms.CheckBox();
            this.txtSaldoActualCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuotaPagar
            // 
            this.txtCuotaPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuotaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaPagar.Location = new System.Drawing.Point(159, 167);
            this.txtCuotaPagar.Name = "txtCuotaPagar";
            this.txtCuotaPagar.Size = new System.Drawing.Size(99, 22);
            this.txtCuotaPagar.TabIndex = 19;
            this.txtCuotaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuotaPagar.TextChanged += new System.EventHandler(this.txtCuotaPagar_TextChanged);
            this.txtCuotaPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotaPagar_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cuota a Pagar";
            // 
            // btnGuardarCredito
            // 
            this.btnGuardarCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCredito.Location = new System.Drawing.Point(159, 302);
            this.btnGuardarCredito.Name = "btnGuardarCredito";
            this.btnGuardarCredito.Size = new System.Drawing.Size(107, 38);
            this.btnGuardarCredito.TabIndex = 79;
            this.btnGuardarCredito.Text = "Guardar";
            this.btnGuardarCredito.UseVisualStyleBackColor = true;
            this.btnGuardarCredito.Click += new System.EventHandler(this.btnGuardarCredito_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(96, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(237, 33);
            this.label16.TabIndex = 80;
            this.label16.Text = "Pago de Crédito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nuevo Saldo Crédito";
            // 
            // txtNuevoSaldoCredito
            // 
            this.txtNuevoSaldoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevoSaldoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoSaldoCredito.Location = new System.Drawing.Point(159, 209);
            this.txtNuevoSaldoCredito.Name = "txtNuevoSaldoCredito";
            this.txtNuevoSaldoCredito.ReadOnly = true;
            this.txtNuevoSaldoCredito.Size = new System.Drawing.Size(99, 22);
            this.txtNuevoSaldoCredito.TabIndex = 82;
            this.txtNuevoSaldoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckCreditoTotal
            // 
            this.CheckCreditoTotal.AutoSize = true;
            this.CheckCreditoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCreditoTotal.Location = new System.Drawing.Point(92, 256);
            this.CheckCreditoTotal.Name = "CheckCreditoTotal";
            this.CheckCreditoTotal.Size = new System.Drawing.Size(277, 20);
            this.CheckCreditoTotal.TabIndex = 83;
            this.CheckCreditoTotal.Text = "Pagar todos los Créditos del Cliente";
            this.CheckCreditoTotal.UseVisualStyleBackColor = true;
            this.CheckCreditoTotal.CheckedChanged += new System.EventHandler(this.CheckCreditoTotal_CheckedChanged);
            // 
            // txtSaldoActualCredito
            // 
            this.txtSaldoActualCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoActualCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoActualCredito.Location = new System.Drawing.Point(159, 125);
            this.txtSaldoActualCredito.Name = "txtSaldoActualCredito";
            this.txtSaldoActualCredito.ReadOnly = true;
            this.txtSaldoActualCredito.Size = new System.Drawing.Size(99, 22);
            this.txtSaldoActualCredito.TabIndex = 85;
            this.txtSaldoActualCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Saldo Actual Crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Nombre de Cliente";
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.Location = new System.Drawing.Point(156, 90);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(53, 18);
            this.lbNombreCliente.TabIndex = 87;
            this.lbNombreCliente.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 88;
            this.label4.Text = "Bs.-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 89;
            this.label5.Text = "Bs.-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 90;
            this.label6.Text = "Bs.-";
            // 
            // FrmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(421, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldoActualCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckCreditoTotal);
            this.Controls.Add(this.txtNuevoSaldoCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnGuardarCredito);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCuotaPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Pago de Crédito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuotaPagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardarCredito;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckCreditoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbNombreCliente;
        public System.Windows.Forms.TextBox txtNuevoSaldoCredito;
        public System.Windows.Forms.TextBox txtSaldoActualCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}