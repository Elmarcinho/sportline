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
    public partial class FrmGestionDisciplina : Form
    {
        public FrmGestionDisciplina()
        {
            InitializeComponent();
        }

        private void FrmListaServicio_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        public void Permiso()
        {

            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.GetLength(0); x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 24
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoServicio.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 25
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        //btnModificarServicio.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 26
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        //btnEliminarServicio.Enabled = true;
                    }
                }
            }
        }

        private void btnCerrarListaServicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;

            if (Application.OpenForms["FrmServicio"] != null)
            {
                Application.OpenForms["FrmServicio"].BringToFront();
                return;
            }
            FrmDisciplina FServicio = new FrmDisciplina();
            FServicio.Show();
            FServicio.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvServicio.Visible == true)
            {
                this.CargarGrillaServicio();
            }
        }
        private void CargarGrillaServicio()
        {
            Negocio.RNLista.RNServicio objRNServicio = new Negocio.RNLista.RNServicio();
            dgvServicio.DataSource = objRNServicio.TraerListaServicio(0);

        }

        private void btnMostrarListaServicio_Click(object sender, EventArgs e)
        {
            CargarGrillaServicio();
            dgvServicio.Visible = true;
        }
    }
}
