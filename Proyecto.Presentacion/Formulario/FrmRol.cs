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
    public partial class FrmRol : Form
    {
        CtrlRol objCtrlRol = new CtrlRol();
        RNValidar objRNValidar = new RNValidar();
        public FrmRol()
        {
            InitializeComponent();
        }
        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    Rol objRol = new Rol();
                    objRol.IdRol = objCtrlRol.GenerarID();
                    objRol.NombreRol = this.txtRol.Text;
                    objRol.Descripcion = this.txtDescripRol.Text;
                    objRol.EstadoRol = Convert.ToInt32(Utilitarios.Utilitarios.EstadoRol);
                    if (objCtrlRol.InsertarRol(objRol))
                    {
                        MessageBox.Show("Rol Registrado con éxito!","Sistema de Ventas");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en el registro de Rol","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Rol objRol = new Rol();
                    objRol.IdRol = Utilitarios.Utilitarios.IdRol;
                    objRol.NombreRol = txtRol.Text;
                    objRol.Descripcion = txtDescripRol.Text;
                    objRol.EstadoRol = Convert.ToInt32(Utilitarios.Utilitarios.EstadoRol);

                    if (objCtrlRol.ModificarRol(objRol))
                    {
                        MessageBox.Show("Rol Actualizado con éxito!","Sistema de Ventas");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la actualizacion de Rol","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtRol);
        }
        private void txtDescripRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtRol);
        }
    }
}
