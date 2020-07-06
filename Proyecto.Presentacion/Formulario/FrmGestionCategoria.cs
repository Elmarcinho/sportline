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
    public partial class FrmGestionCategoria : Form
    {
        CtrlCategoria objCtrCategoria = new CtrlCategoria();

        public FrmGestionCategoria()
        {
            InitializeComponent();
        }
        private void FrmListaCategoria_Load(object sender, EventArgs e)
        {
            Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {
                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length/2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 10
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoCategoria.Enabled = true;
                       
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 11
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        ModificarCategoriaToolStripMenuItem.Enabled = true;
                       
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 12
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        EliminarCategoriaToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }
        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;

            if (Application.OpenForms["FrmCategoria"] != null)
            {
                Application.OpenForms["FrmCategoria"].BringToFront();
                return;
            }
            FrmCategoria FCategoria = new FrmCategoria();
            FCategoria.Show();
            FCategoria.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void ModificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;
                if (Application.OpenForms["FrmCategoria"] != null)
                {
                    Application.OpenForms["FrmCategoria"].BringToFront();
                    return;
                }
                FrmCategoria FCategoria = new FrmCategoria();
                FCategoria.Show();
                Utilitarios.Utilitarios.IdCategoria = long.Parse(dgvCategoria.CurrentRow.Cells[0].Value.ToString());
                FCategoria.txtCategoria.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                FCategoria.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 1;

            Categoria objCategoria = new Categoria();
            objCategoria.IdCategoria = long.Parse(dgvCategoria.CurrentRow.Cells[0].Value.ToString());

            if (dgvCategoria.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                objCategoria.EstadoCategoria = 0;

                if (MessageBox.Show("Baja de Categoria?", "Sistema de Ventas",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (objCtrCategoria.EliminarCategoria(objCategoria))
                    {
                        CargarGrillaCategoria();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Alta/Baja de la Categoria", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                objCategoria.EstadoCategoria = 1;

                if (MessageBox.Show("Alta de Categoria?", "Sistema de Ventas",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (objCtrCategoria.EliminarCategoria(objCategoria))
                    {
                        CargarGrillaCategoria();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Alta/Baja de la Categoria", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btnMostrarListaCategoria_Click(object sender, EventArgs e)
        {
            CargarGrillaCategoria();
            dgvCategoria.Visible = true;
        }
        private void btnCerrarListaCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaCategoria()
        {
            Negocio.RNLista.RNCategoria objCategoria = new Negocio.RNLista.RNCategoria();
            dgvCategoria.DataSource = objCategoria.TraerListaCategoria();
            dgvCategoria.Columns[0].Visible = false;
            dgvCategoria.Columns[1].Width =190;
            dgvCategoria.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategoria.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvCategoria.Visible == true && dgvCategoria.RowCount > 0)
            {
                this.CargarGrillaCategoria();
            }
        }
        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.Rows.Count > 0)
            {
                dgvCategoria.Rows[dgvCategoria.CurrentRow.Index].Selected = true;
            }
        }
        private void dgvCategoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuCategoria.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void dgvCategoria_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvCategoria.CurrentCell = dgvCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvCategoria.Rows[e.RowIndex].Selected = true;
                    dgvCategoria.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
