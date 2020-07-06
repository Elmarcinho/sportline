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
    public partial class FrmDisciplina : Form
    {
        CtrlServicio objCtrlServicio = new CtrlServicio();
        CtrlPrecio objCtrlPrecio = new CtrlPrecio();
        RNValidar objRNValidar = new RNValidar();
        RNServicio objRNServicio = new RNServicio();
        public FrmDisciplina()
        {
            InitializeComponent();
        }
        private void FrmServicio_Load(object sender, EventArgs e)
        {
            this.CargarComboPlazo();
        }
        private void CargarComboPlazo()
        {
            RNPlazo objPlazo = new RNPlazo();
            this.cbPlazo.DataSource = objPlazo.TraerPlazo(0);
            this.cbPlazo.DisplayMember = "NombrePlazo";
            this.cbPlazo.ValueMember = "IdPlazo";
        }
        private void BtnGuardarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCtrlServicio.Validar(txtNombreServicio.Text, txtPrecioVentaServicio.Text))
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
                            //if (Convert.ToDouble(txtPrecioVentaServicio.Text.Replace(".", ",")) == Utilitarios.Utilitarios.PrecioVenta)
                            //{
                            //    if (objCtrlServicio.ModificarProducto(objServicio, objPrecio))
                            //    {
                            //        MessageBox.Show("Servicio Actualizado con éxito!", "Sistema de Ventas");
                            //        this.Close();
                            //    }
                            //    else
                            //    { MessageBox.Show("Error en la actualizacion del Servicio", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            //}
                            //else
                            //{
                            //    if (objCtrlServicio.ModificarProducto(objServicio, objPrecio))
                            //    {
                            //        objPrecio.IdPrecio = objCtrlPrecio.GenerarID();
                            //        objPrecio.PrecioCompra = Convert.ToDouble(txtPrecioCompraProducto.Text.Replace(".", ","));
                            //        objPrecio.PrecioVenta = Convert.ToDouble(txtPrecioVentaServicio.Text.Replace(".", ","));
                            //        objPrecio.FechaInicial = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            //        objPrecio.FechaFinal = null;
                            //        objPrecio.IdProducto = Utilitarios.Utilitarios.IdProducto;
                            //        objPrecio.EstadoPrecio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPrecio);
                            //        if (objCtrlPrecio.InsertarPrecio(objPrecio))
                            //        {
                            //            MessageBox.Show("Producto Actualizado con éxito!", "Sistema de Ventas");
                            //            this.Close();
                            //        }
                            //        else
                            //        { MessageBox.Show("Error al insertar el nuevo Precio", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                            //    }
                            //    else
                            //    { MessageBox.Show("Error en la actualizacion del Producto", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            //}
                        }
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
                    //objProducto.IdProducto = Utilitarios.Utilitarios.IdProducto;
                    //objPrecio.IdPrecio = Utilitarios.Utilitarios.IdPrecio;

                    //if (x.LongCount() == 0)
                    //{ objProducto.NombreProducto = txtNombreServicio.Text; }
                    //else if (x.LongCount() == 1)
                    //{
                    //    objProducto.NombreProducto = txtNombreServicio.Text;
                    //}
                    //else { MessageBox.Show("No se puede actualizar Producto, porque ya existe registro con el mismo Nombre, por favor verifique.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                    //if (Convert.ToDouble(txtPrecioVentaServicio.Text.Replace(".", ",")) != Utilitarios.Utilitarios.PrecioVenta)
                    //{
                    //    objPrecio.FechaFinal = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    //    objPrecio.EstadoPrecio = 0;
                    //}
                }
                objServicio.Descripcion = txtDescripcionServicio.Text;
                objServicio.Plazo = cbPlazo.SelectedIndex;
                objServicio.EstadoServicio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoServicio);

                if (txtPrecioVentaServicio.Text != "0" && txtPrecioVentaServicio.Text != "0.")
                {
                    objPrecio.PrecioVenta = Convert.ToDouble(txtPrecioVentaServicio.Text.Replace(".", ","));
                }
                else { MessageBox.Show("Los datos del Precio no son correctos, por favor ingrese datos válidos", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

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
            objRNValidar.Decimal(e, txtPrecioVentaServicio);
        }

    }
}
