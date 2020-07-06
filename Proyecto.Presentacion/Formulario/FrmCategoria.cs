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
    public partial class FrmCategoria : Form
    {
        CtrlCategoria objCtrlCategoria = new CtrlCategoria();
        RNValidar objRNValidar = new RNValidar();
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    Categoria objCategoria = new Categoria();
                    objCategoria.IdCategoria = objCtrlCategoria.GenerarID();
                    objCategoria.NombreCategoria = this.txtCategoria.Text;
                    objCategoria.EstadoCategoria = Convert.ToInt32(Utilitarios.Utilitarios.EstadoCategoria);
                    if (objCtrlCategoria.InsertarCategoria(objCategoria))
                    {
                        MessageBox.Show("Categoria registrado con éxito!", "Sistema de Ventas");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en el registro de Categoria.", "Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Categoria objCategoria = new Categoria();
                    objCategoria.IdCategoria = Utilitarios.Utilitarios.IdCategoria;
                    objCategoria.NombreCategoria = txtCategoria.Text;
                    objCategoria.EstadoCategoria = Convert.ToInt32(Utilitarios.Utilitarios.EstadoCategoria);

                    if (objCtrlCategoria.ModificarCategoria(objCategoria))
                    {
                        MessageBox.Show("Categoria actualizado con éxito!", "Sistema de Ventas");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la actualizacion de Categoria.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardarCategoria.PerformClick();
            }
            else
            {
                objRNValidar.Letras(e,txtCategoria);
            }
        }
    }
}
