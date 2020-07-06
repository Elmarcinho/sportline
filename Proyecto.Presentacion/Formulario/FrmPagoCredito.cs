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
    public partial class FrmPagoCredito : Form
    {
        
        private FrmCredito frmCredito = null;
        public FrmPagoCredito()
        {
            InitializeComponent();
        }
        private void btnCredito_Click(object sender, EventArgs e)
        {
            FrmCredito FCredito = FormInstance;
            FCredito.Show();
            Utilitarios.Utilitarios.IdCredito = long.Parse(dgvCredito.CurrentRow.Cells["IdCredito"].Value.ToString());
            FCredito.lbNombreCliente.Text = dgvCredito.CurrentRow.Cells["NombreCliente"].Value.ToString();
            FCredito.txtSaldoActualCredito.Text = dgvCredito.CurrentRow.Cells["SaldoCredito"].Value.ToString();
            Utilitarios.Utilitarios.SaldoActualCredito = Convert.ToDouble(dgvCredito.CurrentRow.Cells["SaldoCredito"].Value);
            FCredito.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void CargarGrillaClienteCredito()
        {
            long id = 0;

            dgvCredito.AutoGenerateColumns = false;

            Negocio.RNLista.RNCredito objRNCredito = new Negocio.RNLista.RNCredito();

            if (long.TryParse(this.txbBuscarCliente.Text, out id))
            {
                this.dgvCredito.DataSource = objRNCredito.TraerClienteCreditoPorCedula(long.Parse(this.txbBuscarCliente.Text.Trim()));
              
            }
            else
            {
                this.dgvCredito.DataSource = objRNCredito.TraerClienteCreditoPorNombre(this.txbBuscarCliente.Text.Trim());
                
            }

            if (dgvCredito.Rows.Count > 0)
            {
                decimal Total = 0;

                for (int i = 0; i <= this.dgvCredito.Rows.Count - 1; i++)
                {

                    Total = Total + Convert.ToDecimal(dgvCredito.Rows[i].Cells["SaldoCredito"].Value);

                }
                lbCreditoTotal.Text = Total.ToString("N2");
            }
            else { lbCreditoTotal.Text = "0.00"; }
            btnCredito.Enabled = false;

        }
        public void txbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarGrillaClienteCredito();
            }
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CargarGrillaClienteCredito();
        }
        private FrmCredito FormInstance
        {
            get
            {
                if (frmCredito == null)
                {
                    frmCredito = new FrmCredito();
                    frmCredito.Disposed += new EventHandler(form_Dispuesto);
                }
                else { frmCredito.BringToFront(); }
                return frmCredito;
            }
        }
        private void form_Dispuesto(object sender, EventArgs e)
        {
            frmCredito = null;
        }

        private void dgvCredito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCredito.Rows.Count > 0 && e.RowIndex>-1)
            {
                dgvCredito.Rows[dgvCredito.CurrentRow.Index].Selected = true;

                btnCredito.Enabled = true;
            }
        }

        private void dgvCredito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCredito.Columns[e.ColumnIndex].Name == "FechaPlazo")
            {
                try
                {
                    if (Convert.ToDateTime(e.Value) == Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToDateTime(e.Value) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
    }
}
