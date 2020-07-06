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
    public partial class FrmDescuento : Form
    {
        CtrlDescuento objCtrlDescuento = new CtrlDescuento();
        RNValidar objRNValidar = new RNValidar();
        public FrmDescuento()
        {
            InitializeComponent();
        }

        private void txtMontoDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Numeros(e);
        }

        private void btnGuardarDescuento_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreDescuento.Text != string.Empty && txtMontoDescuento.Text != string.Empty)
                {
                    if (Utilitarios.Utilitarios.Evento == 0)
                    {

                        Descuento objDescuento = new Descuento();
                        objDescuento.IdDescuento = objCtrlDescuento.GenerarID();
                        objDescuento.NombreDescuento = txtNombreDescuento.Text;
                        objDescuento.Monto = Convert.ToDouble(txtMontoDescuento.Text.Replace(".", ","));
                        objDescuento.EstadoDescuento = Convert.ToInt32(Utilitarios.Utilitarios.EstadoDescuento);
                        if (objCtrlDescuento.InsertarDescuento(objDescuento))
                        {
                            MessageBox.Show("Descuento registrado con éxito!", "Sistema de Ventas");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error en el registro de Descuento.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        Descuento objDescuento = new Descuento();
                        objDescuento.IdDescuento = Utilitarios.Utilitarios.IdCategoria;
                        objDescuento.NombreDescuento = txtNombreDescuento.Text;
                        objDescuento.Monto = Convert.ToDouble(txtMontoDescuento.Text.Replace(".", ","));
                        objDescuento.EstadoDescuento = Convert.ToInt32(Utilitarios.Utilitarios.EstadoDescuento);

                        if (objCtrlDescuento.ModificarDescuento(objDescuento))
                        {
                            MessageBox.Show("Descuento actualizado con éxito!", "Sistema de Ventas");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error en la actualizacion de Categoria.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else { MessageBox.Show("Favor llenar los campos obligatorio Descripcion y Monto"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
