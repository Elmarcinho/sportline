using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Proyecto.Datos;


namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmRptFactura : Form
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public FrmRptFactura()
        {
            InitializeComponent();
        }
        private void FrmRptFactura_Load(object sender, EventArgs e)
        {
            this.MostrarReporte(Utilitarios.Utilitarios.nroReporte);
            this.RptvFactura.RefreshReport();
        }
        private void MostrarReporte(Int64 NroReporte)
        {
            try
            {
                switch (NroReporte)
                {
                    case 1:
                        var objRptFacturaProducto = from v in Esquema.VFacturaGeneral where v.IdSolicitud == Utilitarios.Utilitarios.IdSolicitud select v;
                        this.RptvFactura.ProcessingMode = ProcessingMode.Local;
                        this.RptvFactura.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptFactura.rdlc";
                        //this.RptvFactura.LocalReport.ReportPath = Utilitarios.Utilitarios.RutaReporte + "RptFactura.rdlc";
                        this.RptvFactura.LocalReport.DataSources.Clear();
                        this.RptvFactura.LocalReport.DataSources.Add(new ReportDataSource("DataSetFactura", objRptFacturaProducto));
                        this.RptvFactura.LocalReport.Refresh();
                        break;
                    case 2:
                        var objRptFacturaServicio = from v in Esquema.VFacturaGeneral where v.IdSolicitud == Utilitarios.Utilitarios.IdSolicitud && v.IdFactura == Utilitarios.Utilitarios.IdFactura select v;
                        this.RptvFactura.ProcessingMode = ProcessingMode.Local;
                        this.RptvFactura.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptFactura.rdlc";
                        //this.RptvFactura.LocalReport.ReportPath = Utilitarios.Utilitarios.RutaReporte + "RptFactura.rdlc";
                        this.RptvFactura.LocalReport.DataSources.Clear();
                        this.RptvFactura.LocalReport.DataSources.Add(new ReportDataSource("DataSetFactura", objRptFacturaServicio));
                        this.RptvFactura.LocalReport.Refresh();
                        break;
                    case 3://Factura de pedido
                        //Negocio.RNLista.RNFactura cdatos = new Negocio.RNLista.RNFactura();
                        //this.reportViewer1.ProcessingMode = ProcessingMode.Remote;
                        //this.reportViewer1.ServerReport.ReportServerUrl = new Uri("http://elmarcinho-pc:90/ReportServer_ELMARCINHO");
                        //this.reportViewer1.ServerReport.ReportPath = "/Proyecto.Informe/rptFactura";
                        //this.reportViewer1.Refresh();
                        break;
                    default:
                        break;


                }
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message);
            }
        }
    }
}
