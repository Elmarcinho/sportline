using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmGestionPago : Form
    {
        
        public FrmGestionPago()
        {
            InitializeComponent();
        }
        private void FrmListaPagos_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 23
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnPagoCredito.Enabled = true;
                        btnPagoServicio.Enabled = true;
                        break;
                    }
                }
            }
        }
        private void btnPagoCredito_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmPagoCredito"] != null)
            {
                Application.OpenForms["FrmPagoCredito"].BringToFront();
                return;
            }
            FrmPagoCredito FCredito = new FrmPagoCredito();
            FCredito.Show();
            FCredito.txbBuscarCliente.Focus();
        }

        private void btnPagoServicio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmPagoServicio"] != null)
            {
                Application.OpenForms["FrmPagoServicio"].BringToFront();
                return;
            }
            FrmPagoServicio FPagoServicio = new FrmPagoServicio();
            FPagoServicio.Show();
            FPagoServicio.txtCedulaNit.Focus();
        }
        private void btnCerrarListaPagos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
