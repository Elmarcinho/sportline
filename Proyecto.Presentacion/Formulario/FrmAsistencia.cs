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
    public partial class FrmAsistencia : Form
    {
        CtrlAsistencia objCtrlAsistencia = new CtrlAsistencia();
        RNValidar objRNValidar = new RNValidar();
        RNAsistencia objRNAsistencia = new RNAsistencia();
        RNCredito objRNCredito = new RNCredito();
        public FrmAsistencia()
        {
            InitializeComponent();
        }
        public void NotificacionDeuda()
        {
            NotificacionDeudor.Text = "Notificación SportLine";
            NotificacionDeudor.BalloonTipTitle = "Notificación de Crédito ";
            NotificacionDeudor.BalloonTipText = "Cliente tiene Deuda..!";
            NotificacionDeudor.BalloonTipIcon = ToolTipIcon.Info;

            NotificacionDeudor.Visible = true;
            NotificacionDeudor.ShowBalloonTip(3000);
        }
        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            txtCedulaCliente.Focus();
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Utilitarios.Utilitarios.CedulaIdendidad = (Convert.ToInt64(txtCedulaCliente.Text));

                long id = 0;

                if (txtCedulaCliente.Text.Trim() == "")
                {
                    pbcCliente.Image = Properties.Resources.user;
                    lbNombreCliente.Text="";
                    lbEstadoPlan.Text = "";
                    lbDias.Text = "";
                    label1.Visible = false;
                    label2.Visible = false;
                    pnAsistencia.BackColor = Color.White;
                }
                else if (long.TryParse(txtCedulaCliente.Text, out id))
                {
                    var ClienteAsistencia = objRNAsistencia.TraerClienteAsistenciaPorCedula(Convert.ToInt64(txtCedulaCliente.Text));
                    var ClienteAsistenciaMarcado = objRNAsistencia.TraerClienteAsistenciaPorCedulaVencido(Convert.ToInt64(txtCedulaCliente.Text));
                    var ClienteCredito = objRNCredito.TraerClienteCreditoPorCedula(Convert.ToInt64(txtCedulaCliente.Text));
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
                            {
                                Dias2 = Convert.ToInt32((DateTime.Now - itemMarcado.FechaRenovacion.Value).TotalDays);
                                FechaReno = itemMarcado.FechaRenovacion.Value;
                            }
                            UltimaFecha = itemMarcado.FechaAsistencia.Value;
                            IdAsistencia = itemMarcado.IdAsistencia;
                            break;
                        }
                    }
                    if ((Dias1 < 90 && FechaReno==null) || (Dias2 < 90 && FechaReno!=null))
                    {
                        if (ClienteAsistencia.LongCount() != 0)
                        {
                            foreach (var item in ClienteAsistencia)
                            {
                                Asistencia objAsistencia = new Asistencia();
                                objAsistencia.IdAsistencia = item.IdAsistencia;
                                objAsistencia.FechaAsistencia = DateTime.Now;
                                objAsistencia.Valor = 1;
                                if (objCtrlAsistencia.ModificarAsistencia(objAsistencia))
                                {
                                    pnAsistencia.BackColor = Color.FromArgb(0, 255, 127);
                                }

                                pbcCliente.SizeMode = PictureBoxSizeMode.StretchImage;//Acomoda la imagen al tamaño del picture
                                byte[] datos = new byte[0];
                                datos = (byte[])item.Foto;//Extrae la imagen
                                if (datos != null)//validacion si no tiene foto
                                {
                                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                                    pbcCliente.Image = Bitmap.FromStream(ms);
                                }
                                else { pbcCliente.Image = Properties.Resources.user; }

                                lbNombreCliente.Text = item.NombreCliente;
                                lbEstadoPlan.Text = "Plan Vigente";
                                lbDias.Text = (ClienteAsistencia.LongCount() - 1).ToString();
                                label1.Visible = true;
                                label2.Visible = true;

                                if (ClienteCredito.LongCount() != 0)
                                {
                                    NotificacionDeuda();
                                }

                                break;
                            }
                        }
                        else
                        {
                            if (ClienteAsistenciaMarcado.LongCount() != 0)
                            {
                                foreach (var item2 in ClienteAsistenciaMarcado)
                                {
                                    pbcCliente.SizeMode = PictureBoxSizeMode.StretchImage;//Acomoda la imagen al tamaño del picture
                                    byte[] datos = new byte[0];
                                    datos = (byte[])item2.Foto;//Extrae la imagen
                                    if (datos != null)//validacion si no tiene foto
                                    {
                                        System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                                        pbcCliente.Image = Bitmap.FromStream(ms);
                                    }
                                    else { pbcCliente.Image = Properties.Resources.user; }

                                    lbNombreCliente.Text = item2.NombreCliente;
                                    lbEstadoPlan.Text = "Plan Vencido";
                                    pnAsistencia.BackColor = Color.Red;
                                    lbDias.Text = "0";
                                    label1.Visible = true;
                                    label2.Visible = true;

                                    if (ClienteCredito.LongCount() != 0)
                                    {
                                        NotificacionDeuda();
                                    }

                                    break;
                                }
                            }
                            else
                            {
                                lbNombreCliente.Text = "";
                                lbEstadoPlan.Text = "";
                                lbDias.Text = "";
                                label1.Visible = false;
                                label2.Visible = false;
                                pnAsistencia.BackColor = Color.White;
                                pbcCliente.Image = Properties.Resources.user;
                                MessageBox.Show("Cliente no se encuentra registrado en ningun Plan.!", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else 
                    {
                        if (ClienteAsistencia.LongCount() != 0)
                        {
                            foreach (var item3 in ClienteAsistencia)
                            {
                                Asistencia objAsistencia = new Asistencia();
                                objAsistencia.IdAsistencia = item3.IdAsistencia;
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

                        foreach (var item4 in ClienteAsistenciaMarcado)
                        {
                            pbcCliente.SizeMode = PictureBoxSizeMode.StretchImage;//Acomoda la imagen al tamaño del picture
                            byte[] datos = new byte[0];
                            datos = (byte[])item4.Foto;//Extrae la imagen
                            if (datos != null)//validacion si no tiene foto
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                                pbcCliente.Image = Bitmap.FromStream(ms);
                            }
                            else { pbcCliente.Image = Properties.Resources.user; }

                            lbNombreCliente.Text = item4.NombreCliente;
                            lbEstadoPlan.Text = "Plan Vencido";
                            pnAsistencia.BackColor = Color.Red;
                            lbDias.Text = "0";
                            label1.Visible = true;
                            label2.Visible = true;

                            if (ClienteCredito.LongCount() != 0)
                            {
                                NotificacionDeuda();
                            }

                            break;
                        }
                    }
                    txtCedulaCliente.Clear();
                }
            }
            else
            {
                objRNValidar.Numeros(e);
            }
        }

        private void NotificacionDeudor_BalloonTipClicked(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmPagoCredito"] != null)
            {
                Application.OpenForms["FrmPagoCredito"].BringToFront();
                return;
            }
            FrmPagoCredito FCredito = new FrmPagoCredito();
            FCredito.Show();
            FCredito.txbBuscarCliente.Text=Utilitarios.Utilitarios.CedulaIdendidad.ToString();

            KeyPressEventArgs kea = new KeyPressEventArgs(Convert.ToChar(13));
            FCredito.txbBuscarCliente_KeyPress(sender, kea);
        }
    }
}
