namespace Proyecto.Presentacion.Formulario
{
    partial class FrmServicio
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
            this.txtPrecioDiario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardarServicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionServicio = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioMensual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioQuincenal = new System.Windows.Forms.TextBox();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRangoDia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecioDiario
            // 
            this.txtPrecioDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDiario.Location = new System.Drawing.Point(157, 236);
            this.txtPrecioDiario.Name = "txtPrecioDiario";
            this.txtPrecioDiario.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioDiario.TabIndex = 111;
            this.txtPrecioDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioDiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVentaServicio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Precio Diario";
            // 
            // BtnGuardarServicio
            // 
            this.BtnGuardarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarServicio.Location = new System.Drawing.Point(214, 383);
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
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nombre Servicio";
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
            this.label16.Location = new System.Drawing.Point(111, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(294, 36);
            this.label16.TabIndex = 97;
            this.label16.Text = "Registro de Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "Precio Quincenal";
            // 
            // txtPrecioMensual
            // 
            this.txtPrecioMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMensual.Location = new System.Drawing.Point(157, 298);
            this.txtPrecioMensual.Name = "txtPrecioMensual";
            this.txtPrecioMensual.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioMensual.TabIndex = 115;
            this.txtPrecioMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioMensual.TextChanged += new System.EventHandler(this.txtPrecioMensual_TextChanged);
            this.txtPrecioMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMensual_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Precio Mensual";
            // 
            // txtPrecioQuincenal
            // 
            this.txtPrecioQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioQuincenal.Location = new System.Drawing.Point(157, 267);
            this.txtPrecioQuincenal.Name = "txtPrecioQuincenal";
            this.txtPrecioQuincenal.ReadOnly = true;
            this.txtPrecioQuincenal.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioQuincenal.TabIndex = 116;
            this.txtPrecioQuincenal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Checked = false;
            this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(380, 236);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(103, 22);
            this.dtpHoraInicio.TabIndex = 117;
            this.dtpHoraInicio.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 118;
            this.label6.Text = "Hora Inicio";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Checked = false;
            this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(381, 270);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(103, 22);
            this.dtpHoraFin.TabIndex = 119;
            this.dtpHoraFin.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 120;
            this.label7.Text = "Hora Fin";
            // 
            // cbRangoDia
            // 
            this.cbRangoDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRangoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRangoDia.FormattingEnabled = true;
            this.cbRangoDia.Location = new System.Drawing.Point(359, 298);
            this.cbRangoDia.Name = "cbRangoDia";
            this.cbRangoDia.Size = new System.Drawing.Size(124, 24);
            this.cbRangoDia.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 122;
            this.label8.Text = "Dias";
            // 
            // FrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbRangoDia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.txtPrecioQuincenal);
            this.Controls.Add(this.txtPrecioMensual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioDiario);
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
            this.Name = "FrmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Servicio";
            this.Load += new System.EventHandler(this.FrmServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPrecioDiario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardarServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescripcionServicio;
        public System.Windows.Forms.TextBox txtNombreServicio;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPrecioMensual;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrecioQuincenal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtpHoraFin;
        public System.Windows.Forms.ComboBox cbRangoDia;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtpHoraInicio;
    }
}