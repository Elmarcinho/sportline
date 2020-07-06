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
    public partial class FrmCompraProducto : Form
    {
        CtrlSolicitudCompra objCtrlSolicitudCompra = new CtrlSolicitudCompra();
        RNValidar objRNValidar = new RNValidar();
        public FrmCompraProducto()
        {
            InitializeComponent();
        }
        private void FrmCompraProducto_Load(object sender, EventArgs e)
        {
            CargarIdPedidoCompra();
        }
        private void CargarIdPedidoCompra()
        {
            SolicitudCompra objSolicitud = new SolicitudCompra();
            objSolicitud.IdSolicitudCompra = objCtrlSolicitudCompra.GenerarID();
            txtIdpedido.Text = (objSolicitud.IdSolicitudCompra).ToString();
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.EventoVer = 1;
            if (Application.OpenForms["FrmListaProducto"] != null)
            {
                Application.OpenForms["FrmListaProducto"].BringToFront();
                return;
            }
            FrmListaProducto FListaProducto = new FrmListaProducto();
            FListaProducto.Show();
            FListaProducto.FormClosed += new FormClosedEventHandler(frmListaProducto_FormClosed);
        }
        private void btnGuardarCompraProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    if (Convert.ToInt32(dgvDetalleCompraProducto.Rows.Count) != 0)
                    {
                        RNSolicitudCompra objAuxSolicitud = new RNSolicitudCompra();
                        if (CargarObjetoSolicitud(ref objAuxSolicitud))
                        {
                            if (objCtrlSolicitudCompra.InsertarSolicitudCompra(objAuxSolicitud))
                            {
                                MessageBox.Show("Pedido de compra registrado con éxito!", "Sistema de Ventas");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error en el registro de Solicitud de Compra.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione al menos un producto para realizar la solicitud.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CargarObjetoSolicitud(ref RNSolicitudCompra objRNSolicitud)
        {
            try
            {
                int contar = 0;
                objRNSolicitud.IdSolicitudCompra = long.Parse(txtIdpedido.Text);
                objRNSolicitud.FechaCompra = DateTime.Parse(this.dtpFechaCompra.Text);
                objRNSolicitud.IdUsuario = Utilitarios.Utilitarios.IdUsuario;

                for (int i = 0; i <= this.dgvDetalleCompraProducto.Rows.Count - 1; i++)
                {
                    DetalleSolicitudCompra objdetalle = new DetalleSolicitudCompra();
                    Precio objPrecio = new Precio();
                    objdetalle.IdSolicitudCompra = objRNSolicitud.IdSolicitudCompra;
                    objdetalle.IdPrecio = long.Parse(this.dgvDetalleCompraProducto.Rows[i].Cells["IdPrecio"].Value.ToString());
                    objPrecio.IdPrecio = long.Parse(this.dgvDetalleCompraProducto.Rows[i].Cells["IdPrecio"].Value.ToString());
                    if (dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value != null)
                    {
                        if (dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value.ToString() != "" && dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value.ToString() != string.Empty)
                        {
                            if (dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value.ToString() != "0")
                            {
                                objPrecio.PrecioCompra = float.Parse(this.dgvDetalleCompraProducto.Rows[i].Cells["Precio"].Value.ToString().Replace(".", ","));
                                objdetalle.Cantidad = int.Parse(this.dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value.ToString());
                                objCtrlSolicitudCompra.InsertarListaDetallePro(objdetalle);

                            }
                            else { contar = contar + 1; }
                        }
                        else { contar = contar + 1; }
                    }
                    else { contar = contar + 1; }
                }

                if (contar == 0)
                {
                    return true;
                }
                else
                {
                    DetalleSolicitudCompra objdetalle = new DetalleSolicitudCompra();
                    Precio objPrecio = new Precio();
                    objCtrlSolicitudCompra.LimpiarListaDetallePro(objdetalle);
                    MessageBox.Show("Por favor verifique que la columna Precio o cantidad No contenga: \n -Campos vacios\n -Campos con cero'0'", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos de la solicitud.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void frmListaProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnGuardarCompraProducto.Focus();
        }
        public void ActualizarTotalesGrillaCompra()
        {
            try
            {
                Decimal ac = 0;
                Decimal Total;
                for (int i = 0; i <= this.dgvDetalleCompraProducto.Rows.Count - 1; i++)
                {
                    if (dgvDetalleCompraProducto.Rows[i].Cells["Precio"].Value.ToString() != "")
                    {
                        long cantidad = long.Parse(dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value.ToString());
                        Decimal Precio = Decimal.Parse(dgvDetalleCompraProducto.Rows[i].Cells["Precio"].Value.ToString().Replace(".",","));

                        Total = Precio * cantidad;
                        dgvDetalleCompraProducto.Rows[i].Cells["Total"].Value = Total;
                        ac = ac + Total;
                    }
                }

                txtMontoTotal.Text = ac.ToString().Replace(".", ",");

            }
            catch (Exception)
            { MessageBox.Show("Error en actualizar los datos Grilla de Compra.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        public void dgvDetalleCompraProducto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 5)
            {
                this.ActualizarTotalesGrillaCompra();
            }
        }

        private void dgvDetalleCompraProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleCompraProducto.Rows.Count > 0)
            {
                if (e.RowIndex > -1 && e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Quitar Producto de la canasta?", "Sistema de Ventas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //dgvDetallePedidoProducto.Rows.RemoveAt(dgvDetallePedidoProducto.CurrentRow.Index); Igual sirve
                        dgvDetalleCompraProducto.Rows.RemoveAt(dgvDetalleCompraProducto.CurrentCell.RowIndex);
                        ActualizarTotalesGrillaCompra();
                    }
                }
            }
        }
        private void dgvDetalleCompraProducto_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                dgvDetalleCompraProducto.Cursor = Cursors.Hand;
            }
            else
            {
                dgvDetalleCompraProducto.Cursor = Cursors.Default;
            }
        }
        private void dgvDetalleCompraProducto_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalleCompraProducto.Cursor = Cursors.Default;
        }

        private void dgvDetalleCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (dgvDetalleCompraProducto.CurrentCell.ColumnIndex == 5)
            {
                objRNValidar.Numeros(e);
               
            }
           
        }
    
        private void dgvDetalleCompraProducto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetalleCompraProducto.CurrentCell.ColumnIndex == 5)
            {
                try
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(dgvDetalleCompraProducto_KeyPress);
                        txt.KeyPress += new KeyPressEventHandler(dgvDetalleCompraProducto_KeyPress);
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
        }
    }
}
