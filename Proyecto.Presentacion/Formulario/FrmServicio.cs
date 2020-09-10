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
    public partial class FrmServicio : Form
    {
        CtrlServicio objCtrlServicio = new CtrlServicio();
        CtrlPrecio objCtrlPrecio = new CtrlPrecio();
        RNValidar objRNValidar = new RNValidar();
        RNServicio objRNServicio = new RNServicio();
        public FrmServicio()
        {
            InitializeComponent();
        }
        private void FrmServicio_Load(object sender, EventArgs e)
        {
            dtpHoraInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            dtpHoraFin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            this.CargarComboDia();
        }
        private void CargarComboDia()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdDia");
            dt.Columns.Add("NombreDia");
            dt.AcceptChanges();

            DataRow dr0 = dt.NewRow();
            dr0[0] = "0";
            dr0[1] = "--- Seleccionar ---";

            DataRow dr1 = dt.NewRow();
            dr1[0] = "1";
            dr1[1] = "Lunes a Viernes";

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Lun - Mie - Vie";

            DataRow dr3 = dt.NewRow();
            dr3[0] = "1";
            dr3[1] = "Lunes a Sabados";

            DataRow dr4 = dt.NewRow();
            dr4[0] = "2";
            dr4[1] = "Mar - Jue";

            dt.Rows.Add(dr0);
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);
            dt.AcceptChanges();

            this.cbRangoDia.DisplayMember = "NombreDia";
            this.cbRangoDia.ValueMember = "IdDia";
            this.cbRangoDia.DataSource = dt;
        }
        private void BtnGuardarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCtrlServicio.Validar(txtNombreServicio.Text, txtPrecioDiario.Text, txtPrecioQuincenal.Text, txtPrecioMensual.Text))
                {
                    if (Convert.ToInt64(cbRangoDia.SelectedValue) != 0)
                    {
                        Servicio objServicio = new Servicio();
                        Precio objPrecio = new Precio();

                        if (CargarObjetoServicio(objServicio, objPrecio))
                        {
                            if (Utilitarios.Utilitarios.Evento == 0)
                            {
                                if (objCtrlServicio.InsertarServicio(objServicio, objPrecio))
                                {
                                    MessageBox.Show("Servicio Registrado con éxito!", "Sistema de Ventas");
                                    this.Close();
                                }
                                else
                                { MessageBox.Show("Error en el registro del Servicio", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            else
                            {
                                if (Convert.ToDouble(txtPrecioDiario.Text.Replace(".", ",")) == Utilitarios.Utilitarios.PrecioDiario && Convert.ToDouble(txtPrecioMensual.Text.Replace(".", ",")) == Utilitarios.Utilitarios.PrecioMensual)
                                {
                                    if (objCtrlServicio.ModificarServicio(objServicio, objPrecio))
                                    {
                                        MessageBox.Show("Servicio Actualizado con éxito!", "Sistema de Ventas");
                                        this.Close();
                                    }
                                    else
                                    { MessageBox.Show("Error en la actualizacion del Servicio", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                }
                                else
                                {
                                    if (objCtrlServicio.ModificarServicio(objServicio, objPrecio))
                                    {
                                        objPrecio.IdPrecio = objCtrlPrecio.GenerarID();
                                        objPrecio.PrecioCompra = 0;
                                        objPrecio.PrecioVenta = 0;
                                        objPrecio.PrecioDiario = Convert.ToDouble(txtPrecioDiario.Text.Replace(".", ","));
                                        objPrecio.PrecioQuincenal = Convert.ToDouble(txtPrecioQuincenal.Text.Replace(".", ","));
                                        objPrecio.PrecioMensual = Convert.ToDouble(txtPrecioMensual.Text.Replace(".", ","));
                                        objPrecio.FechaInicial = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                        objPrecio.FechaFinal = null;
                                        objPrecio.IdServicio = Utilitarios.Utilitarios.IdServicio;
                                        objPrecio.EstadoPrecio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPrecio);
                                        if (objCtrlPrecio.InsertarPrecio(objPrecio))
                                        {
                                            MessageBox.Show("Servicio Actualizado con éxito!", "Sistema de Ventas");
                                            this.Close();
                                        }
                                        else
                                        { MessageBox.Show("Error al insertar el nuevo Precio", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                                    }
                                    else
                                    { MessageBox.Show("Error en la actualización del Producto", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor seleccionar los dias de atención", "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CargarObjetoServicio(Servicio objServicio, Precio objPrecio)
        {
            try
            {
                var x = objRNServicio.TraerServicioPorNombreExacto(txtNombreServicio.Text.Trim());

                objPrecio.EstadoPrecio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPrecio);

                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    objServicio.IdServicio = objCtrlServicio.GenerarID();
                    objPrecio.IdPrecio = objCtrlPrecio.GenerarID();

                    if (x.LongCount() == 0)
                    { objServicio.NombreServicio = txtNombreServicio.Text; }
                    else { MessageBox.Show("No se puede registrar Servicio, porque ya existe registro con el mismo Nombre, por favor verifique e intente nuevamente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                }
                else
                {
                    objServicio.IdServicio = Utilitarios.Utilitarios.IdServicio;
                    objPrecio.IdPrecio = Utilitarios.Utilitarios.IdPrecio;

                    if (x.LongCount() == 0)
                    { objServicio.NombreServicio = txtNombreServicio.Text; }
                    else if (x.LongCount() == 1)
                    {
                        objServicio.NombreServicio = txtNombreServicio.Text;
                    }
                    else { MessageBox.Show("No se puede actualizar Producto, porque ya existe registro con el mismo Nombre, por favor verifique.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                    if (Convert.ToDouble(txtPrecioDiario.Text.Replace(".", ",")) != Utilitarios.Utilitarios.PrecioDiario|| Convert.ToDouble(txtPrecioMensual.Text.Replace(".", ",")) != Utilitarios.Utilitarios.PrecioMensual)
                    {
                        objPrecio.FechaFinal = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        objPrecio.EstadoPrecio = 0;
                    }
                }
                objServicio.Descripcion = txtDescripcionServicio.Text;
                objServicio.HoraInicio = TimeSpan.Parse(dtpHoraInicio.Value.ToString("HH:mm:ss"));
                objServicio.HoraFin = TimeSpan.Parse(dtpHoraFin.Value.ToString("HH:mm:ss"));
                objServicio.RangoDia = cbRangoDia.Text;
                objServicio.EstadoServicio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoServicio);
                objPrecio.PrecioCompra = 0;
                objPrecio.PrecioVenta = 0;
                if (txtPrecioDiario.Text != "0" && txtPrecioDiario.Text != "0.")
                {
                    objPrecio.PrecioDiario = Convert.ToDouble(txtPrecioDiario.Text.Replace(".", ","));
                }
                else { MessageBox.Show("Los datos del Precio Diario no son correctos, por favor ingrese datos válidos", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                if (txtPrecioQuincenal.Text != "0" && txtPrecioQuincenal.Text != "0.")
                {
                    objPrecio.PrecioQuincenal = Convert.ToDouble(txtPrecioQuincenal.Text.Replace(".", ","));
                }
                else { MessageBox.Show("Los datos del Precio Quincenal no son correctos, por favor ingrese datos válidos", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                if (txtPrecioMensual.Text != "0" && txtPrecioMensual.Text != "0.")
                {
                    objPrecio.PrecioMensual = Convert.ToDouble(txtPrecioMensual.Text.Replace(".", ","));
                }
                else { MessageBox.Show("Los datos del Precio Mensual no son correctos, por favor ingrese datos válidos", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                objPrecio.FechaInicial = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                objPrecio.IdServicio = objServicio.IdServicio;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos del Servicio.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtPrecioVentaServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtPrecioDiario);
        }

        private void txtPrecioQuincenal_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtPrecioQuincenal);
        }

        private void txtPrecioMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtPrecioMensual);
        }

        private void txtPrecioMensual_TextChanged(object sender, EventArgs e)
        {
            Decimal PrecioQuincenal, PrecioMensual;

            Decimal.TryParse(txtPrecioMensual.Text.Replace(".", ","), out PrecioMensual);

            PrecioQuincenal = PrecioMensual / 2;

            txtPrecioQuincenal.Text = PrecioQuincenal.ToString();
        }

        private void txtNombreServicio_Leave(object sender, EventArgs e)
        {
            this.pictBoxSer1.Visible = false;
        }

        private void txtNombreServicio_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombreServicio.Text) || txtNombreServicio.Text.Length < 3)
                {
                    pictBoxSer1.BackColor = Color.Red;
                    this.txtNombreServicio.BackColor = Color.LightYellow;
                    pictBoxSer1.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrecioDiario_Leave(object sender, EventArgs e)
        {
            this.pictBoxSer2.Visible = false;
        }

        private void txtPrecioDiario_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtPrecioDiario.Text))
                {
                    pictBoxSer2.BackColor = Color.Red;
                    this.txtPrecioDiario.BackColor = Color.LightYellow;
                    pictBoxSer2.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrecioMensual_Leave(object sender, EventArgs e)
        {
            this.pictBoxSer3.Visible = false;
        }

        private void txtPrecioMensual_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtPrecioMensual.Text))
                {
                    pictBoxSer3.BackColor = Color.Red;
                    this.txtPrecioMensual.BackColor = Color.LightYellow;
                    pictBoxSer3.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
