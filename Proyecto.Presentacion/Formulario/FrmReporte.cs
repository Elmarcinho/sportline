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
    public partial class FrmReporte : Form
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.MostrarReporte(Utilitarios.Utilitarios.nroReporte);
            this.RptvGeneral.RefreshReport();
        }
        private void MostrarReporte(Int64 NroReporte)
        {
            try
            {
                ReportParameter FechaInicio = new ReportParameter("ParamFechaInicio", Utilitarios.Utilitarios.FechaInicio.ToString("dd/MM/yyyy"));
                ReportParameter FechaFin = new ReportParameter("ParamFechaFin", Utilitarios.Utilitarios.FechaFinal.ToString("dd/MM/yyyy"));
                ReportParameter Usuario = new ReportParameter("ParamUsuario", Utilitarios.Utilitarios.NombreUsuarioSession);
                switch (NroReporte)
                {
                    case 1:
                        var objRptCredito = from v in Esquema.VClienteDetalleCredito where v.CédulaIdentidad == Utilitarios.Utilitarios.CedulaIdendidad select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptDetalleCredito.rdlc";
                        //this.RptvCredito.LocalReport.ReportPath = Utilitarios.Utilitarios.RutaReporte + "RptDetalleCredito.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetCredito", objRptCredito));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 2:
                        var objRptProductoDiario = from v in Esquema.VProductoInventarioDiario where v.FechaSolicitud==Utilitarios.Utilitarios.FechaActual select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptProducto.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetProducto", objRptProductoDiario));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 3:
                        var objRptVenta = from v in Esquema.VClienteSolicitudGeneralConsolidado where v.Estado=="Entregado" && ((v.FechaSolicitud >= Utilitarios.Utilitarios.FechaInicio) && (v.FechaSolicitud <= Utilitarios.Utilitarios.FechaFinal)) select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptVentaDiaria.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetVentaDiaria", objRptVenta));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.SetParameters(FechaInicio);
                        this.RptvGeneral.LocalReport.SetParameters(FechaFin);
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 4:
                        var objRptIngreso = from v in Esquema.VIngresoGeneralConsolidado where ((v.Fecha >= Utilitarios.Utilitarios.FechaInicio) && (v.Fecha <= Utilitarios.Utilitarios.FechaFinal)) select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptIngresoDiario.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetIngreDiario", objRptIngreso));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.SetParameters(FechaInicio);
                        this.RptvGeneral.LocalReport.SetParameters(FechaFin);
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 5:
                        var objRptCumpleañero = from v in Esquema.VCumpleañeros select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptCumpleañero.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetCumpleañero", objRptCumpleañero));
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 6:
                        var objRptProducto = from v in Esquema.VProducto where v.Estado.Equals("Activo") select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptProductoGral.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetProductoGral", objRptProducto));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 7:
                        var objRptClienteDiario = from v in Esquema.VClienteSolicitudDiario where ((v.FechaSolicitud >= Utilitarios.Utilitarios.FechaInicio) && (v.FechaSolicitud <= Utilitarios.Utilitarios.FechaFinal)) select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptClienteDiario.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetClienteDiario", objRptClienteDiario));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.SetParameters(FechaInicio);
                        this.RptvGeneral.LocalReport.SetParameters(FechaFin);
                        this.RptvGeneral.LocalReport.Refresh();
                        break;
                    case 8:
                        var objRptClienteDetalleSolicitud = from v in Esquema.VClienteSolicitudDetalleGeneral where v.IdSolicitud==Utilitarios.Utilitarios.IdSolicitud select v;
                        this.RptvGeneral.ProcessingMode = ProcessingMode.Local;
                        this.RptvGeneral.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptDetalleSolicitud.rdlc";
                        this.RptvGeneral.LocalReport.DataSources.Clear();
                        this.RptvGeneral.LocalReport.DataSources.Add(new ReportDataSource("DataSetDetalleSolicitudGeneral", objRptClienteDetalleSolicitud));
                        this.RptvGeneral.LocalReport.SetParameters(Usuario);
                        this.RptvGeneral.LocalReport.Refresh();
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
