namespace Proyecto.Presentacion.Formulario
{
    partial class FrmHabilitarEmpleado
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
            this.btnHabilitarEmpleadoCliente = new System.Windows.Forms.Button();
            this.txtCedulaEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbNombreEmpleado = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHabilitarEmpleadoCliente
            // 
            this.btnHabilitarEmpleadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarEmpleadoCliente.Location = new System.Drawing.Point(110, 209);
            this.btnHabilitarEmpleadoCliente.Name = "btnHabilitarEmpleadoCliente";
            this.btnHabilitarEmpleadoCliente.Size = new System.Drawing.Size(103, 30);
            this.btnHabilitarEmpleadoCliente.TabIndex = 0;
            this.btnHabilitarEmpleadoCliente.Text = "Buscar";
            this.btnHabilitarEmpleadoCliente.UseVisualStyleBackColor = true;
            this.btnHabilitarEmpleadoCliente.Click += new System.EventHandler(this.btnHabilitarEmpleadoCliente_Click);
            // 
            // txtCedulaEmpleado
            // 
            this.txtCedulaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaEmpleado.Location = new System.Drawing.Point(104, 115);
            this.txtCedulaEmpleado.Name = "txtCedulaEmpleado";
            this.txtCedulaEmpleado.Size = new System.Drawing.Size(136, 22);
            this.txtCedulaEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar C.I.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(62, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 33);
            this.label16.TabIndex = 80;
            this.label16.Text = "Habilitación";
            // 
            // lbNombreEmpleado
            // 
            this.lbNombreEmpleado.AutoSize = true;
            this.lbNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEmpleado.Location = new System.Drawing.Point(101, 157);
            this.lbNombreEmpleado.Name = "lbNombreEmpleado";
            this.lbNombreEmpleado.Size = new System.Drawing.Size(23, 16);
            this.lbNombreEmpleado.TabIndex = 81;
            this.lbNombreEmpleado.Text = ".....";
            this.lbNombreEmpleado.Visible = false;
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleado.Location = new System.Drawing.Point(20, 157);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(71, 16);
            this.lbEmpleado.TabIndex = 82;
            this.lbEmpleado.Text = "Empleado";
            this.lbEmpleado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(52, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 83;
            this.label4.Text = "de Empleado";
            // 
            // FrmHabilitarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(298, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.lbNombreEmpleado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedulaEmpleado);
            this.Controls.Add(this.btnHabilitarEmpleadoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHabilitarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHabilitarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHabilitarEmpleadoCliente;
        private System.Windows.Forms.TextBox txtCedulaEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbNombreEmpleado;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.Label label4;
    }
}