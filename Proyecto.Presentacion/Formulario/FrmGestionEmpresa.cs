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
    public partial class FrmGestionEmpresa : Form
    {
        CtrlDescuento objCtrDescuento = new CtrlDescuento();
        public FrmGestionEmpresa()
        {
            InitializeComponent();
        }
        private void FrmGestionEmpresa_Load(object sender, EventArgs e)
        {
            Permiso();
        }
        public void Permiso()
        {

            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 27
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {

                        btnNuevoDescuento.Enabled = true;
                        break;
                    }
                  
                }
            }
        }
        private void btnNuevoDescuento_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;

            if (Application.OpenForms["FrmDescuento"] != null)
            {
                Application.OpenForms["FrmDescuento"].BringToFront();
                return;
            }
            FrmDescuento FDescuento = new FrmDescuento();
            FDescuento.Show();
            FDescuento.txtNombreDescuento.Focus();
            FDescuento.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void btnMostrarListaDescuento_Click(object sender, EventArgs e)
        {
            CargarGrillaDescuento();
            dgvDescuento.Visible = true;
        }
        private void btnCerrarEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaDescuento()
        {
            Negocio.RNLista.RNDescuento objDescuento = new Negocio.RNLista.RNDescuento();
            dgvDescuento.DataSource = objDescuento.TraerListaDescuento();

        }

        private void dgvDescuento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDescuento.Rows.Count > 0)
            {
                dgvDescuento.Rows[dgvDescuento.CurrentRow.Index].Selected = true;
            }
        }

        private void dgvDescuento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuDescuento.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dgvDescuento_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvDescuento.CurrentCell = dgvDescuento.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvDescuento.Rows[e.RowIndex].Selected = true;
                    dgvDescuento.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvDescuento.Visible == true && dgvDescuento.RowCount > 0)
            {
                this.CargarGrillaDescuento();
            }
        }

        private void ModificarDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDescuento.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;
                if (Application.OpenForms["FrmDescuento"] != null)
                {
                    Application.OpenForms["FrmDescuento"].BringToFront();
                    return;
                }
                FrmDescuento FDescuento = new FrmDescuento();
                FDescuento.Show();
                FDescuento.lbTituloDescuento.Text = "Edicion del Descuento";
                Utilitarios.Utilitarios.IdCategoria = long.Parse(dgvDescuento.CurrentRow.Cells["CodigoDescuento"].Value.ToString());
                FDescuento.txtNombreDescuento.Text = dgvDescuento.CurrentRow.Cells["NombreDes"].Value.ToString();
                FDescuento.txtMontoDescuento.Text = dgvDescuento.CurrentRow.Cells["MontoDescuento"].Value.ToString();
                FDescuento.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AltaBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 1;

            Descuento objDescuento = new Descuento();
            objDescuento.IdDescuento = long.Parse(dgvDescuento.CurrentRow.Cells["CodigoDescuento"].Value.ToString());

            if (dgvDescuento.CurrentRow.Cells["EstadoDescuento"].Value.ToString() == "Activo")
            {
                objDescuento.EstadoDescuento = 0;

                if (MessageBox.Show("Baja del Descuento?", "Sistema de Ventas",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (objCtrDescuento.AltaBajaDescuento(objDescuento))
                    {
                        CargarGrillaDescuento();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Alta/Baja del Descuento", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                objDescuento.EstadoDescuento = 1;

                if (MessageBox.Show("Alta del Descuento?", "Sistema de Ventas",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (objCtrDescuento.AltaBajaDescuento(objDescuento))
                    {
                        CargarGrillaDescuento();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Alta/Baja del Descuento", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
