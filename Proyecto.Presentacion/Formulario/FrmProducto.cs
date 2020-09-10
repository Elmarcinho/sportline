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

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmProducto : Form
    {
        CtrlProducto objCtrlProducto = new CtrlProducto();
        CtrlPrecio objCtrlPrecio = new CtrlPrecio();
        RNValidar objRNValidar = new RNValidar();
        Negocio.RNLista.RNProducto objRNProducto = new Negocio.RNLista.RNProducto();
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            this.CargarComboCategoria();
        }
        private void CargarComboCategoria()
        {
            Negocio.RNLista.RNCategoria objRNCategoria = new Negocio.RNLista.RNCategoria();
            this.cbCategoriaProducto.DataSource = objRNCategoria.TraerCategoria(0);
            this.cbCategoriaProducto.DisplayMember = "NombreCategoria";
            this.cbCategoriaProducto.ValueMember = "IdCategoria";
        }
        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCtrlProducto.Validar(txtNombreProducto.Text,txtPrecioCompraProducto.Text,txtPrecioVentaProducto.Text,txtStockProducto.Text))
                {
                    if (Convert.ToInt64(cbCategoriaProducto.SelectedValue) != 0)
                    {

                        Producto objProducto = new Producto();
                        Precio objPrecio = new Precio();

                        if (CargarObjetoProducto(objProducto, objPrecio))
                        {
                            if (Utilitarios.Utilitarios.Evento == 0)
                            {
                                if (objCtrlProducto.InsertarProducto(objProducto, objPrecio))
                                {
                                    MessageBox.Show("Producto Registrado con éxito!", "Sistema de Ventas");
                                    this.Close();
                                }
                                else
                                { MessageBox.Show("Error en el registro del Producto","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                            }
                            else
                            {
                                if (Convert.ToDouble(txtPrecioVentaProducto.Text.Replace(".", ",")) == Utilitarios.Utilitarios.PrecioVenta)
                                {
                                    if (objCtrlProducto.ModificarProducto(objProducto, objPrecio))
                                    {
                                        MessageBox.Show("Producto Actualizado con éxito!","Sistema de Ventas");
                                        this.Close();
                                    }
                                    else
                                    { MessageBox.Show("Error en la actualizacion del Producto","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                                }
                                else
                                {
                                    if (objCtrlProducto.ModificarProducto(objProducto, objPrecio))
                                    {
                                        objPrecio.IdPrecio = objCtrlPrecio.GenerarID();
                                        objPrecio.PrecioCompra = Convert.ToDouble(txtPrecioCompraProducto.Text.Replace(".", ","));
                                        objPrecio.PrecioVenta = Convert.ToDouble(txtPrecioVentaProducto.Text.Replace(".", ","));
                                        objPrecio.FechaInicial = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                        objPrecio.FechaFinal = null;
                                        objPrecio.IdProducto = Utilitarios.Utilitarios.IdProducto;
                                        objPrecio.EstadoPrecio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPrecio);
                                        if (objCtrlPrecio.InsertarPrecio(objPrecio))
                                        {
                                            MessageBox.Show("Producto Actualizado con éxito!","Sistema de Ventas");
                                            this.Close();
                                        }
                                        else
                                        { MessageBox.Show("Error al insertar el nuevo Precio","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }

                                    }
                                    else
                                    { MessageBox.Show("Error en la actualizacion del Producto","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor seleccionar Categoria", "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CargarObjetoProducto(Producto objProducto, Precio objPrecio)
        {
            try
            {
                var x = objRNProducto.TraerProductoPorNombreExacto(txtNombreProducto.Text.Trim());

                objPrecio.EstadoPrecio = Convert.ToInt32(Utilitarios.Utilitarios.EstadoPrecio);

                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    objProducto.IdProducto = objCtrlProducto.GenerarID();
                    objPrecio.IdPrecio = objCtrlPrecio.GenerarID();

                    if (x.LongCount() == 0)
                    { objProducto.NombreProducto = txtNombreProducto.Text; }
                    else { MessageBox.Show("No se puede registrar Producto, porque ya existe registro con el mismo Nombre, por favor verifique e intente nuevamente.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                }
                else
                {
                    objProducto.IdProducto = Utilitarios.Utilitarios.IdProducto;
                    objPrecio.IdPrecio = Utilitarios.Utilitarios.IdPrecio;

                    if (x.LongCount() == 0)
                    { objProducto.NombreProducto = txtNombreProducto.Text; }
                    else if(x.LongCount() == 1)
                    {
                        objProducto.NombreProducto = txtNombreProducto.Text;
                    }
                    else { MessageBox.Show("No se puede actualizar Producto, porque ya existe registro con el mismo Nombre, por favor verifique.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                    if (Convert.ToDouble(txtPrecioVentaProducto.Text.Replace(".", ",")) != Utilitarios.Utilitarios.PrecioVenta)
                    {
                        objPrecio.FechaFinal = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        objPrecio.EstadoPrecio = 0;
                    }
                }
                objProducto.DescripcionProducto = txtDescripcionProducto.Text;
                objProducto.Stock = int.Parse(txtStockProducto.Text);
                objProducto.IdCategoria = Int64.Parse(cbCategoriaProducto.SelectedValue.ToString());
                objProducto.EstadoProducto = Convert.ToInt32(Utilitarios.Utilitarios.EstadoProducto);

                if (txtPrecioCompraProducto.Text != "0" && txtPrecioCompraProducto.Text != "0.")
                {
                    objPrecio.PrecioCompra = Convert.ToDouble(txtPrecioCompraProducto.Text.Replace(".", ","));
                    objPrecio.PrecioVenta = Convert.ToDouble(txtPrecioVentaProducto.Text.Replace(".", ","));
                }
                else { MessageBox.Show("Los datos de Precio de Compra no son correctos, por favor ingrese datos válidos", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                objPrecio.FechaInicial = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                objPrecio.IdProducto = objProducto.IdProducto;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos del Producto.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Alfanumerico(e);
        }
        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Alfanumerico(e);
        }
        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Numeros(e);
        }
        private void txtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtPrecioCompraProducto);
        }
        private void txtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtPrecioVentaProducto);
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            this.pictureBoxPro1.Visible = false;
        }

        private void txtNombreProducto_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombreProducto.Text) || txtNombreProducto.Text.Length < 3)
                {
                    pictureBoxPro1.BackColor = Color.Red;
                    this.txtNombreProducto.BackColor = Color.LightYellow;
                    pictureBoxPro1.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrecioCompraProducto_Leave(object sender, EventArgs e)
        {
            this.pictureBoxPro2.Visible = false;
        }

        private void txtPrecioCompraProducto_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtPrecioCompraProducto.Text))
                {
                    pictureBoxPro2.BackColor = Color.Red;
                    this.txtPrecioCompraProducto.BackColor = Color.LightYellow;
                    pictureBoxPro2.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrecioVentaProducto_Leave(object sender, EventArgs e)
        {
            this.pictureBoxPro3.Visible = false;
        }

        private void txtPrecioVentaProducto_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtPrecioVentaProducto.Text))
                {
                    pictureBoxPro3.BackColor = Color.Red;
                    this.txtPrecioVentaProducto.BackColor = Color.LightYellow;
                    pictureBoxPro3.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtStockProducto_Leave(object sender, EventArgs e)
        {
            this.pictureBoxPro4.Visible = false;
        }

        private void txtStockProducto_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtStockProducto.Text))
                {
                    pictureBoxPro4.BackColor = Color.Red;
                    this.txtStockProducto.BackColor = Color.LightYellow;
                    pictureBoxPro4.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCategoriaProducto_Validated(object sender, EventArgs e)
        {
            try
            {
                if (cbCategoriaProducto.Text.Equals("--- Seleccionar ---"))
                {
                    pictureBoxPro5.BackColor = Color.Red;
                    this.cbCategoriaProducto.BackColor = Color.LightYellow;
                    pictureBoxPro5.Visible = true;
                }
                else { pictureBoxPro5.Visible = false; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
