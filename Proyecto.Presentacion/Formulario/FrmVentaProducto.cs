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
using System.Globalization;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmVentaProducto : Form
    {
        CtrlSolicitud objCtrlSolicitud = new CtrlSolicitud();
        CtrlCredito objCtrlCredito = new CtrlCredito();
        CtrlCuota objCtrlCuota = new CtrlCuota();
        CtrlFactura objCtrlFactura = new CtrlFactura();
        CtrlBitacora objCtrlBitacora = new CtrlBitacora();
        RNValidar objRNValidar = new RNValidar();
        RNCliente objRNCliente = new RNCliente();
        private FrmListaCliente form = null;
        private FrmListaProducto frmPro = null;
        private FrmCliente frmCli = null;

        public FrmVentaProducto()
        {
            InitializeComponent();
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.CargarComboFomaPago();
            this.CargarIdPedido();
        }
        private void CargarIdPedido()
        {
            Solicitud objSolicitud = new Solicitud();
            objSolicitud.IdSolicitud= objCtrlSolicitud.GenerarID();
            txtIdpedido.Text = (objSolicitud.IdSolicitud).ToString();
        }
        private void CargarComboFomaPago()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdFormaPago");
            dt.Columns.Add("NombreFormaPago");
            dt.AcceptChanges();

            DataRow dr0 = dt.NewRow();
            dr0[0] = "0";
            dr0[1] = "--- Seleccionar ---";

            DataRow dr1 = dt.NewRow();
            dr1[0] = "1";
            dr1[1] = "Al Contado";

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Al Crédito";

            dt.Rows.Add(dr0);
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.AcceptChanges();

            this.cbFormaPago.DisplayMember = "NombreFormaPago";
            this.cbFormaPago.ValueMember = "IdFormaPago";
            this.cbFormaPago.DataSource = dt;
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.EventoVer = 0;
            FrmListaCliente frm = FormInstanceListaCliente;
            frm.Show();
            frm.txbBuscarCliente.Focus();
            frm.FormClosed += new FormClosedEventHandler(frmListaCliente_FormClosed);
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
            FrmCliente FCli = FormInstanceCliente;
            FCli.lbRegistroCliente.Visible = true;
            FCli.Show();
            FCli.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.EventoVer = 0;
            FrmListaProducto frm = FormInstance;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(frmListaProducto_FormClosed);
        }
        private void btnGuardarPedidoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    if ((txtCedulaNit.Text != string.Empty || txtCedulaNit.Text != "") && (txtNombreCliente.Text != string.Empty))
                    {
                        if (Convert.ToInt32(dgvDetallePedidoProducto.Rows.Count) != 0)
                        {
                            if (Convert.ToInt64(cbFormaPago.SelectedValue) != 0)
                            {
                                RNSolicitud objAuxSolicitud = new RNSolicitud();
                                if (CargarObjetoSolicitud(ref objAuxSolicitud))
                                {
                                    if (objCtrlSolicitud.InsertarSolicitudCliente(objAuxSolicitud))
                                    {
                                        if (Convert.ToInt64(cbFormaPago.SelectedValue) == 1)
                                        {
                                            BitacoraSolicitudVenta objBitacoraSolicitud = new BitacoraSolicitudVenta();
                                            objBitacoraSolicitud.NombreOperacion = "Registro de Solicitud de Producto";
                                            objBitacoraSolicitud.FechaOperacion = DateTime.Now;
                                            objBitacoraSolicitud.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                            objBitacoraSolicitud.NombreUsuario = Utilitarios.Utilitarios.NombreUsuarioSession;
                                            objCtrlBitacora.InsertarBitacoraSolicitud(objBitacoraSolicitud);

                                            MessageBox.Show("Pedido registrado con éxito!","Sistema de Ventas");
                                            btnGenerarFactura.Enabled = true;
                                            txtCedulaNit.ReadOnly = true;
                                            btnBuscarCliente.Enabled = false;
                                            btnNuevoCliente.Enabled = false;
                                            dtpFechaVenta.Enabled = false;
                                            btnBuscarProducto.Enabled = false;
                                            cbFormaPago.Enabled = false;
                                            dgvDetallePedidoProducto.Enabled = false;
                                            btnGuardarPedidoProducto.Enabled = false;
                                            txtEfectivo.ReadOnly = true;
                                            txtEfectivo.BackColor = DefaultBackColor;
                                        }
                                        else
                                        {
                                            Credito objCredito = new Credito();
                                            objCredito.IdCredito = objCtrlCredito.GenerarID();
                                            objCredito.FechaCredito = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                            objCredito.FechaPlazo = DateTime.Parse(this.dtpFechaPlazo.Text);
                                            objCredito.Monto = Convert.ToDouble(txtMontoTotal.Text);
                                            objCredito.IdSolicitud = long.Parse(txtIdpedido.Text);
                                            objCtrlCredito.InsertarCredito(objCredito);
                                            if (txtCuotaInicial.Text != string.Empty)
                                            {
                                                Cuota objCuota = new Cuota();
                                                objCuota.IdCuota = objCtrlCuota.GenerarID();
                                                objCuota.FechaPago = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                                objCuota.MontoCuota = Convert.ToDouble(txtCuotaInicial.Text);
                                                objCuota.IdCredito = objCredito.IdCredito;
                                                objCtrlCuota.InsertarCuota(objCuota);
                                            }

                                            BitacoraSolicitudVenta objBitacoraSolicitud = new BitacoraSolicitudVenta();
                                            objBitacoraSolicitud.NombreOperacion = "Registro de Solicitud de Producto";
                                            objBitacoraSolicitud.FechaOperacion = DateTime.Now;
                                            objBitacoraSolicitud.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                            objBitacoraSolicitud.NombreUsuario = Utilitarios.Utilitarios.NombreUsuarioSession;
                                            objCtrlBitacora.InsertarBitacoraSolicitud(objBitacoraSolicitud);

                                            MessageBox.Show("Pedido registrado con éxito!","Sistema de Ventas");
                                            txtCedulaNit.ReadOnly = true;
                                            btnBuscarCliente.Enabled = false;
                                            btnNuevoCliente.Enabled = false;
                                            dtpFechaVenta.Enabled = false;
                                            btnBuscarProducto.Enabled = false;
                                            cbFormaPago.Enabled = false;
                                            dgvDetallePedidoProducto.Enabled = false;
                                            txtCuotaInicial.Enabled = false;
                                            dtpFechaPlazo.Enabled = false;
                                            btnGuardarPedidoProducto.Enabled = false;
                                            btnGenerarFactura.Enabled = false;
                                            this.Close();
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error en el registro de Solicitud.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                pictBoxVentaPro3.Visible = true;
                                MessageBox.Show("Favor seleccionar forma de pago.", "Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor seleccione al menos un Producto para realizar la solicitud.", "Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un Cliente para realizar la solicitud.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    RNSolicitud objAuxSolicitud = new RNSolicitud();
                    if (this.CargarObjetoSolicitud(ref objAuxSolicitud))
                    {
                        if (objCtrlSolicitud.EliminarDetalleSolicitud(objAuxSolicitud.IdSolicitud))
                        {
                            if (objCtrlSolicitud.ModificarSolicitudCliente(objAuxSolicitud))
                            {
                                MessageBox.Show("Pedido Actualizado con éxito!","Sistema de Ventas");
                                btnGuardarPedidoProducto.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error en la actualizacion del pedido.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los datos de registro de pedido.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private bool CargarObjetoSolicitud(ref RNSolicitud objRNSolicitud)
        {
            try
            {
                int contar = 0;
                objRNSolicitud.IdSolicitud = long.Parse(txtIdpedido.Text);
                objRNSolicitud.FechaSolicitud =dtpFechaVenta.Value;
                objRNSolicitud.EstadoSolicitud = Convert.ToInt32(Utilitarios.Utilitarios.EstadoSolicitud);
                objRNSolicitud.IdCliente = Utilitarios.Utilitarios.IdCliente;
                objRNSolicitud.IdTipoSolicitud = Utilitarios.Utilitarios.TipoSolicitud;
                objRNSolicitud.IdTipoPago= int.Parse(cbFormaPago.SelectedValue.ToString());
                objRNSolicitud.IdPlazo = 0;
                objRNSolicitud.IdDescuento = 0;
                objRNSolicitud.IdUsuario = Utilitarios.Utilitarios.IdUsuario;

                for (int i = 0; i <= this.dgvDetallePedidoProducto.Rows.Count - 1; i++)
                {
                    DetalleSolicitud objdetalle = new DetalleSolicitud();
                    objdetalle.IdSolicitud = objRNSolicitud.IdSolicitud;
                    objdetalle.IdPrecio = long.Parse(this.dgvDetallePedidoProducto.Rows[i].Cells["IdPrecio"].Value.ToString());
                    if (dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value != null)
                    {
                        if (dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value.ToString() != "" && dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value.ToString() != string.Empty)
                        {
                            if (dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value.ToString() != "0")
                            {

                                objdetalle.Cantidad = int.Parse(this.dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value.ToString());
                                objCtrlSolicitud.InsertarListaDetalle(objdetalle);

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
                    DetalleSolicitud objdetalle = new DetalleSolicitud();
                    objCtrlSolicitud.LimpiarListaDetalle(objdetalle);
                    MessageBox.Show("Por favor verifique que la columna cantidad No contenga: \n -Campos vacios\n -Campos con cero'0'","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos de la solicitud.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        public void ActualizarTotalesGrilla()
        {
            try
            {
                Decimal ac = 0;
                Decimal Total;
                for (int i = 0; i <= this.dgvDetallePedidoProducto.Rows.Count - 1; i++)
                {
                    long cantidad = long.Parse(dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value.ToString());
                    long stock = long.Parse(dgvDetallePedidoProducto.Rows[i].Cells["Stock"].Value.ToString());
                    Decimal Precio = Decimal.Parse(dgvDetallePedidoProducto.Rows[i].Cells["Precio"].Value.ToString());

                    if (cantidad <= stock)
                    {
                        Total = Precio * cantidad;
                        dgvDetallePedidoProducto.Rows[i].Cells["Total"].Value = Total;
                        ac = ac + Total;
                    }
                    else
                    {
                        MessageBox.Show("Stock insuficiente, por favor ingrese una cantidad menor","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value = 0;
                        break;
                    }
                }

                txtMontoTotal.Text = ac.ToString().Replace(".", ",");
                txtMontoCredito.Text = txtMontoTotal.Text;

            }
            catch (Exception) { MessageBox.Show("Error en actualizar los datos Grilla de Solicitud","Sistemas de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (btnGuardarPedidoProducto.Enabled == false)
            {
                Factura objFactura = new Factura();
                if (CargarObjetoFactura(objFactura))
                {
                    if (objCtrlFactura.InsertarFactura(objFactura))
                    {
                        btnGenerarFactura.Enabled = false;
                        Utilitarios.Utilitarios.IdSolicitud = Int64.Parse(txtIdpedido.Text);
                        Utilitarios.Utilitarios.nroReporte = 1;
                        if (Application.OpenForms["FrmRptFactura"] != null)
                        {
                            Application.OpenForms["FrmRptFactura"].BringToFront();
                            return;
                        }
                        FrmRptFactura objRptFactura = new FrmRptFactura();
                        objRptFactura.Show();
                    }
                }
            }
        }
        private bool CargarObjetoFactura(Factura objFactura)
        {
            try
            {
                if (objCtrlFactura.GenerarID(Utilitarios.Utilitarios.RangoInicial, Utilitarios.Utilitarios.RangoFinal) != 0)
                {
                    objFactura.IdFactura = objCtrlFactura.GenerarID(Utilitarios.Utilitarios.RangoInicial, Utilitarios.Utilitarios.RangoFinal);
                }
                else
                {
                    MessageBox.Show("No se puede Generar Factura, favor solicite nueva Dosificación para generar factura","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
                objFactura.CodigoAutorizacion = Convert.ToInt64(Utilitarios.Utilitarios.CodigoAutorizacion);
                objFactura.FechaFactura = Convert.ToDateTime(DateTime.Now.ToString());
                string FechaFactura = objFactura.FechaFactura.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                objFactura.CodigoControl = Utilitarios.Crypto.CodigoDeControl.generateControlCode(Utilitarios.Utilitarios.CodigoAutorizacion, Convert.ToString(objFactura.IdFactura), txtCedulaNit.Text, (FechaFactura).Replace("/", ""), txtMontoTotal.Text, Utilitarios.Utilitarios.LlaveDosificacion);
                objFactura.FechaLimiteEmision = Utilitarios.Utilitarios.FechaLimiteEmision;
                //Generar CodigoQR
                string Cadena = Utilitarios.Utilitarios.Nit + "|" + Convert.ToString(objFactura.IdFactura) + "|" + Utilitarios.Utilitarios.CodigoAutorizacion + "|" + FechaFactura + "|" + txtMontoTotal.Text + "|" + txtMontoTotal.Text + "|" + objFactura.CodigoControl + "|" + txtCedulaNit.Text + "|" + "0.00" + "|" + "0.00";
                MessagingToolkit.QRCode.Codec.QRCodeEncoder Encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                Encoder.QRCodeScale = 8;
                Bitmap bmp = Encoder.Encode(Cadena);
                //convertimos a byte
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] imagen = ms.ToArray();
                //Fin Convert
                objFactura.CodigoQR = imagen;
                objFactura.Monto = Convert.ToDouble(txtMontoTotal.Text);
                objFactura.IdSolicitud = long.Parse(txtIdpedido.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos de la factura.","Sistemas de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPago.SelectedIndex == 1)
            {
                lbEfectivo.Visible = true;
                lbCambio.Visible = true;
                txtEfectivo.Visible = true;
                txtCambio.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                groupBox6.Visible = false;
                txtCuotaInicial.Clear();
                btnGuardarPedidoProducto.Focus();
            }
            else if (cbFormaPago.SelectedIndex == 2)
            {

                groupBox6.Visible = true;
                txtMontoCredito.Text = txtMontoTotal.Text;
                lbEfectivo.Visible = false;
                lbCambio.Visible = false;
                txtEfectivo.Visible = false;
                txtCambio.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                txtEfectivo.Clear();
                btnGuardarPedidoProducto.Focus();
            }
            else
            {
                groupBox6.Visible = false;
                txtMontoCredito.Clear();
                txtCuotaInicial.Clear();
                lbEfectivo.Visible = false;
                lbCambio.Visible = false;
                txtEfectivo.Visible = false;
                txtCambio.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                txtEfectivo.Clear();
            }

        }
        private void frmListaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (txtCedulaNit.Text == "0")
            {
                cbFormaPago.SelectedIndex = 1;
                cbFormaPago.Enabled = false;  
            }
            else
            {
                cbFormaPago.Enabled = true;
                cbFormaPago.SelectedIndex = 0;
            }
            txtCedulaNit.ReadOnly = true;
            btnBuscarProducto.Focus();
        }

        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCli.TerminarFuenteDeVideo();
        }
        private void frmListaProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnGuardarPedidoProducto.Focus();
        }
        private void form_Dispuesto(object sender, EventArgs e)
        {
            form = null;
            frmPro = null;
            frmCli = null;
        }
        private FrmListaCliente FormInstanceListaCliente
        {
            get
            {
                if (form == null)
                {
                    form = new FrmListaCliente();
                    form.Disposed += new EventHandler(form_Dispuesto);
                }
                else { form.BringToFront(); }
                return form;
            }
        }
        private FrmListaProducto FormInstance
        {
            get
            {
                if (frmPro == null)
                {
                    frmPro = new FrmListaProducto();
                    frmPro.Disposed += new EventHandler(form_Dispuesto);
                }
                else { frmPro.BringToFront(); }
                return frmPro;
            }
        }
        private void dgvDetallePedidoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvDetallePedidoProducto.CurrentCell.ColumnIndex == 6)
            {
                objRNValidar.Numeros(e);
            }
        }
        private void dgvDetallePedidoProducto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetallePedidoProducto.CurrentCell.ColumnIndex == 6)
            {
                try
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(dgvDetallePedidoProducto_KeyPress);
                        txt.KeyPress += new KeyPressEventHandler(dgvDetallePedidoProducto_KeyPress);
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
        }
        private void txtCuotaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e,txtCuotaInicial);
        }

        private void txtCuotaInicial_TextChanged(object sender, EventArgs e)
        {
            Decimal CuotaInicial = 0;
            Decimal.TryParse(txtCuotaInicial.Text, out CuotaInicial);

            Decimal MontoCredito = 0;
            Decimal.TryParse(txtMontoTotal.Text, out MontoCredito);

            txtMontoCredito.Text = (MontoCredito - CuotaInicial).ToString();
        }
        private FrmCliente FormInstanceCliente
        {
            get
            {
                if (frmCli == null)
                {
                    frmCli = new FrmCliente();
                    frmCli.Disposed += new EventHandler(form_Dispuesto);
                }
                else { frmCli.BringToFront(); }
                return frmCli;
            }
        }
        private void dgvDetallePedidoProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (~e.RowIndex > -1)
            {
                return;
            }
            else if (e.RowIndex>-1)
            {
                txtNombreProductoServicio.Text = dgvDetallePedidoProducto.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dgvDetallePedidoProducto.CurrentRow.Cells[2].Value.ToString();
                txtStock.Text = dgvDetallePedidoProducto.CurrentRow.Cells[5].Value.ToString();
            }
            else { return; }
        }
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (txtEfectivo.Text.Trim() == "" || txtEfectivo.Text.Trim() == " ")
            {
                txtCambio.Clear();
            }
            else
            {
                Decimal Efectivo = 0;
                Decimal.TryParse(txtEfectivo.Text, out Efectivo);

                Decimal MontoTotal = 0;
                Decimal.TryParse(txtMontoTotal.Text, out MontoTotal);

                txtCambio.Text = (Efectivo - MontoTotal).ToString();
            }
        }
        private void txtCedulaNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                long id = 0;

                if (txtCedulaNit.Text.Trim() == "" )
                {
                    txtNombreCliente.Clear();
                }
                else if (long.TryParse(this.txtCedulaNit.Text, out id))
                {
                    var Cliente = objRNCliente.TraerClienteGeneralPorCedula(long.Parse(txtCedulaNit.Text));
                    if (Cliente.LongCount() != 0)
                    {
                        foreach (var item in Cliente)
                        {
                            Utilitarios.Utilitarios.IdCliente = item.Código;
                            txtNombreCliente.Text = item.NombreCliente;
                        }
                        txtCedulaNit.ReadOnly = true;
                        btnBuscarProducto.Focus();
                    }
                    else { txtNombreCliente.Clear(); }
                }
                if (txtCedulaNit.Text == "0")
                {
                    cbFormaPago.SelectedIndex = 1;
                    cbFormaPago.Enabled = false;
                    btnBuscarProducto.Focus();
                }
            }
            else { objRNValidar.Numeros(e); }

        }
        public void dgvDetallePedidoProducto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex==6)
            {
                this.ActualizarTotalesGrilla();
            }
        }
        private void dgvDetallePedidoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetallePedidoProducto.Rows.Count>0)
            { 
                if (e.RowIndex>-1 && e.ColumnIndex==8)
                {
                    if (MessageBox.Show("Quitar Producto de la canasta?", "Sistema de Ventas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //dgvDetallePedidoProducto.Rows.RemoveAt(dgvDetallePedidoProducto.CurrentRow.Index); Igual sirve
                        dgvDetallePedidoProducto.Rows.RemoveAt(dgvDetallePedidoProducto.CurrentCell.RowIndex);
                        ActualizarTotalesGrilla();
                    }
                }
            }
        }
        private void dgvDetallePedidoProducto_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==8 && e.RowIndex > -1)
            {
                dgvDetallePedidoProducto.Cursor = Cursors.Hand;
            }
            else
            {
                dgvDetallePedidoProducto.Cursor = Cursors.Default;
            }
        }

        private void dgvDetallePedidoProducto_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetallePedidoProducto.Cursor = Cursors.Default;
        }

        private void groupBox3_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCedulaNit.Text))
                {
                    pictBoxVentaPro1.BackColor = Color.Red;
                    this.txtCedulaNit.BackColor = Color.LightYellow;
                    this.txtCedulaNit.Focus();
                    pictBoxVentaPro1.Visible = true;
                }
                else
                {
                    pictBoxVentaPro1.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Validated(object sender, EventArgs e)
        {
            try
            {
                if ( Convert.ToInt32(dgvDetallePedidoProducto.Rows.Count) == 0)
                {
                    pictBoxVentaPro2.BackColor = Color.Red;
                    pictBoxVentaPro2.Visible = true;
                }
                else
                {
                    pictBoxVentaPro2.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox7_Validated(object sender, EventArgs e)
        {
            try
            {
                if (cbFormaPago.Text.Equals("--- Seleccionar ---"))
                {
                    pictBoxVentaPro3.BackColor = Color.Red;
                    pictBoxVentaPro3.Visible = true;
                }
                else
                {
                    pictBoxVentaPro3.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
