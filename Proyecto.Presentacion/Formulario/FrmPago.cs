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
    public partial class FrmPago : Form
    {
        CtrlPago objCtrPago = new CtrlPago();
        CtrlFactura objCtrlFactura = new CtrlFactura();
        CtrlAsistencia objCtrlAsistencia = new CtrlAsistencia();
        CtrlCredito objCtrlCredito = new CtrlCredito();
        CtrlCuota objCtrlCuota = new CtrlCuota();
        RNAsistencia objRNAsistencia = new RNAsistencia();
        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            this.CargarComboCantidad();
            this.CargarComboFomaPago();
            this.CargarComboDescuento();
        }
        private void CargarComboDescuento()
        {
            RNDescuento objDescuento = new RNDescuento();
            this.cbDescuento.DataSource = objDescuento.TraerDescuento(0);
            this.cbDescuento.DisplayMember = "NombreDescuento";
            this.cbDescuento.ValueMember = "IdDescuento";
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
        private void CargarComboCantidad()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdMeses");
            dt.Columns.Add("NombreMeses");
            dt.AcceptChanges();

            DataRow dr1 = dt.NewRow();
            dr1[0] = "1";
            dr1[1] = "1";

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "2";

            DataRow dr3 = dt.NewRow();
            dr3[0] = "3";
            dr3[1] = "3";

            DataRow dr4 = dt.NewRow();
            dr4[0] = "4";
            dr4[1] = "4";

            DataRow dr5 = dt.NewRow();
            dr5[0] = "5";
            dr5[1] = "5";

            DataRow dr6 = dt.NewRow();
            dr6[0] = "6";
            dr6[1] = "6";

            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.Rows.Add(dr5);
            dt.Rows.Add(dr6);
            dt.AcceptChanges();

            this.cbCantidad.DisplayMember = "NombreMeses";
            this.cbCantidad.ValueMember = "IdMeses";
            this.cbCantidad.DataSource = dt;
        }
        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbFormaPago.SelectedValue) != 0)
            {
                var ClienteAsistencia = objRNAsistencia.TraerClienteAsistenciaPorCedula(Convert.ToInt64(lbCedula.Text));
                var ClienteAsistenciaMarcado = objRNAsistencia.TraerClienteAsistenciaPorCedulaVencido(Convert.ToInt64(lbCedula.Text));
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
                    Pago objPago = new Pago();
                    objPago.IdPago = objCtrPago.GenerarID();
                    Utilitarios.Utilitarios.IdPago = objPago.IdPago;
                    objPago.FechaPago = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    objPago.Descuento = Convert.ToDouble(txtDescuento.Text);
                    objPago.Monto = Convert.ToDouble(txtMontoTotal.Text);
                    objPago.Cantidad = int.Parse(cbCantidad.SelectedValue.ToString());
                    objPago.EstadoPago = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPago);
                    objPago.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
                    objPago.IdPrecio = Utilitarios.Utilitarios.IdPrecio;

                    if (objCtrPago.InsertarPago(objPago))
                    {

                        if (lbPlan.Text == "Quincenal")
                        {
                            for (int y = 0; y <= (13 * Convert.ToInt32(cbCantidad.SelectedValue)) - 1; y++)
                            {
                                Asistencia objAsistencia = new Asistencia();
                                objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                                objAsistencia.Valor = 0;

                                objAsistencia.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
                                objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                            }
                        }
                        else if (lbPlan.Text == "Mensual")
                        {
                            for (int y = 0; y <= (26 * Convert.ToInt32(cbCantidad.SelectedValue)) - 1; y++)
                            {
                                Asistencia objAsistencia = new Asistencia();
                                objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                                objAsistencia.Valor = 0;

                                objAsistencia.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
                                objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                            }
                        }

                        MessageBox.Show("Pago registrado con éxito!", "Sistema de Ventas");
                        btnGenerarFactura.Enabled = true;
                        cbDescuento.Enabled = false;
                        btnGuardarPago.Enabled = false;
                    }
                }
                else
                {
                    Credito objCredito = new Credito();
                    objCredito.IdCredito = objCtrlCredito.GenerarID();
                    objCredito.FechaCredito = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    objCredito.FechaPlazo = DateTime.Parse(this.dtpFechaPlazo.Text);
                    objCredito.Monto = Convert.ToDouble(txtMontoTotal.Text);
                    objCredito.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
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

                    if (lbPlan.Text == "Quincenal")
                    {
                        for (int y = 0; y <= (13 * Convert.ToInt32(cbCantidad.SelectedValue)) - 1; y++)
                        {
                            Asistencia objAsistencia = new Asistencia();
                            objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                            objAsistencia.Valor = 0;
                            objAsistencia.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
                            objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                        }
                    }
                    else if (lbPlan.Text == "Mensual")
                    {
                        for (int y = 0; y <= (26 * Convert.ToInt32(cbCantidad.SelectedValue)) - 1; y++)
                        {
                            Asistencia objAsistencia = new Asistencia();
                            objAsistencia.IdAsistencia = objCtrlAsistencia.GenerarID();
                            objAsistencia.Valor = 0;
                            objAsistencia.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
                            objCtrlAsistencia.InsertarAsistencia(objAsistencia);
                        }
                    }
                    MessageBox.Show("Pago registrado con éxito!", "Sistema de Ventas");

                    cbFormaPago.Enabled = false;
                    cbDescuento.Enabled = false;
                    btnGuardarPago.Enabled = false;
                    txtCuotaInicial.Enabled = false;
                    dtpFechaPlazo.Enabled = false;
                    btnGuardarPago.Enabled = false;
                    btnGenerarFactura.Enabled = false;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Favor seleccionar forma de pago", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (btnGuardarPago.Enabled == false)
            {
                Factura objFactura = new Factura();
                if (CargarObjetoFactura(objFactura))
                {
                    if (objCtrlFactura.InsertarFactura(objFactura))
                    {
                        btnGenerarFactura.Enabled = false;
                        Utilitarios.Utilitarios.nroReporte = 2;
                        if (Application.OpenForms["FrmRptFactura"] != null)
                        {
                            Application.OpenForms["FrmRptFactura"].BringToFront();
                            return;
                        }
                        FrmRptFactura objRptFactura = new FrmRptFactura();
                        objRptFactura.Show();
                        this.Close();
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
                objFactura.CodigoControl = Utilitarios.Crypto.CodigoDeControl.generateControlCode(Utilitarios.Utilitarios.CodigoAutorizacion, Convert.ToString(objFactura.IdFactura), lbCedula.Text, (FechaFactura).Replace("/", ""), txtMontoTotal.Text, Utilitarios.Utilitarios.LlaveDosificacion);
                objFactura.FechaLimiteEmision = Utilitarios.Utilitarios.FechaLimiteEmision;
                //Generar CodigoQR
                string Cadena = Utilitarios.Utilitarios.Nit + "|" + Convert.ToString(objFactura.IdFactura) + "|" + Utilitarios.Utilitarios.CodigoAutorizacion + "|" + FechaFactura + "|" + txtMontoTotal.Text + "|" + txtMontoTotal.Text + "|" + objFactura.CodigoControl + "|" + lbCedula.Text + "|" + "0.00" + "|" + "0.00";
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
                objFactura.IdSolicitud = Utilitarios.Utilitarios.IdSolicitud;
                objFactura.IdPago = Utilitarios.Utilitarios.IdPago;
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
                        txtMontoTotal.Text = (Convert.ToDouble(txtSubTotal.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
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

        private void cbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSubTotal.Text != string.Empty)
            {
                txtSubTotal.Text = (Utilitarios.Utilitarios.PrecioServicio * Convert.ToDouble(cbCantidad.SelectedValue)).ToString();
                txtMontoTotal.Text = (Convert.ToDouble(txtSubTotal.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
            }
        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPago.SelectedIndex == 1)
            {
                groupBox6.Visible = false;
                txtCuotaInicial.Clear();
                btnGuardarPago.Focus();
                cbDescuento.Enabled = true;
            }
            else if (cbFormaPago.SelectedIndex == 2)
            {
                groupBox6.Visible = true;
                txtMontoCredito.Text = txtMontoTotal.Text;
                btnGuardarPago.Focus();
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
    }
}
