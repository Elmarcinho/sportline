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

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmGestionReporte : Form
    {
        public FrmGestionReporte()
        {
            InitializeComponent();
        }
        private void FrmGestionReporte_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 25
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnReporteIngresoDiario.Enabled = true;
                        btnReporteVentas.Enabled = true;
                        btnReporteClienteDiario.Enabled = true;
                        btnReporteProducto.Enabled = true;
                        btnReporteCredito.Enabled = true;
                        btnReporteProductoDiario.Enabled = true;
                        btnReporteCumpleañeros.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 26
                      && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnInformeVentas.Enabled = true;
                        btnInformeTurnoEstadoPlan.Enabled = true;
                    }

                }
            }
        }
        private void btnCerrarListaCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformeVentas_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 1;
            FrmInforme FInforme = new FrmInforme();
            FInforme.Show();
            FInforme.groupBoxDemanda.Enabled = false;
        }
        private void btnInformeTurnoEstadoPlan_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 2;
            //Utilitarios.Utilitarios.EventoInfo = 1;
            FrmInforme FInforme = new FrmInforme();
            FInforme.Show();
            FInforme.groupBoxVenta.Enabled = false;
        }
        private void btnReporteCredito_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmCargarCredito"] != null)
            {
                Application.OpenForms["FrmCargarCredito"].BringToFront();
                return;
            }
            FrmCargarCredito FReporte = new FrmCargarCredito();
            FReporte.Show();
            FReporte.txtCedulaNit.Focus();
        }

        private void btnReporteProducto_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 6;
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 3;
            Utilitarios.Utilitarios.FechaInicio = Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy"));
            Utilitarios.Utilitarios.FechaFinal = Convert.ToDateTime(dtpFechaFin.Value.ToString("dd/MM/yyyy"));
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }

        private void btnReporteIngresoDiario_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 4;
            Utilitarios.Utilitarios.FechaInicio = Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy"));
            Utilitarios.Utilitarios.FechaFinal = Convert.ToDateTime(dtpFechaFin.Value.ToString("dd/MM/yyyy"));
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }

        private void btnReporteCumpleañeros_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 5;
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }

        private void btnReporteProductoDiario_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 2;
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }

        private void btnReporteClienteDiario_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 7;
            Utilitarios.Utilitarios.FechaInicio = Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy"));
            Utilitarios.Utilitarios.FechaFinal = Convert.ToDateTime(dtpFechaFin.Value.ToString("dd/MM/yyyy"));
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }
    }
}
