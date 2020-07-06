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
    public partial class FrmGestionServicio : Form
    {
        public FrmGestionServicio()
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

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 16
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoServicio.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 17
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        //btnModificarServicio.Enabled = true;
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
            FrmServicio FServicio = new FrmServicio();
            FServicio.Show();
            FServicio.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvServicio.Visible == true && dgvServicio.RowCount > 0)
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

        private void dgvServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServicio.Rows.Count > 0)
            {
                dgvServicio.Rows[dgvServicio.CurrentRow.Index].Selected = true;
            }
        }

        private void ModificarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvServicio.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;

                if (Application.OpenForms["FrmServicio"] != null)
                {
                    Application.OpenForms["FrmServicio"].BringToFront();
                    return;
                }
                FrmServicio FServicio = new FrmServicio();
                FServicio.Show();
                FServicio.label16.Text = "Edición del Servicio";
                Utilitarios.Utilitarios.IdServicio = long.Parse(dgvServicio.CurrentRow.Cells["CodigoServicio"].Value.ToString());
                FServicio.txtNombreServicio.Text = dgvServicio.CurrentRow.Cells["NombreSer"].Value.ToString();
                FServicio.txtDescripcionServicio.Text = dgvServicio.CurrentRow.Cells["DescripcionServicio"].Value.ToString();
                Utilitarios.Utilitarios.IdPrecio = long.Parse(dgvServicio.CurrentRow.Cells["CodigoPrecio"].Value.ToString());
                Utilitarios.Utilitarios.PrecioDiario= Convert.ToDouble(dgvServicio.CurrentRow.Cells["PrecioDia"].Value.ToString());
                Utilitarios.Utilitarios.PrecioQuincenal = Convert.ToDouble(dgvServicio.CurrentRow.Cells["PrecioQuincena"].Value.ToString());
                Utilitarios.Utilitarios.PrecioMensual = Convert.ToDouble(dgvServicio.CurrentRow.Cells["PrecioMes"].Value.ToString());
                FServicio.txtPrecioDiario.Text = dgvServicio.CurrentRow.Cells["PrecioDia"].Value.ToString();
                FServicio.txtPrecioQuincenal.Text = dgvServicio.CurrentRow.Cells["PrecioQuincena"].Value.ToString();
                FServicio.txtPrecioMensual.Text = dgvServicio.CurrentRow.Cells["PrecioMes"].Value.ToString();
                FServicio.dtpHoraInicio.Text= dgvServicio.CurrentRow.Cells["HoraInicio"].Value.ToString();
                FServicio.dtpHoraFin.Text = dgvServicio.CurrentRow.Cells["HoraFin"].Value.ToString();
                FServicio.cbRangoDia.Text= dgvServicio.CurrentRow.Cells["RangoDia"].Value.ToString();

                FServicio.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            }
            else
            {
                MessageBox.Show("Por favor dar Clic derecho a la fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServicio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuServicio.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dgvServicio_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvServicio.CurrentCell = dgvServicio.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvServicio.Rows[e.RowIndex].Selected = true;
                    dgvServicio.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
