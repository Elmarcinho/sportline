namespace Proyecto.Presentacion.Formulario
{
    partial class FrmEmpleado
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
            this.txtDireccionE = new System.Windows.Forms.TextBox();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.rbFemeninoE = new System.Windows.Forms.RadioButton();
            this.rbMasculinoE = new System.Windows.Forms.RadioButton();
            this.BtnGuardarEmpleado = new System.Windows.Forms.Button();
            this.dtFechanacimientoE = new System.Windows.Forms.DateTimePicker();
            this.txtCiE = new System.Windows.Forms.TextBox();
            this.txtApmE = new System.Windows.Forms.TextBox();
            this.txtAppE = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFechaIngresoE = new System.Windows.Forms.DateTimePicker();
            this.lbRegistroEmpleado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbcEmpleado = new Proyecto.Presentacion.Help.PictureCircular();
            this.label9 = new System.Windows.Forms.Label();
            this.lnModificarEmpleado = new System.Windows.Forms.Label();
            this.cbCiudadZonaEmpleado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbcEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccionE
            // 
            this.txtDireccionE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionE.Location = new System.Drawing.Point(127, 319);
            this.txtDireccionE.Multiline = true;
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.Size = new System.Drawing.Size(200, 51);
            this.txtDireccionE.TabIndex = 47;
            this.txtDireccionE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionE_KeyPress);
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoE.Location = new System.Drawing.Point(127, 287);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(200, 22);
            this.txtTelefonoE.TabIndex = 46;
            this.txtTelefonoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoE_KeyPress);
            // 
            // rbFemeninoE
            // 
            this.rbFemeninoE.AutoSize = true;
            this.rbFemeninoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemeninoE.Location = new System.Drawing.Point(228, 259);
            this.rbFemeninoE.Name = "rbFemeninoE";
            this.rbFemeninoE.Size = new System.Drawing.Size(86, 20);
            this.rbFemeninoE.TabIndex = 45;
            this.rbFemeninoE.Text = "Femenino";
            this.rbFemeninoE.UseVisualStyleBackColor = true;
            // 
            // rbMasculinoE
            // 
            this.rbMasculinoE.AutoSize = true;
            this.rbMasculinoE.Checked = true;
            this.rbMasculinoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculinoE.Location = new System.Drawing.Point(117, 259);
            this.rbMasculinoE.Name = "rbMasculinoE";
            this.rbMasculinoE.Size = new System.Drawing.Size(87, 20);
            this.rbMasculinoE.TabIndex = 44;
            this.rbMasculinoE.TabStop = true;
            this.rbMasculinoE.Text = "Masculino";
            this.rbMasculinoE.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarEmpleado
            // 
            this.BtnGuardarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarEmpleado.Location = new System.Drawing.Point(257, 451);
            this.BtnGuardarEmpleado.Name = "BtnGuardarEmpleado";
            this.BtnGuardarEmpleado.Size = new System.Drawing.Size(106, 37);
            this.BtnGuardarEmpleado.TabIndex = 43;
            this.BtnGuardarEmpleado.Text = "Guardar";
            this.BtnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.BtnGuardarEmpleado.Click += new System.EventHandler(this.BtnGuardarEmpleado_Click);
            // 
            // dtFechanacimientoE
            // 
            this.dtFechanacimientoE.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechanacimientoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechanacimientoE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechanacimientoE.Location = new System.Drawing.Point(127, 228);
            this.dtFechanacimientoE.Name = "dtFechanacimientoE";
            this.dtFechanacimientoE.Size = new System.Drawing.Size(135, 22);
            this.dtFechanacimientoE.TabIndex = 42;
            this.dtFechanacimientoE.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtCiE
            // 
            this.txtCiE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiE.Location = new System.Drawing.Point(127, 192);
            this.txtCiE.Name = "txtCiE";
            this.txtCiE.Size = new System.Drawing.Size(200, 22);
            this.txtCiE.TabIndex = 41;
            this.txtCiE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiE_KeyPress);
            // 
            // txtApmE
            // 
            this.txtApmE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApmE.Location = new System.Drawing.Point(127, 157);
            this.txtApmE.Name = "txtApmE";
            this.txtApmE.Size = new System.Drawing.Size(200, 22);
            this.txtApmE.TabIndex = 40;
            this.txtApmE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApmE_KeyPress);
            // 
            // txtAppE
            // 
            this.txtAppE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppE.Location = new System.Drawing.Point(127, 122);
            this.txtAppE.Name = "txtAppE";
            this.txtAppE.Size = new System.Drawing.Size(200, 22);
            this.txtAppE.TabIndex = 39;
            this.txtAppE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAppE_KeyPress);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(127, 90);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(200, 22);
            this.txtNombreEmpleado.TabIndex = 38;
            this.txtNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpleado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cedula Identidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apelllido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apelllido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre Empleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Fecha Ingreso";
            // 
            // dtFechaIngresoE
            // 
            this.dtFechaIngresoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngresoE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngresoE.Location = new System.Drawing.Point(127, 376);
            this.dtFechaIngresoE.Name = "dtFechaIngresoE";
            this.dtFechaIngresoE.Size = new System.Drawing.Size(135, 22);
            this.dtFechaIngresoE.TabIndex = 52;
            // 
            // lbRegistroEmpleado
            // 
            this.lbRegistroEmpleado.AutoSize = true;
            this.lbRegistroEmpleado.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroEmpleado.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbRegistroEmpleado.Location = new System.Drawing.Point(149, 18);
            this.lbRegistroEmpleado.Name = "lbRegistroEmpleado";
            this.lbRegistroEmpleado.Size = new System.Drawing.Size(331, 36);
            this.lbRegistroEmpleado.TabIndex = 69;
            this.lbRegistroEmpleado.Text = "Registro de Empleado";
            this.lbRegistroEmpleado.Visible = false;
            // 
            // pbcEmpleado
            // 
            this.pbcEmpleado.Image = global::Proyecto.Presentacion.Properties.Resources.user;
            this.pbcEmpleado.Location = new System.Drawing.Point(375, 90);
            this.pbcEmpleado.Name = "pbcEmpleado";
            this.pbcEmpleado.Size = new System.Drawing.Size(205, 204);
            this.pbcEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcEmpleado.TabIndex = 70;
            this.pbcEmpleado.TabStop = false;
            this.toolTip1.SetToolTip(this.pbcEmpleado, "Dar Clic para la foto");
            this.pbcEmpleado.Click += new System.EventHandler(this.pbcEmpleado_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(385, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 21);
            this.label9.TabIndex = 71;
            this.label9.Text = "Clic para agregar foto";
            // 
            // lnModificarEmpleado
            // 
            this.lnModificarEmpleado.AutoSize = true;
            this.lnModificarEmpleado.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnModificarEmpleado.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lnModificarEmpleado.Location = new System.Drawing.Point(76, 18);
            this.lnModificarEmpleado.Name = "lnModificarEmpleado";
            this.lnModificarEmpleado.Size = new System.Drawing.Size(488, 36);
            this.lnModificarEmpleado.TabIndex = 72;
            this.lnModificarEmpleado.Text = "Editar Información del Empleado";
            this.lnModificarEmpleado.Visible = false;
            // 
            // cbCiudadZonaEmpleado
            // 
            this.cbCiudadZonaEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudadZonaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudadZonaEmpleado.FormattingEnabled = true;
            this.cbCiudadZonaEmpleado.Location = new System.Drawing.Point(374, 375);
            this.cbCiudadZonaEmpleado.Name = "cbCiudadZonaEmpleado";
            this.cbCiudadZonaEmpleado.Size = new System.Drawing.Size(222, 24);
            this.cbCiudadZonaEmpleado.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(372, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 75;
            this.label14.Text = "Ciudad/Zona";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(618, 511);
            this.Controls.Add(this.cbCiudadZonaEmpleado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lnModificarEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbcEmpleado);
            this.Controls.Add(this.lbRegistroEmpleado);
            this.Controls.Add(this.dtFechaIngresoE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDireccionE);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.rbFemeninoE);
            this.Controls.Add(this.rbMasculinoE);
            this.Controls.Add(this.BtnGuardarEmpleado);
            this.Controls.Add(this.dtFechanacimientoE);
            this.Controls.Add(this.txtCiE);
            this.Controls.Add(this.txtApmE);
            this.Controls.Add(this.txtAppE);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del Empleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuardarEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtDireccionE;
        public System.Windows.Forms.TextBox txtTelefonoE;
        public System.Windows.Forms.RadioButton rbFemeninoE;
        public System.Windows.Forms.RadioButton rbMasculinoE;
        public System.Windows.Forms.DateTimePicker dtFechanacimientoE;
        public System.Windows.Forms.TextBox txtCiE;
        public System.Windows.Forms.TextBox txtApmE;
        public System.Windows.Forms.TextBox txtAppE;
        public System.Windows.Forms.TextBox txtNombreEmpleado;
        public System.Windows.Forms.DateTimePicker dtFechaIngresoE;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lnModificarEmpleado;
        public System.Windows.Forms.Label lbRegistroEmpleado;
        public System.Windows.Forms.ComboBox cbCiudadZonaEmpleado;
        private System.Windows.Forms.Label label14;
        public Help.PictureCircular pbcEmpleado;
    }
}