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
    public partial class FrmVentaServicio : Form
    {
        CtrlSolicitud objCtrlSolicitud = new CtrlSolicitud();
        CtrlPago objCtrPago = new CtrlPago();
        CtrlCredito objCtrlCredito = new CtrlCredito();
        CtrlFactura objCtrlFactura = new CtrlFactura();
        CtrlCuota objCtrlCuota = new CtrlCuota();
        CtrlHorario objCtrlHorario = new CtrlHorario();
        CtrlAsistencia objCtrlAsistencia = new CtrlAsistencia();
        CtrlBitacora objCtrlBitacora = new CtrlBitacora();
        RNCliente objRNCliente = new RNCliente();
        RNServicio objRNServicio = new RNServicio();
        RNValidar objRNValidar = new RNValidar();
        RNAsistencia objRNAsistencia = new RNAsistencia();
        private FrmListaCliente form = null;
        private FrmCliente frmCli = null;
        public FrmVentaServicio()
        {
            InitializeComponent();
        }
        private void FrmVentaServicio_Load(object sender, EventArgs e)
        {
            this.CargarIdPedido();
            this.CargarComboDescuento();
            this.CargarComboPlazo();
            this.CargarComboFomaPago();
            this.CargarComboTurno();
        }
        private void CargarIdPedido()
        {
            Solicitud objSolicitud = new Solicitud();
            objSolicitud.IdSolicitud = objCtrlSolicitud.GenerarID();
            txtIdpedido.Text = (objSolicitud.IdSolicitud).ToString();
        }
        private void CargarComboDescuento()
        {
            RNDescuento objDescuento = new RNDescuento();
            this.cbDescuento.DataSource = objDescuento.TraerDescuento(0);
            this.cbDescuento.DisplayMember = "NombreDescuento";
            this.cbDescuento.ValueMember = "IdDescuento";
        }
        private void CargarComboPlazo()
        {
            RNPlazo objPlazo = new RNPlazo();
            this.cbPlazo.DataSource = objPlazo.TraerPlazo(0);
            this.cbPlazo.DisplayMember = "NombrePlazo";
            this.cbPlazo.ValueMember = "IdPlazo";
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
        private void CargarComboTurno()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdTurno");
            dt.Columns.Add("NombreTurno");
            dt.AcceptChanges();

            DataRow dr1 = dt.NewRow();
            dr1[0] = "1";
            dr1[1] = "Mañana";

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Tarde";

            DataRow dr3 = dt.NewRow();
            dr3[0] = "3";
            dr3[1] = "Noche";

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.AcceptChanges();

            DataGridViewComboBoxColumn cbTurno= dgvDetallePedidoServicio.Columns["Turno"] as DataGridViewComboBoxColumn;
            cbTurno.DisplayMember = "NombreTurno";
            cbTurno.ValueMember = "Idturno";
            cbTurno.DataSource = dt;
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.EventoVer = 1;
            Utilitarios.Utilitarios.EventoClic = 0;
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
        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["FrmListaServicio"] != null)
            {
                Application.OpenForms["FrmListaServicio"].BringToFront();
                return;
            }
            FrmListaServicio FListaDisciplina = new FrmListaServicio();
            FListaDisciplina.Show();
            FListaDisciplina.FormClosed += new FormClosedEventHandler(frmListaServicio_FormClosed);
        }
        private void btnGuardarPedidoServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    if ((txtCedulaNit.Text != string.Empty || txtCedulaNit.Text != "") && (txtNombreCliente.Text != string.Empty))
                    {
                        if (Convert.ToInt32(cbFormaPago.SelectedValue) != 0)
                        {
                            if (Convert.ToInt32(dgvDetallePedidoServicio.Rows.Count) != 0)
                            {
                                RNSolicitud objAuxSolicitud = new RNSolicitud();
                                if (CargarObjetoSolicitud(ref objAuxSolicitud))
                                {
                                    if (objCtrlSolicitud.InsertarSolicitudCliente(objAuxSolicitud))
                                    {
                                        var ClienteAsistencia = objRNAsistencia.TraerClienteAsistenciaPorCedula(Convert.ToInt64(txtCedulaNit.Text));
                                        var ClienteAsistenciaMarcado = objRNAsistencia.TraerClienteAsistenciaPorCedulaVencido(Convert.ToInt64(txtCedulaNit.Text));
                                        int Dias1 = 0;
                                        int Dias2 = 0;
                                        Int64 IdAsistencia = 0;
                                        Nullable<DateTime> UltimaFecha = null;
                                        Nullable<DateTime> FechaReno = null;

                                        if (ClienteAsistenciaMarcado.LongCount() != 0)
                                        {
                                            foreach (var itemMarcado in ClienteAsistenciaMarcado)
                                            {
                                                Dias1 = Convert.ToInt32((DateTime.Now - itemMarcado.FechaAsistencia.Value).TotalDays);
                                                if (itemMarcado.FechaRenovacion != null)
                                                { Dias2 = Convert.ToInt32((DateTime.Now - itemMarcado.FechaRenovacion.Value).TotalDays); }
                                                UltimaFecha = itemMarcado.FechaAsistencia.Value;
                                                if (itemMarcado.FechaRenovacion != null)
                                                { FechaReno = itemMarcado.FechaRenovacion.Value; }
                                                IdAsistencia = itemMarcado.IdAsistencia;
                                                break;
                                            }
                                            if ((Dias1 >= 90 && FechaReno == null) || (Dias1 >= 90 && Dias2 >= 90))
                                            {
                                                if (ClienteAsistencia.LongCount() != 0)
                                                {
                                                    foreach (var item in ClienteAsistencia)
                                                    {
                                                        Asistencia objAsistencia = new Asistencia();
                                                        objAsistencia.IdAsistencia = item.IdAsistencia;
                                                        objAsistencia.FechaAsistencia = null;
                                                        objAsistencia.FechaRenovacion = null;
                                                        objAsistencia.Valor = 2;

                                                        objCtrlAsistencia.ModificarAsistencia(objAsistencia);
                                                    }
                                                }
                                                Asistencia objAsistencia2 = new Asistencia();
                                                objAsistencia2.IdAsistencia = IdAsistencia;
                                                objAsistencia2.FechaAsistencia = UltimaFecha;
                                                objAsistencia2.FechaRenovacion = DateTime.Now;
                                                objAsistencia2.Valor = 1;

                                                objCtrlAsistencia.ModificarAsistencia(objAsistencia2);
                                            }
                                        }
                                        if (Convert.ToInt64(cbFormaPago.SelectedValue) == 1)
                                        {
                                            int contar = 0;
                                            for (int i = 0; i <= this.dgvDetallePedidoServicio.Rows.Count - 1; i++)
                                            {
                                                Horario objHorario = new Horario();
                                                Pago objPago = new Pago();
                                                objPago.IdPago = objCtrPago.GenerarID();
                                                objHorario.IdHorario = objCtrlHorario.GenerarID();
                                                objPago.FechaPago = DateTime.Now;
                                                if (i == 0)
                                                {
                                                    objPago.Descuento = Convert.ToDouble(txtDescuento.Text);
                                                }
                                                else
                                                {
                                                    objPago.Descuento = 0;
                                                }
                                                objPago.Monto = Convert.ToDouble(dgvDetallePedidoServicio.Rows[i].Cells["Total"].Value.ToString()) - objPago.Descuento;
                                                objPago.Cantidad = int.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString());
                                                objPago.EstadoPago = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPago);
                                                objPago.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                objPago.IdPrecio = long.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["IdPrecio"].Value.ToString());
                                                objHorario.HoraInicio = TimeSpan.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["HoraInicio"].Value.ToString());
                                                objHorario.HoraFin = TimeSpan.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["HoraFin"].Value.ToString());
                                                objHorario.RangoDia = this.dgvDetallePedidoServicio.Rows[i].Cells["RangoDias"].Value.ToString();
                                                objHorario.IdServicio = long.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["IdServicio"].Value.ToString());
                                                objHorario.IdCliente = Utilitarios.Utilitarios.IdCliente;
                                                objHorario.IdSolicitud = long.Parse(txtIdpedido.Text);
                                                objHorario.IdTurno = int.Parse(dgvDetallePedidoServicio.Rows[i].Cells["Turno"].Value.ToString());

                                                if (objCtrPago.InsertarPago(objPago) && objCtrlHorario.InsertarHorario(objHorario))
                                                {
                                                    if (Convert.ToInt16(cbPlazo.SelectedValue) == 2)
                                                    {
                                                        for (int y = 0; y <= (13 * Convert.ToInt32(this.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value)) - 1; y++)
                                                        {
                                                            Asistencia objAsistencia = new Asistencia();
                                                            objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                                                            objAsistencia.Valor = 0;
                                                            objAsistencia.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                            objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                                                        }
                                                    }
                                                    else if (Convert.ToInt16(cbPlazo.SelectedValue) == 3)
                                                    {
                                                        for (int y = 0; y <= (26 * Convert.ToInt32(this.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value)) - 1; y++)
                                                        {
                                                            Asistencia objAsistencia = new Asistencia();
                                                            objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                                                            objAsistencia.Valor = 0;
                                                            objAsistencia.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                            objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                                                        }
                                                    }

                                                    contar = contar + 1;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Error en el registro del Pago de Crédito", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    break;
                                                }
                                            }
                                            if (dgvDetallePedidoServicio.Rows.Count == contar)
                                            {
                                                BitacoraSolicitudVenta objBitacoraSolicitud = new BitacoraSolicitudVenta();
                                                objBitacoraSolicitud.NombreOperacion = "Registro de Solicitud de Servicio";
                                                objBitacoraSolicitud.FechaOperacion = DateTime.Now;
                                                objBitacoraSolicitud.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                objBitacoraSolicitud.NombreUsuario = Utilitarios.Utilitarios.NombreUsuarioSession;
                                                objCtrlBitacora.InsertarBitacoraSolicitud(objBitacoraSolicitud);

                                                MessageBox.Show("Pedido registrado con éxito!", "Sistema de Ventas");
                                                btnGenerarFactura.Enabled = true;
                                                txtCedulaNit.ReadOnly = true;
                                                btnBuscarCliente.Enabled = false;
                                                btnNuevoCliente.Enabled = false;
                                                dtpFechaVenta.Enabled = false;
                                                btnBuscarServicio.Enabled = false;
                                                cbFormaPago.Enabled = false;
                                                dgvDetallePedidoServicio.Enabled = false;
                                                btnGuardarPedidoServicio.Enabled = false;
                                            }
                                        }
                                        else
                                        {
                                            int contar = 0;
                                            int x = 0;
                                            Credito objCredito = new Credito();
                                            objCredito.IdCredito = objCtrlCredito.GenerarID();
                                            objCredito.FechaCredito = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                            objCredito.FechaPlazo = DateTime.Parse(this.dtpFechaPlazo.Text);
                                            objCredito.Monto = Convert.ToDouble(txtMontoTotal.Text);
                                            objCredito.IdSolicitud = long.Parse(txtIdpedido.Text);
                                            if (objCtrlCredito.InsertarCredito(objCredito))
                                            {
                                                contar = contar + 1;
                                            }
                                            if (txtCuotaInicial.Text != string.Empty)
                                            {
                                                Cuota objCuota = new Cuota();
                                                objCuota.IdCuota = objCtrlCuota.GenerarID();
                                                objCuota.FechaPago = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                                objCuota.MontoCuota = Convert.ToDouble(txtCuotaInicial.Text);
                                                objCuota.IdCredito = objCredito.IdCredito;
                                                if (objCtrlCuota.InsertarCuota(objCuota))
                                                {
                                                    x = x + 1;
                                                }
                                            }

                                            for (int i = 0; i <= this.dgvDetallePedidoServicio.Rows.Count - 1; i++)
                                            {
                                                Horario objHorario = new Horario();
                                                objHorario.IdHorario = objCtrlHorario.GenerarID();
                                                objHorario.HoraInicio = TimeSpan.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["HoraInicio"].Value.ToString());
                                                objHorario.HoraFin = TimeSpan.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["HoraFin"].Value.ToString());
                                                objHorario.RangoDia = this.dgvDetallePedidoServicio.Rows[i].Cells["RangoDias"].Value.ToString();
                                                objHorario.IdServicio = long.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["IdServicio"].Value.ToString());
                                                objHorario.IdCliente = Utilitarios.Utilitarios.IdCliente;
                                                objHorario.IdSolicitud = long.Parse(txtIdpedido.Text);
                                                objHorario.IdTurno = int.Parse(dgvDetallePedidoServicio.Rows[i].Cells["Turno"].Value.ToString());

                                                if (objCtrlHorario.InsertarHorario(objHorario))
                                                {
                                                    if (Convert.ToInt16(cbPlazo.SelectedValue) == 2)
                                                    {
                                                        for (int y = 0; y <= (13 * Convert.ToInt32(this.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value)) - 1; y++)
                                                        {
                                                            Asistencia objAsistencia = new Asistencia();
                                                            objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                                                            objAsistencia.Valor = 0;
                                                            objAsistencia.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                            objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                                                        }
                                                    }
                                                    else if (Convert.ToInt16(cbPlazo.SelectedValue) == 3)
                                                    {
                                                        for (int y = 0; y <= (26 * Convert.ToInt32(this.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value)) - 1; y++)
                                                        {
                                                            Asistencia objAsistencia = new Asistencia();
                                                            objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                                                            objAsistencia.Valor = 0;
                                                            objAsistencia.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                            objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                                                        }
                                                    }
                                                    contar = contar + 1;
                                                }
                                            }

                                            if (dgvDetallePedidoServicio.Rows.Count + 1 == contar || dgvDetallePedidoServicio.Rows.Count + 2 == contar + x)
                                            {
                                                BitacoraSolicitudVenta objBitacoraSolicitud = new BitacoraSolicitudVenta();
                                                objBitacoraSolicitud.NombreOperacion = "Registro de Solicitud de Servicio";
                                                objBitacoraSolicitud.FechaOperacion = DateTime.Now;
                                                objBitacoraSolicitud.IdSolicitud = objAuxSolicitud.IdSolicitud;
                                                objBitacoraSolicitud.NombreUsuario = Utilitarios.Utilitarios.NombreUsuarioSession;
                                                objCtrlBitacora.InsertarBitacoraSolicitud(objBitacoraSolicitud);

                                                MessageBox.Show("Pedido registrado con éxito!", "Sistema de Ventas");
                                                txtCedulaNit.ReadOnly = true;
                                                btnBuscarCliente.Enabled = false;
                                                btnNuevoCliente.Enabled = false;
                                                dtpFechaVenta.Enabled = false;
                                                btnBuscarServicio.Enabled = false;
                                                cbFormaPago.Enabled = false;
                                                dgvDetallePedidoServicio.Enabled = false;
                                                txtCuotaInicial.Enabled = false;
                                                dtpFechaPlazo.Enabled = false;
                                                btnGuardarPedidoServicio.Enabled = false;
                                                btnGenerarFactura.Enabled = false;
                                                this.Close();
                                            }
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Error en el registro de Solicitud.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor seleccione al menos un Servicio para realizar la solicitud.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Favor seleccionar forma de pago", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un Cliente para realizar la solicitud.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos de registro de pedido.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CargarObjetoSolicitud(ref RNSolicitud objRNSolicitud)
        {
            try
            {
                int contar = 0;
                objRNSolicitud.IdSolicitud = long.Parse(txtIdpedido.Text);
                objRNSolicitud.FechaSolicitud = DateTime.Parse(dtpFechaVenta.Text);
                objRNSolicitud.FechaIngreso = DateTime.Parse(dtpFechaIngreso.Text);
                objRNSolicitud.FechaCulminacion = DateTime.Parse(dtpFechaCulminacion.Text);
                objRNSolicitud.EstadoSolicitud = Convert.ToInt32(Utilitarios.Utilitarios.EstadoSolicitud);
                objRNSolicitud.IdTipoPago = int.Parse(cbFormaPago.SelectedValue.ToString());
                objRNSolicitud.IdCliente = Utilitarios.Utilitarios.IdCliente;
                objRNSolicitud.IdTipoSolicitud = Utilitarios.Utilitarios.TipoSolicitud;
                objRNSolicitud.IdPlazo = cbPlazo.SelectedIndex;
                if (cbDescuento.SelectedIndex > 0)
                { objRNSolicitud.IdDescuento = cbDescuento.SelectedIndex; }
                else { objRNSolicitud.IdDescuento = 0; }
                objRNSolicitud.IdUsuario = Utilitarios.Utilitarios.IdUsuario;

                for (int i = 0; i <= this.dgvDetallePedidoServicio.Rows.Count - 1; i++)
                {

                    DetalleSolicitud objdetalle = new DetalleSolicitud();
                    objdetalle.IdSolicitud = objRNSolicitud.IdSolicitud;
                    objdetalle.IdPrecio = long.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["IdPrecio"].Value.ToString());
                    if (dgvDetallePedidoServicio.Rows[i].Cells["Turno"].Value != null)
                    {
                        if (dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value != null)
                        {
                            if (dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString() != "" && dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString() != string.Empty)
                            {
                                if (dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString() != "0")
                                {
                                    objdetalle.Cantidad = int.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString());
                                    var ListaServicio = objRNServicio.TraerClienteServicioPorCedula(long.Parse(txtCedulaNit.Text), long.Parse(this.dgvDetallePedidoServicio.Rows[i].Cells["IdServicio"].Value.ToString()), cbPlazo.SelectedIndex);
                                    if (ListaServicio.Count == 0 || objRNSolicitud.IdCliente == 2)
                                    {
                                        objCtrlSolicitud.InsertarListaDetalle(objdetalle);
                                    }
                                    else
                                    {
                                        MessageBox.Show("En su historial del cliente ya tiene registrado el servicio: " + dgvDetallePedidoServicio.Rows[i].Cells["Servicio"].Value.ToString() + ", por favor ingrese otro servicio", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return false;
                                    }
                                }
                                else { contar = contar + 1; }
                            }
                            else { contar = contar + 1; }
                        }
                        else { contar = contar + 1; }
                    }
                    else { contar = contar + 10; }
                }

                if (contar == 0)
                {
                    return true;
                }
                else if(contar >= 10)
                {
                    DetalleSolicitud objdetalle = new DetalleSolicitud();
                    objCtrlSolicitud.LimpiarListaDetalle(objdetalle);
                    MessageBox.Show("Por favor seleccione un turno", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    DetalleSolicitud objdetalle = new DetalleSolicitud();
                    objCtrlSolicitud.LimpiarListaDetalle(objdetalle);
                    MessageBox.Show("Por favor verifique que la columna cantidad No contenga: \n -Campos vacios\n -Campos con cero '0'", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos de la solicitud.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (btnGuardarPedidoServicio.Enabled == false)
            {
                Factura objFactura = new Factura();

                if (CargarObjetoFactura(objFactura))
                {
                    if (objCtrlFactura.InsertarFactura(objFactura))
                    {
                        btnGenerarFactura.Enabled = false;
                        Utilitarios.Utilitarios.IdSolicitud = Int64.Parse(txtIdpedido.Text);
                        Utilitarios.Utilitarios.nroReporte = 2;
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
                    Utilitarios.Utilitarios.IdFactura = objFactura.IdFactura;
                }
                else
                {
                    MessageBox.Show("No se puede Generar Factura, favor solicite nueva Dosificación para generar factura", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                objFactura.CodigoAutorizacion = Convert.ToInt64(Utilitarios.Utilitarios.CodigoAutorizacion);
                objFactura.FechaFactura = DateTime.Now;
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
                MessageBox.Show("Error en cargar los datos de la factura.", "Sistemas de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void cbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDescuento.SelectedIndex > 0)
                {
                    RNDescuento objDescuento = new RNDescuento();
                    var ListaDescuento = objDescuento.TraerDescuento(cbDescuento.SelectedIndex);

                    foreach (var item in ListaDescuento)
                    {
                        txtDescuento.Text = item.Monto.ToString();
                        if (txtSubTotal.Text != string.Empty)
                        {
                            txtMontoTotal.Text = (Convert.ToDouble(txtSubTotal.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
                        }
                        else
                        {
                            txtSubTotal.Text = "0";
                            txtMontoTotal.Text = (Convert.ToDouble(txtSubTotal.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
                        }
                        break;
                    }
                }
                else
                {
                    txtDescuento.Text = "0";
                    if (txtSubTotal.Text != string.Empty || txtSubTotal.Text != "")
                    {
                        txtMontoTotal.Text = (Convert.ToDouble(txtSubTotal.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
                    }
                }
            }
            catch (Exception f) { MessageBox.Show(f.Message); }
        }

        private void form_Dispuesto(object sender, EventArgs e)
        {
            form = null;
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

        public void ActualizarTotalesGrillaServicio()
        {
            try
            {
                Decimal ac = 0;
                Decimal Total;
                for (int i = 0; i <= this.dgvDetallePedidoServicio.Rows.Count - 1; i++)
                {
                    if (dgvDetallePedidoServicio.Rows[i].Cells["Precio"].Value.ToString() != "")
                    {
                        long cantidad = long.Parse(dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString());
                        Decimal Precio = Decimal.Parse(dgvDetallePedidoServicio.Rows[i].Cells["Precio"].Value.ToString().Replace(".", ","));

                        Total = Precio * cantidad;
                        dgvDetallePedidoServicio.Rows[i].Cells["Total"].Value = Total;
                        ac = ac + Total;
                    }
                }
                txtSubTotal.Text = ac.ToString().Replace(".", ",");
                txtMontoTotal.Text = (Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtDescuento.Text)).ToString().Replace(".", ",");

            }
            catch (Exception)
            { MessageBox.Show("Error en actualizar los datos Grilla de Servicio.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCli.TerminarFuenteDeVideo();
        }
        private void frmListaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (txtCedulaNit.Text == "0")
            {
                cbPlazo.SelectedIndex = 1;
                cbFormaPago.SelectedIndex = 1;
                cbPlazo.Enabled = false;
                cbFormaPago.Enabled = false;
                btnBuscarServicio.Focus();
            }
            else if (Utilitarios.Utilitarios.EventoClic == 1)
            {
                cbPlazo.Enabled = true;
                cbFormaPago.Enabled = true;
                cbPlazo.SelectedIndex = 0;
                cbDescuento.SelectedIndex = 0;
                cbFormaPago.SelectedIndex = 0;
                cbPlazo.Focus();
            }
           
            txtCedulaNit.ReadOnly = true;

        }
        private void frmListaServicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnGuardarPedidoServicio.Focus();
        }

      
        public void dgvDetallePedidoServicio_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 5)
            {
                this.ActualizarTotalesGrillaServicio();
            }
        }

        private void cbPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlazo.SelectedIndex == 1)
            {
                dtpFechaIngreso.Enabled = false;
                dtpFechaCulminacion.Enabled = false;
                cbFormaPago.Enabled = false;
                cbFormaPago.SelectedIndex = 1;
                cbDescuento.Enabled = false;
                cbDescuento.SelectedIndex = 0;
                dtpFechaIngreso.Value = DateTime.Now;
                dtpFechaCulminacion.Value = dtpFechaIngreso.Value;
                btnBuscarServicio.Enabled = true;
            }
            else if (cbPlazo.SelectedIndex > 1)
            {
                RNPlazo objPlazo = new RNPlazo();
                var ListaPlazo = objPlazo.TraerPlazo(cbPlazo.SelectedIndex);

                foreach (var item in ListaPlazo)
                {
                    dtpFechaCulminacion.Value = dtpFechaIngreso.Value.AddDays(item.Numerodias);
                    dtpFechaIngreso.Enabled = true;
                    dtpFechaCulminacion.Enabled = true;
                    break;
                }
                if (cbPlazo.SelectedIndex == 2)
                {
                    cbFormaPago.Enabled = true;
                }
                else if (cbPlazo.SelectedIndex == 3)
                {
                    cbFormaPago.Enabled = true;
                }
                btnBuscarServicio.Enabled = true;
                cbDescuento.Enabled = true;
            }
            else { btnBuscarServicio.Enabled = false; }

            if (dgvDetallePedidoServicio.RowCount > 0)
            {
                dgvDetallePedidoServicio.Rows.Clear();
                txtSubTotal.Clear();
                txtMontoTotal.Clear();
            }
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            if (cbPlazo.SelectedIndex > 1)
            {
                RNPlazo objPlazo = new RNPlazo();
                var ListaPlazo = objPlazo.TraerPlazo(cbPlazo.SelectedIndex);

                foreach (var item in ListaPlazo)
                {
                    dtpFechaCulminacion.Value = dtpFechaIngreso.Value.AddDays(item.Numerodias);
                    break;
                }
            }
        }

        private void txtCedulaNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                long id = 0;

                if (txtCedulaNit.Text.Trim() == "")
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
                        cbPlazo.Focus();
                    }
                    else { txtNombreCliente.Clear(); }
                }
                if (txtCedulaNit.Text == "0")
                {
                    cbPlazo.SelectedIndex = 1;
                    cbFormaPago.SelectedIndex = 1;
                    cbDescuento.Enabled = false;
                    cbPlazo.Enabled = false;
                    cbFormaPago.Enabled = false;
                    btnBuscarServicio.Focus();
                }
            }
            else { objRNValidar.Numeros(e); }
        }

        private void dgvDetallePedidoServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallePedidoServicio.Rows.Count > 0)
            {
                if (e.RowIndex > -1 && e.ColumnIndex == 10)
                {
                    if (MessageBox.Show("Quitar Disciplina de la canasta?", "Sistema de Ventas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dgvDetallePedidoServicio.Rows.RemoveAt(dgvDetallePedidoServicio.CurrentCell.RowIndex);
                        ActualizarTotalesGrillaServicio();
                    }
                }
            }
        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPago.SelectedIndex == 1)
            {
                groupBox6.Visible = false;
                txtCuotaInicial.Clear();
                btnGuardarPedidoServicio.Focus();
                cbDescuento.Enabled = true;
            }
            else if (cbFormaPago.SelectedIndex == 2)
            {
                groupBox6.Visible = true;
                txtMontoCredito.Text = txtMontoTotal.Text;
                btnGuardarPedidoServicio.Focus();
                cbDescuento.Enabled = false;
                cbDescuento.SelectedIndex = 0;
            }
            else
            {
                groupBox6.Visible = false;
                txtMontoCredito.Clear();
                txtCuotaInicial.Clear();
            }
        }

        private void txtCuotaInicial_TextChanged(object sender, EventArgs e)
        {
            Decimal CuotaInicial = 0;
            Decimal.TryParse(txtCuotaInicial.Text, out CuotaInicial);

            Decimal MontoCredito = 0;
            Decimal.TryParse(txtMontoTotal.Text, out MontoCredito);

            txtMontoCredito.Text = (MontoCredito - CuotaInicial).ToString();
        }

        private void dgvDetallePedidoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvDetallePedidoServicio.CurrentCell.ColumnIndex == 5)
            {
                objRNValidar.Numeros(e);
            }
        }

        private void dgvDetallePedidoServicio_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetallePedidoServicio.CurrentCell.ColumnIndex == 5)
            {
                try
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(dgvDetallePedidoServicio_KeyPress);
                        txt.KeyPress += new KeyPressEventHandler(dgvDetallePedidoServicio_KeyPress);
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtCuotaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtCuotaInicial);
        }
    }
}
