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
using Proyecto.Negocio.RNLista;


namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmPagoServicio : Form
    {
        RNPago objRNPago = new RNPago();
        RNPrecio objRNPrecio = new RNPrecio();
        RNServicio objRNServicio = new RNServicio();
        RNValidar objRNValidar = new RNValidar();
        public FrmPagoServicio()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.EventoVer = 2;
            if (Application.OpenForms["FrmListaCliente"] != null)
            {
                Application.OpenForms["FrmListaCliente"].BringToFront();
                return;
            }
            FrmListaCliente FListaCliente = new FrmListaCliente();
            FListaCliente.Show();
            FListaCliente.txbBuscarCliente.Focus();
            FListaCliente.FormClosed += new FormClosedEventHandler(frmListaCliente_FormClosed);
        }
        private void btnPagarServicio_Click(object sender, EventArgs e)
        {
            if (dgvPagoServicio.RowCount > 0)
            {
                if (dgvPagoServicio.Rows[dgvPagoServicio.CurrentRow.Index].Selected == true)
                {
                    if (dgvClienteServicio.Rows[dgvClienteServicio.CurrentRow.Index].Selected == true)
                    {
                        if (Application.OpenForms["FrmPago"] != null)
                        {
                            Application.OpenForms["FrmPago"].BringToFront();
                            return;
                        }
                        FrmPago FPago = new FrmPago();
                        FPago.Show();
                        FPago.lbNombreCliente.Text = dgvPagoServicio.CurrentRow.Cells["NombreCliente"].Value.ToString();
                        FPago.lbCedula.Text = dgvPagoServicio.CurrentRow.Cells["Cedula"].Value.ToString();
                        FPago.lbPlan.Text = dgvPagoServicio.CurrentRow.Cells["NombrePlan"].Value.ToString();
                        if (FPago.lbPlan.Text == "Diario")
                        {
                            FPago.cbFormaPago.SelectedValue = 1;
                            FPago.cbDescuento.SelectedIndex = 0;
                            FPago.cbFormaPago.Enabled = false;
                            FPago.cbDescuento.Enabled = false;
                        }
                        Utilitarios.Utilitarios.IdSolicitud = long.Parse(dgvPagoServicio.CurrentRow.Cells["CodSolicitud"].Value.ToString());
                        Utilitarios.Utilitarios.IdPrecio = long.Parse(dgvClienteServicio.CurrentRow.Cells["IdPrecio"].Value.ToString());
                        FPago.lbDisciplina.Text = dgvClienteServicio.CurrentRow.Cells["NombreServicio"].Value.ToString();
                        Utilitarios.Utilitarios.PrecioServicio = Convert.ToDouble(dgvClienteServicio.CurrentRow.Cells["PrecioServicio"].Value.ToString());
                        FPago.txtSubTotal.Text = Utilitarios.Utilitarios.PrecioServicio.ToString();
                        FPago.txtMontoTotal.Text = (Convert.ToDecimal(FPago.txtSubTotal.Text) - Convert.ToDecimal(FPago.txtDescuento.Text)).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione el Servicio a Pagar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una Solicitud a Pagar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un Cliente para realizar el pago.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void frmListaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CargarGrillaClientePago();
        }

        private void txtCedulaNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.CargarGrillaClientePago();
       
            }
            else { objRNValidar.Numeros(e); }
        }
        private void CargarGrillaClientePago()
        {
            long id = 0;

            if (txtCedulaNit.Text.Trim() == "" || txtCedulaNit.Text.Trim() == "0")
            {
                txtNombreCliente.Clear();
                txtCedulaNit.Clear();
            }
            else if (long.TryParse(this.txtCedulaNit.Text, out id))
            {
                var ListaServicio = objRNServicio.TraerClientePagoPorCedula(long.Parse(txtCedulaNit.Text));
                if (ListaServicio.LongCount() != 0)
                {
                    foreach (var item in ListaServicio)
                    {
                        Utilitarios.Utilitarios.IdCliente = item.Código;
                        txtNombreCliente.Text = item.NombreCliente;
                    }
                    txtCedulaNit.ReadOnly = true;
                    dgvPagoServicio.AutoGenerateColumns = false;
                    dgvPagoServicio.DataSource = ListaServicio;
                    dgvClienteServicio.DataSource = null;
                }
                else
                {
                    txtNombreCliente.Clear();
                    dgvPagoServicio.DataSource = null;
                    dgvClienteServicio.DataSource = null;
                }
            }
        }
        private void CargarGrillaClienteServicio()
        {
            dgvClienteServicio.AutoGenerateColumns = false;
            dgvClienteServicio.DataSource = objRNServicio.TraerClienteServicio(long.Parse(dgvPagoServicio.CurrentRow.Cells["CodSolicitud"].Value.ToString()));
        }

        private void dgvPagoServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagoServicio.Rows.Count > 0 && e.RowIndex > -1)
            {
                dgvPagoServicio.Rows[dgvPagoServicio.CurrentRow.Index].Selected = true;

                this.CargarGrillaClienteServicio();
            }
        }

        private void verPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPagoServicio.SelectedRows.Count > 0)
            {
                if (Application.OpenForms["FrmListaPago"] != null)
                {
                    Application.OpenForms["FrmListaPago"].BringToFront();
                    return;
                }
                FrmListaPago FListaPago = new FrmListaPago();
                FListaPago.dgvPago.AutoGenerateColumns = false;
                FListaPago.dgvPago.DataSource = objRNPago.TraerClientePago(long.Parse(dgvPagoServicio.CurrentRow.Cells["CodSolicitud"].Value.ToString()));
                FListaPago.Show();
                FListaPago.lbNombreCliente.Text = dgvPagoServicio.CurrentRow.Cells["NombreCliente"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvPagoServicio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuPago.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void dgvPagoServicio_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvPagoServicio.CurrentCell = dgvPagoServicio.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvPagoServicio.Rows[e.RowIndex].Selected = true;
                    dgvPagoServicio.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvClienteServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClienteServicio.Rows.Count > 0 && e.RowIndex > -1)
            {
                dgvClienteServicio.Rows[dgvClienteServicio.CurrentRow.Index].Selected = true;
            }
        }
    }
}
