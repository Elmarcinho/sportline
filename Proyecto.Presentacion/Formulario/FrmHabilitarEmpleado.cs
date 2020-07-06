using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocio;
using Proyecto.Datos;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmHabilitarEmpleado : Form
    {
        CtrlCliente objCtrlCliente = new CtrlCliente();
        Negocio.RNLista.RNEmpleado objRNEmpleado = new Negocio.RNLista.RNEmpleado();
        public FrmHabilitarEmpleado()
        {
            InitializeComponent();
        }
      
        private void FrmHabilitarEmpleado_Load(object sender, EventArgs e)
        {
            
        }
        private void btnHabilitarEmpleadoCliente_Click(object sender, EventArgs e)
        {
            
            if (btnHabilitarEmpleadoCliente.Text == "Buscar")
            {
                var objEmpleado=objRNEmpleado.TraerEmpleado(Convert.ToInt64(txtCedulaEmpleado.Text));
                foreach (var item in objEmpleado)
                {
                    Utilitarios.Utilitarios.IdEmpleado = item.Código;
                    lbNombreEmpleado.Text = item.NombreEmpleado;
                }
                lbEmpleado.Visible = true;
                lbNombreEmpleado.Visible = true;
                btnHabilitarEmpleadoCliente.Text = "Habilitar";
                
            }
            else
            {
                Cliente objCliente = new Cliente();
                objCliente.IdPersona = Utilitarios.Utilitarios.IdEmpleado;
                //if (objCtrlCliente.InsertarEmpleadoCliente(objCliente))
                //{
                //    MessageBox.Show("Empleado habilitado con éxito!");
                //    this.Close();
                //}
            }
        }
    }
}
