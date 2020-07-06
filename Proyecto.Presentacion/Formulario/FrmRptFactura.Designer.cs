namespace Proyecto.Presentacion.Formulario
{
    partial class FrmRptFactura
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
            this.RptvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RptvFactura
            // 
            this.RptvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptvFactura.Location = new System.Drawing.Point(0, 0);
            this.RptvFactura.Name = "RptvFactura";
            this.RptvFactura.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.RptvFactura.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.RptvFactura.Size = new System.Drawing.Size(377, 662);
            this.RptvFactura.TabIndex = 0;
            // 
            // FrmRptFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 662);
            this.Controls.Add(this.RptvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRptFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Factura de Venta";
            this.Load += new System.EventHandler(this.FrmRptFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptvFactura;
    }
}