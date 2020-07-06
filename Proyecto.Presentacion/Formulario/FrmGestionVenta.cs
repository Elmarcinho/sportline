using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Datos;
using Proyecto.Negocio;
using Proyecto.Negocio.RNLista;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmGestionVenta : Form
    {
        CtrlSolicitud objCtrlSolicitud = new CtrlSolicitud();
        CtrlBitacora objCtrlBitacora = new CtrlBitacora();
        RNValidar objRNValidar = new RNValidar();
        public FrmGestionVenta()
        {
            InitializeComponent();
        }
        private void FrmListaVenta_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length/2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 5
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnVentaProducto.Enabled = true;
                        btnVentaServicio.Enabled = true;
                        
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 6
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        CancelarVentaToolStripMenuItem.Enabled = true;
                       
                    }
                }
            }
        }
        private void btnVentaProducto_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
            Utilitarios.Utilitarios.TipoSolicitud =1;
            if (Application.OpenForms["FrmVentaProducto"] != null)
            {
                Application.OpenForms["FrmVentaProducto"].BringToFront();
                return;
            }
            FrmVentaProducto FVentaProducto = new FrmVentaProducto();
            FVentaProducto.Show();
            FVentaProducto.txtCedulaNit.Focus();
            FVentaProducto.FormClosed += new FormClosedEventHandler(form2_FormClosed);

        }
        private void btnVentaServicio_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
            Utilitarios.Utilitarios.TipoSolicitud = 2;
            if (Application.OpenForms["FrmVentaServicio"] != null)
            {
                Application.OpenForms["FrmVentaServicio"].BringToFront();
                return;
            }
            FrmVentaServicio FVentaServicio = new FrmVentaServicio();
            FVentaServicio.Show();
            FVentaServicio.txtCedulaNit.Focus();
            FVentaServicio.FormClosed += new FormClosedEventHandler(form2_FormClosed);

        }
        private void ModificarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;
                if (Application.OpenForms["FrmVentaProducto"] != null)
                {
                    Application.OpenForms["FrmVentaProducto"].BringToFront();
                    return;
                }
                FrmVentaProducto FVenta = new FrmVentaProducto();
                FVenta.Show();
                FVenta.txtIdpedido.Text = dgvVenta.CurrentRow.Cells["IdVenta"].Value.ToString();
                Utilitarios.Utilitarios.IdCliente = long.Parse(dgvVenta.CurrentRow.Cells["IdCliente"].Value.ToString());
                FVenta.txtNombreCliente.Text = dgvVenta.CurrentRow.Cells[2].Value.ToString();
                FVenta.txtCedulaNit.Text = dgvVenta.CurrentRow.Cells[3].Value.ToString();
                FVenta.dtpFechaVenta.Text = dgvVenta.CurrentRow.Cells["FechaSol"].Value.ToString();
                FVenta.txtMontoTotal.Text = dgvVenta.CurrentRow.Cells["Monto"].Value.ToString();
                FVenta.txtCedulaNit.ReadOnly = true;
                FVenta.btnBuscarCliente.Enabled = false;
                FVenta.btnNuevoCliente.Enabled = false;
                FVenta.dtpFechaVenta.Enabled = false;
                FVenta.cbFormaPago.DropDownStyle = ComboBoxStyle.DropDown;
                FVenta.cbFormaPago.Text = "Al " + dgvVenta.CurrentRow.Cells[8].Value.ToString();
                FVenta.cbFormaPago.Enabled = false;
                FVenta.groupBox6.Visible = false;
                RNSolicitud objSolicitudCliente = new RNSolicitud();
                var ObjDetalleSolicitud = objSolicitudCliente.TraerDetalleSolicitudCliente(Convert.ToInt64(dgvVenta.CurrentRow.Cells["IdVenta"].Value));
                foreach (var item in ObjDetalleSolicitud)
                {

                    FVenta.dgvDetallePedidoProducto.Rows.Add(item.IdProducto, item.NombreProducto, item.DescripcionProducto, item.IdPrecio, item.PrecioVenta,item.Stock, item.Cantidad, item.Total);
                    
                }
                FVenta.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CancelarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 1;

            Solicitud objSolicitud = new Solicitud();
            objSolicitud.IdSolicitud = long.Parse(dgvVenta.CurrentRow.Cells["IdVenta"].Value.ToString());
            objSolicitud.EstadoSolicitud = 2;
            if (MessageBox.Show("Esta seguro de Anular Solicitud?", "Sistema de Ventas",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (objCtrlSolicitud.CancelarSolicitud(objSolicitud))
                {
                    BitacoraSolicitudVenta objBitacoraSolicitud = new BitacoraSolicitudVenta();
                    objBitacoraSolicitud.NombreOperacion = "Anulación de Solicitud";
                    objBitacoraSolicitud.FechaOperacion = DateTime.Now;
                    objBitacoraSolicitud.IdSolicitud = objSolicitud.IdSolicitud;
                    objBitacoraSolicitud.NombreUsuario = Utilitarios.Utilitarios.NombreUsuarioSession;
                    objCtrlBitacora.InsertarBitacoraSolicitud(objBitacoraSolicitud);
                    MessageBox.Show("Solicitud Anulada con éxito!","Sistema de Ventas");
                    CargarGrillaVenta();
                }
                else
                {
                    MessageBox.Show("Error en la Anulacion de la Solicitud","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void btnCerrarListaVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaVenta()
        {
            RNSolicitud objSolicitudCliente = new RNSolicitud();
            if (CheckHabilitarFecha.Checked == true)
            {
                //dgvVenta.AutoGenerateColumns = false;
                dgvVenta.DataSource = objSolicitudCliente.TraerSolicitudClientePorFecha(Convert.ToDateTime(dtpFechaVenta.Text));
            }
            else
            {
                if (txbBuscarVenta.Text.Trim() != string.Empty)
                {
                    //dgvVenta.AutoGenerateColumns = false;
                    dgvVenta.DataSource = objSolicitudCliente.TraerSolicitudClientePorCedula(long.Parse(txbBuscarVenta.Text));
                }
                else { MessageBox.Show("Ingrese Cédula Identidad del Cliente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvVenta.Visible == true && dgvVenta.RowCount > 0)
            {
                this.CargarGrillaVenta();
            }
            if (Application.OpenForms["FrmListaCliente"] != null)
            {
                Application.OpenForms["FrmListaCliente"].Close(); 
            }
            if (Application.OpenForms["FrmListaProducto"] != null)
            {
                Application.OpenForms["FrmListaProducto"].Close();
            }
            if (Application.OpenForms["FrmRptFactura"] != null)
            {
                Application.OpenForms["FrmRptFactura"].Close();
            }
            if (Application.OpenForms["FrmCliente"] != null)
            {
                Application.OpenForms["FrmCliente"].Close();
            }
        }
        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVenta.Rows.Count > 0)
            {
                dgvVenta.Rows[dgvVenta.CurrentRow.Index].Selected = true;
            }
        }

        private void dgvVenta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuVenta.Show(Cursor.Position.X, Cursor.Position.Y);

                if ((Convert.ToDateTime(dgvVenta.CurrentRow.Cells["FechaSol"].Value).ToString("dd/MM/yyyy") != DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    ModificarVentaToolStripMenuItem.Enabled = false;
                    CancelarVentaToolStripMenuItem.Enabled = false;
                }
                else if ((Convert.ToDateTime(dgvVenta.CurrentRow.Cells["FechaSol"].Value).ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy")) && (dgvVenta.CurrentRow.Cells["EstadoSolicitud"].Value.ToString() == "Entregado"))
                {
                    ModificarVentaToolStripMenuItem.Enabled = false;
                    CancelarVentaToolStripMenuItem.Enabled = true;
                }
                else if ((Convert.ToDateTime(dgvVenta.CurrentRow.Cells["FechaSol"].Value).ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy")) && (dgvVenta.CurrentRow.Cells["EstadoSolicitud"].Value.ToString() == "Anulado"))
                {
                    ModificarVentaToolStripMenuItem.Enabled = false;
                    CancelarVentaToolStripMenuItem.Enabled = false;
                }
                else if ((Convert.ToDateTime(dgvVenta.CurrentRow.Cells["FechaSol"].Value).ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy")) && (dgvVenta.CurrentRow.Cells["EstadoSolicitud"].Value.ToString() == "Pendiente"))
                {
                    ModificarVentaToolStripMenuItem.Enabled = true;
                    CancelarVentaToolStripMenuItem.Enabled = true;
                }

            }

        }
        private void dgvVenta_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvVenta.CurrentCell = dgvVenta.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvVenta.Rows[e.RowIndex].Selected = true;
                    dgvVenta.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void CheckHabilitarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckHabilitarFecha.Checked == true)
            {
                dtpFechaVenta.Enabled = true;
                txbBuscarVenta.Clear();
                txbBuscarVenta.Enabled = false;
            }
            else
            {
                dtpFechaVenta.Enabled = false;
                txbBuscarVenta.Enabled = true;
            }
        }

        private void btnBuscarSolicitud_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Visible == false)
            {
                dgvVenta.Visible = true;
            }
            CargarGrillaVenta();
        }

        private void txbBuscarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarSolicitud.PerformClick();
            }
            else
            {
                objRNValidar.Numeros(e);
            }
        }

        private void dgvVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVenta.Columns[e.ColumnIndex].Name == "EstadoSolicitud")
            {
                try
                {
                    if (e.Value.ToString()=="Pendiente")
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (e.Value.ToString() == "Anulado")
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void DetalleVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.nroReporte = 8;
            Utilitarios.Utilitarios.IdSolicitud = long.Parse(dgvVenta.CurrentRow.Cells["IdVenta"].Value.ToString());
            FrmReporte FReporte = new FrmReporte();
            FReporte.Show();
        }
    }
}
