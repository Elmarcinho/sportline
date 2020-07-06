using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocio;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmCargarCredito : Form
    {
        RNValidar objRNValidar = new RNValidar();
        public FrmCargarCredito()
        {
            InitializeComponent();
        }

        private void btnCargarRptCredito_Click(object sender, EventArgs e)
        {

            if (txtCedulaNit.Text != string.Empty)
            {
                Utilitarios.Utilitarios.CedulaIdendidad = Int64.Parse(txtCedulaNit.Text);
                Utilitarios.Utilitarios.nroReporte = 1;
                FrmReporte FReporte = new FrmReporte();
                FReporte.Show();
                this.Close();
            }
            else { MessageBox.Show("Por favor ingrese Cédula de Identidad del Cliente.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void txtCedulaNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCargarRptCredito.PerformClick();
            }
            else
            {
                objRNValidar.Numeros(e);
            }
        }
    }
}
