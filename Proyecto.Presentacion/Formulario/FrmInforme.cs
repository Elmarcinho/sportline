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
    public partial class FrmInforme : Form
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public FrmInforme()
        {
            InitializeComponent();
        }

        private void FrmInforme_Load(object sender, EventArgs e)
        {
            this.MostrarInforme(Utilitarios.Utilitarios.nroReporte);
            this.reportViewerReporte.RefreshReport();
            this.CargarComboEstadoPlan();
            this.CargarComboAño();
            cbEstadoPlan.SelectedIndex = 1;
        }
        private void CargarComboAño()
        {
            Negocio.RNLista.RNSolicitud objAño = new Negocio.RNLista.RNSolicitud();
            var ObjAñoVenta = objAño.TraerAñoVenta(0);

            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("IdAño"));
            dta.Columns.Add(new DataColumn("NombreAño"));

            DataRow dr = dta.NewRow();
            dr["IdAño"] = 0;
            dr["NombreAño"] = "-Seleccionar-";
            dta.Rows.Add(dr);

            foreach ( var item in ObjAñoVenta)
            {
                DataRow drColomn = dta.NewRow();
                drColomn["IdAño"] = item.IdAño;
                drColomn["NombreAño"] = item.NombreAño;
                dta.Rows.Add(drColomn);
            }
            this.cbVentaAño.DataSource = dta;
            this.cbVentaAño.DisplayMember = "NombreAño";
            this.cbVentaAño.ValueMember = "IdAño";

        }
        private void CargarComboMes()
        {
            Negocio.RNLista.RNSolicitud objMes = new Negocio.RNLista.RNSolicitud();
            var ObjMesVenta = objMes.TraerMesVenta(Convert.ToInt64(cbVentaAño.Text.ToString()));        

            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("IdMes"));
            dta.Columns.Add(new DataColumn("NombreMes"));

            DataRow dr = dta.NewRow();
            dr["IdMes"] = 0;
            dr["NombreMes"] = "- Todos -";
            dta.Rows.Add(dr);

            foreach (var item in ObjMesVenta)
            {
                DataRow drColomn = dta.NewRow();
                drColomn["IdMes"] = item.IdMes;
                drColomn["NombreMes"] = item.NombreMes;
                dta.Rows.Add(drColomn);
            }
            this.cbVentaMes.DataSource = dta;
            this.cbVentaMes.DisplayMember = "NombreMes";
            this.cbVentaMes.ValueMember = "IdMes";
        }
        private void CargarComboEstadoPlan()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdEstado");
            dt.Columns.Add("NombreEstado");
            dt.AcceptChanges();

            DataRow dr0 = dt.NewRow();
            dr0[0] = "0";
            dr0[1] = "Todos";

            DataRow dr1 = dt.NewRow();
            dr1[0] = "1";
            dr1[1] = "Vigente";

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Vencido";

            dt.Rows.Add(dr0);
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.AcceptChanges();

            this.cbEstadoPlan.DisplayMember = "NombreEstado";
            this.cbEstadoPlan.ValueMember = "IdEstado";
            this.cbEstadoPlan.DataSource = dt;
        }
        private void cbVentaAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVentaAño.SelectedIndex != 0)
            { this.CargarComboMes(); }
            else
            {
                cbVentaMes.DataSource = null;
                cbVentaMes.Text = "-Seleccionar-";
            }
        }
        private void MostrarInforme(Int64 NroReporte)
        {
            try
            {
                ReportParameter Usuario = new ReportParameter("ParamUsuario", Utilitarios.Utilitarios.NombreUsuarioSession);
                switch (NroReporte)
                {
                    case 1:
                        this.reportViewerReporte.ProcessingMode = ProcessingMode.Remote;
                        this.reportViewerReporte.ServerReport.ReportServerUrl = new Uri("http://viviana-murguia:90/ReportServer");
                        this.reportViewerReporte.ServerReport.ReportPath = "/Proyecto.Informe/RptVentasGeneral";
                        this.reportViewerReporte.Refresh();
                        //if (Utilitarios.Utilitarios.EventoInfo == 1)
                        //{
                        //    var objRptVentasGeneral = from v in Esquema.VClienteSolicitudGeneralConsolidado where v.CodVenta==0 select v;
                        //    this.reportViewerReporte.ProcessingMode = ProcessingMode.Local;
                        //    this.reportViewerReporte.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptInformeVentaGeneral.rdlc";
                        //    this.reportViewerReporte.LocalReport.DataSources.Clear();
                        //    this.reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetVentasGeneral", objRptVentasGeneral));
                        //    this.reportViewerReporte.LocalReport.SetParameters(Usuario);
                        //    this.reportViewerReporte.LocalReport.Refresh();
                        //}
                        //else
                        //{
                        //    if (cbVentaMes.Text == "- Todos -")
                        //    {
                        //        var objRptVentasGeneral = from v in Esquema.VClienteSolicitudGeneralConsolidado where v.AñoSolicitud == Utilitarios.Utilitarios.Año select v;
                        //        this.reportViewerReporte.ProcessingMode = ProcessingMode.Local;
                        //        this.reportViewerReporte.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptInformeVentaGeneral.rdlc";
                        //        this.reportViewerReporte.LocalReport.DataSources.Clear();
                        //        this.reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetVentasGeneral", objRptVentasGeneral));
                        //        this.reportViewerReporte.LocalReport.SetParameters(Usuario);
                        //        this.reportViewerReporte.LocalReport.Refresh();
                        //    }
                        //    else
                        //    {
                        //        var objRptVentasGeneral = from v in Esquema.VClienteSolicitudGeneralConsolidado where v.AñoSolicitud == Utilitarios.Utilitarios.Año && v.IdMes==Utilitarios.Utilitarios.Mes select v;
                        //        this.reportViewerReporte.ProcessingMode = ProcessingMode.Local;
                        //        this.reportViewerReporte.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptInformeVentaGeneral.rdlc";
                        //        this.reportViewerReporte.LocalReport.DataSources.Clear();
                        //        this.reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetVentasGeneral", objRptVentasGeneral));
                        //        this.reportViewerReporte.LocalReport.SetParameters(Usuario);
                        //        this.reportViewerReporte.LocalReport.Refresh();
                        //    }
     
                        //}
                        break;
                    case 2:
                        this.reportViewerReporte.ProcessingMode = ProcessingMode.Remote;
                        this.reportViewerReporte.ServerReport.ReportServerUrl = new Uri("http://viviana-murguia:90/ReportServer");
                        this.reportViewerReporte.ServerReport.ReportPath = "/Proyecto.Informe/RptDemandaServicio";
                        this.reportViewerReporte.Refresh();
                        //if (Utilitarios.Utilitarios.EventoInfo == 1)
                        //{
                        //    var objRptTurnoEstadoPlan = from v in Esquema.VHorarioServicioEstadoPlan select v;
                        //    this.reportViewerReporte.ProcessingMode = ProcessingMode.Local;
                        //    this.reportViewerReporte.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptInformeDemandaServicio.rdlc";
                        //    this.reportViewerReporte.LocalReport.DataSources.Clear();
                        //    this.reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetHorarioServicioEstadoPlan", objRptTurnoEstadoPlan));
                        //    this.reportViewerReporte.LocalReport.SetParameters(Usuario);
                        //    this.reportViewerReporte.LocalReport.Refresh();
                        //}
                        //else
                        //{
                        //    var objRptTurnoEstadoPlan = from v in Esquema.VHorarioServicioEstadoPlan where v.EstadoPlan.Equals(Utilitarios.Utilitarios.EstadoPlan) select v;
                        //    this.reportViewerReporte.ProcessingMode = ProcessingMode.Local;
                        //    this.reportViewerReporte.LocalReport.ReportEmbeddedResource = "Proyecto.Presentacion.Formulario.Reportes.RptInformeDemandaServicio.rdlc";
                        //    this.reportViewerReporte.LocalReport.DataSources.Clear();
                        //    this.reportViewerReporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetHorarioServicioEstadoPlan", objRptTurnoEstadoPlan));
                        //    this.reportViewerReporte.LocalReport.SetParameters(Usuario);
                        //    this.reportViewerReporte.LocalReport.Refresh();
                        //}
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

        private void btnCargarInfoDemandaServicio_Click(object sender, EventArgs e)
        {
            if (cbEstadoPlan.Text == "Todos")
            {
                Utilitarios.Utilitarios.EventoInfo = 1;
            }
            else
            { Utilitarios.Utilitarios.EventoInfo = 2; }

            Utilitarios.Utilitarios.EstadoPlan = cbEstadoPlan.Text;
            MostrarInforme(Utilitarios.Utilitarios.nroReporte);
            reportViewerReporte.RefreshReport();
        }

        private void btnCargarInfoVentaGeneral_Click(object sender, EventArgs e)
        {
            if (cbVentaAño.Text == "-Seleccionar-")
            {
                Utilitarios.Utilitarios.EventoInfo = 1;
            }
            else
            {
                Utilitarios.Utilitarios.EventoInfo = 2;
                Utilitarios.Utilitarios.Año = Int64.Parse(cbVentaAño.Text);
                Utilitarios.Utilitarios.Mes = Int64.Parse(cbVentaMes.SelectedValue.ToString());
            }

            MostrarInforme(Utilitarios.Utilitarios.nroReporte);
            reportViewerReporte.RefreshReport();
        }
    }
}
