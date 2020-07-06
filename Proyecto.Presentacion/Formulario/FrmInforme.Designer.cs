namespace Proyecto.Presentacion.Formulario
{
    partial class FrmInforme
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
            this.reportViewerReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbEstadoPlan = new System.Windows.Forms.ComboBox();
            this.btnCargarInfoDemandaServicio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxDemanda = new System.Windows.Forms.GroupBox();
            this.groupBoxVenta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVentaMes = new System.Windows.Forms.ComboBox();
            this.btnCargarInfoVentaGeneral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVentaAño = new System.Windows.Forms.ComboBox();
            this.groupBoxDemanda.SuspendLayout();
            this.groupBoxVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerReporte
            // 
            this.reportViewerReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerReporte.Location = new System.Drawing.Point(0, 0);
            this.reportViewerReporte.Name = "reportViewerReporte";
            this.reportViewerReporte.Size = new System.Drawing.Size(828, 660);
            this.reportViewerReporte.TabIndex = 94;
            // 
            // cbEstadoPlan
            // 
            this.cbEstadoPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoPlan.FormattingEnabled = true;
            this.cbEstadoPlan.Location = new System.Drawing.Point(8, 53);
            this.cbEstadoPlan.Name = "cbEstadoPlan";
            this.cbEstadoPlan.Size = new System.Drawing.Size(93, 23);
            this.cbEstadoPlan.TabIndex = 95;
            // 
            // btnCargarInfoDemandaServicio
            // 
            this.btnCargarInfoDemandaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarInfoDemandaServicio.Location = new System.Drawing.Point(8, 113);
            this.btnCargarInfoDemandaServicio.Name = "btnCargarInfoDemandaServicio";
            this.btnCargarInfoDemandaServicio.Size = new System.Drawing.Size(93, 25);
            this.btnCargarInfoDemandaServicio.TabIndex = 96;
            this.btnCargarInfoDemandaServicio.Text = "Cargar";
            this.btnCargarInfoDemandaServicio.UseVisualStyleBackColor = true;
            this.btnCargarInfoDemandaServicio.Click += new System.EventHandler(this.btnCargarInfoDemandaServicio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "Estado:";
            // 
            // groupBoxDemanda
            // 
            this.groupBoxDemanda.Controls.Add(this.btnCargarInfoDemandaServicio);
            this.groupBoxDemanda.Controls.Add(this.label6);
            this.groupBoxDemanda.Controls.Add(this.cbEstadoPlan);
            this.groupBoxDemanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDemanda.Location = new System.Drawing.Point(8, 71);
            this.groupBoxDemanda.Name = "groupBoxDemanda";
            this.groupBoxDemanda.Size = new System.Drawing.Size(111, 166);
            this.groupBoxDemanda.TabIndex = 98;
            this.groupBoxDemanda.TabStop = false;
            this.groupBoxDemanda.Text = "Filtro";
            this.groupBoxDemanda.Visible = false;
            // 
            // groupBoxVenta
            // 
            this.groupBoxVenta.Controls.Add(this.label2);
            this.groupBoxVenta.Controls.Add(this.cbVentaMes);
            this.groupBoxVenta.Controls.Add(this.btnCargarInfoVentaGeneral);
            this.groupBoxVenta.Controls.Add(this.label1);
            this.groupBoxVenta.Controls.Add(this.cbVentaAño);
            this.groupBoxVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVenta.Location = new System.Drawing.Point(8, 267);
            this.groupBoxVenta.Name = "groupBoxVenta";
            this.groupBoxVenta.Size = new System.Drawing.Size(111, 201);
            this.groupBoxVenta.TabIndex = 99;
            this.groupBoxVenta.TabStop = false;
            this.groupBoxVenta.Text = "Filtro";
            this.groupBoxVenta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Mes:";
            // 
            // cbVentaMes
            // 
            this.cbVentaMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVentaMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVentaMes.FormattingEnabled = true;
            this.cbVentaMes.Location = new System.Drawing.Point(10, 105);
            this.cbVentaMes.Name = "cbVentaMes";
            this.cbVentaMes.Size = new System.Drawing.Size(93, 23);
            this.cbVentaMes.TabIndex = 98;
            // 
            // btnCargarInfoVentaGeneral
            // 
            this.btnCargarInfoVentaGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarInfoVentaGeneral.Location = new System.Drawing.Point(9, 152);
            this.btnCargarInfoVentaGeneral.Name = "btnCargarInfoVentaGeneral";
            this.btnCargarInfoVentaGeneral.Size = new System.Drawing.Size(93, 25);
            this.btnCargarInfoVentaGeneral.TabIndex = 96;
            this.btnCargarInfoVentaGeneral.Text = "Cargar";
            this.btnCargarInfoVentaGeneral.UseVisualStyleBackColor = true;
            this.btnCargarInfoVentaGeneral.Click += new System.EventHandler(this.btnCargarInfoVentaGeneral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "Año:";
            // 
            // cbVentaAño
            // 
            this.cbVentaAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVentaAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVentaAño.FormattingEnabled = true;
            this.cbVentaAño.Location = new System.Drawing.Point(8, 52);
            this.cbVentaAño.Name = "cbVentaAño";
            this.cbVentaAño.Size = new System.Drawing.Size(93, 23);
            this.cbVentaAño.TabIndex = 95;
            this.cbVentaAño.SelectedIndexChanged += new System.EventHandler(this.cbVentaAño_SelectedIndexChanged);
            // 
            // FrmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 660);
            this.Controls.Add(this.groupBoxVenta);
            this.Controls.Add(this.groupBoxDemanda);
            this.Controls.Add(this.reportViewerReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.FrmInforme_Load);
            this.groupBoxDemanda.ResumeLayout(false);
            this.groupBoxDemanda.PerformLayout();
            this.groupBoxVenta.ResumeLayout(false);
            this.groupBoxVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReporte;
        private System.Windows.Forms.ComboBox cbEstadoPlan;
        private System.Windows.Forms.Button btnCargarInfoDemandaServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVentaMes;
        private System.Windows.Forms.Button btnCargarInfoVentaGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVentaAño;
        public System.Windows.Forms.GroupBox groupBoxDemanda;
        public System.Windows.Forms.GroupBox groupBoxVenta;
    }
}