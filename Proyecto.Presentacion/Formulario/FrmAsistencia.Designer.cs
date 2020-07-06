namespace Proyecto.Presentacion.Formulario
{
    partial class FrmAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.lbEstadoPlan = new System.Windows.Forms.Label();
            this.pnAsistencia = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbCodigoCliente = new System.Windows.Forms.Label();
            this.NotificacionDeudor = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbcCliente = new Proyecto.Presentacion.Help.PictureCircular();
            this.pnAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(126, 40);
            this.txtCedulaCliente.Multiline = true;
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(210, 27);
            this.txtCedulaCliente.TabIndex = 95;
            this.txtCedulaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaCliente_KeyPress);
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lbNombreCliente.Location = new System.Drawing.Point(80, 14);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(99, 31);
            this.lbNombreCliente.TabIndex = 97;
            this.lbNombreCliente.Text = "Cliente";
            // 
            // lbEstadoPlan
            // 
            this.lbEstadoPlan.AutoSize = true;
            this.lbEstadoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoPlan.ForeColor = System.Drawing.SystemColors.Window;
            this.lbEstadoPlan.Location = new System.Drawing.Point(131, 55);
            this.lbEstadoPlan.Name = "lbEstadoPlan";
            this.lbEstadoPlan.Size = new System.Drawing.Size(191, 37);
            this.lbEstadoPlan.TabIndex = 98;
            this.lbEstadoPlan.Text = "EstadoPlan";
            // 
            // pnAsistencia
            // 
            this.pnAsistencia.BackColor = System.Drawing.SystemColors.Window;
            this.pnAsistencia.Controls.Add(this.label2);
            this.pnAsistencia.Controls.Add(this.label1);
            this.pnAsistencia.Controls.Add(this.lbDias);
            this.pnAsistencia.Controls.Add(this.lbNombreCliente);
            this.pnAsistencia.Controls.Add(this.lbEstadoPlan);
            this.pnAsistencia.Location = new System.Drawing.Point(0, 297);
            this.pnAsistencia.Name = "pnAsistencia";
            this.pnAsistencia.Size = new System.Drawing.Size(462, 149);
            this.pnAsistencia.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(273, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 101;
            this.label2.Text = "dias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(119, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 100;
            this.label1.Text = "Saldo";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDias.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDias.Location = new System.Drawing.Point(205, 92);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(53, 42);
            this.lbDias.TabIndex = 99;
            this.lbDias.Text = "Di";
            this.lbDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCodigoCliente
            // 
            this.lbCodigoCliente.AutoSize = true;
            this.lbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(145)))), ((int)(((byte)(142)))));
            this.lbCodigoCliente.Location = new System.Drawing.Point(132, 18);
            this.lbCodigoCliente.Name = "lbCodigoCliente";
            this.lbCodigoCliente.Size = new System.Drawing.Size(194, 20);
            this.lbCodigoCliente.TabIndex = 103;
            this.lbCodigoCliente.Text = "Ingresar código de Cliente";
            // 
            // NotificacionDeudor
            // 
            this.NotificacionDeudor.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificacionDeudor.Icon")));
            this.NotificacionDeudor.Text = "NotificacionSportLine";
            this.NotificacionDeudor.Visible = true;
            this.NotificacionDeudor.BalloonTipClicked += new System.EventHandler(this.NotificacionDeudor_BalloonTipClicked);
            // 
            // pbcCliente
            // 
            this.pbcCliente.ErrorImage = null;
            this.pbcCliente.Image = global::Proyecto.Presentacion.Properties.Resources.user;
            this.pbcCliente.Location = new System.Drawing.Point(126, 81);
            this.pbcCliente.Name = "pbcCliente";
            this.pbcCliente.Size = new System.Drawing.Size(210, 210);
            this.pbcCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcCliente.TabIndex = 96;
            this.pbcCliente.TabStop = false;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(462, 446);
            this.Controls.Add(this.lbCodigoCliente);
            this.Controls.Add(this.pnAsistencia);
            this.Controls.Add(this.pbcCliente);
            this.Controls.Add(this.txtCedulaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Asistencia";
            this.Load += new System.EventHandler(this.FrmAsistencia_Load);
            this.pnAsistencia.ResumeLayout(false);
            this.pnAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedulaCliente;
        public Help.PictureCircular pbcCliente;
        private System.Windows.Forms.Label lbNombreCliente;
        private System.Windows.Forms.Label lbEstadoPlan;
        private System.Windows.Forms.Panel pnAsistencia;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodigoCliente;
        private System.Windows.Forms.NotifyIcon NotificacionDeudor;
    }
}