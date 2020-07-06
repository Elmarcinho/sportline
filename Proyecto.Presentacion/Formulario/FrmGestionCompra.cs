using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmGestionCompra : Form
    {
        private FrmCompraProducto frmProducto = null;
        public FrmGestionCompra()
        {
            InitializeComponent();
        }

        private void FrmListaCompra_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 13
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnCompraProducto.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 14
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        //btnModificarCompra.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 15
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        //btnAnularCompra.Enabled = true;
                    }
                }
            }
        }

        private void btnCompraProducto_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
            FrmCompraProducto FCompra = FormInstance;
            FCompra.Show();
            FCompra.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void btnCerrarListaCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.CargarGrillaVenta();
            if (Application.OpenForms["FrmListaProducto"] != null)
            {
                Application.OpenForms["FrmListaProducto"].Close();
            }
        }
        private void form_Dispuesto(object sender, EventArgs e)
        {
            frmProducto = null;
        }
        private FrmCompraProducto FormInstance
        {
            get
            {
                if (frmProducto == null)
                {
                    frmProducto = new FrmCompraProducto();
                    frmProducto.Disposed += new EventHandler(form_Dispuesto);
                }
                else { frmProducto.BringToFront(); }

                return frmProducto;
            }
        }
    }
}
