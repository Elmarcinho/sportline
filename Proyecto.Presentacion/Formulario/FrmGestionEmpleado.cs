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
    public partial class FrmGestionEmpleado : Form
    {
        CtrlEmpleado objCtrEmpleado = new CtrlEmpleado();

        public FrmGestionEmpleado()
        {
            InitializeComponent();
        }
        private void FrmListaEmpleado_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        public void Permiso()
        {

            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 3
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {

                        btnNuevoEmpleado.Enabled = true;
                      
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 4
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {

                        ModificarEmpleadoToolStripMenuItem.Enabled = true;
                       
                    }
                }
            }
        }
        private void btnNuevoEmpleado_Click_1(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;

            if (Application.OpenForms["FrmEmpleado"] != null)
            {
                Application.OpenForms["FrmEmpleado"].BringToFront();
                return;
            }
            FrmEmpleado FEmple = new FrmEmpleado();
            FEmple.Show();
            FEmple.lbRegistroEmpleado.Visible = true;
            FEmple.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void ModificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;
                if (Application.OpenForms["FrmEmpleado"] != null)
                {
                    Application.OpenForms["FrmEmpleado"].BringToFront();
                    return;
                }
                FrmEmpleado FEmple = new FrmEmpleado();
                FEmple.Visible = false;
                FEmple.lnModificarEmpleado.Visible = true;
                FEmple.Show();
                Utilitarios.Utilitarios.IdEmpleado = long.Parse(dgvEmpleado.CurrentRow.Cells[0].Value.ToString());
                FEmple.txtNombreEmpleado.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
                FEmple.txtAppE.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
                FEmple.txtApmE.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
                FEmple.txtCiE.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
                FEmple.pbcEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;//Acomoda la imagen al tamaño del picture
                byte[] datos = new byte[0];
                datos = (byte[])dgvEmpleado.CurrentRow.Cells[10].Value;//Extrae la imagen
                if (datos != null)//validacion si no tiene foto
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    FEmple.pbcEmpleado.Image = Bitmap.FromStream(ms);
                }
                else { FEmple.pbcEmpleado.Image = Properties.Resources.user; }

                if (dgvEmpleado.CurrentRow.Cells[8].Value != null)
                { FEmple.dtFechanacimientoE.Text = dgvEmpleado.CurrentRow.Cells[8].Value.ToString(); }
                else { FEmple.dtFechanacimientoE.Text = "01/01/1900"; }

                FEmple.dtFechaIngresoE.Text = dgvEmpleado.CurrentRow.Cells[9].Value.ToString();
                if (dgvEmpleado.CurrentRow.Cells[7].Value.ToString() == "M")
                {
                    FEmple.rbMasculinoE.Text = dgvEmpleado.CurrentRow.Cells[7].Value.ToString();
                    FEmple.rbMasculinoE.Checked = true;
                }
                else
                {
                    FEmple.rbFemeninoE.Text = dgvEmpleado.CurrentRow.Cells[7].Value.ToString();
                    FEmple.rbFemeninoE.Checked = true;
                }
                FEmple.txtTelefonoE.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
                FEmple.txtDireccionE.Text = dgvEmpleado.CurrentRow.Cells[11].Value.ToString();
                FEmple.cbCiudadZonaEmpleado.DropDownStyle = ComboBoxStyle.DropDown;//propiedad para podes editar combo
                FEmple.cbCiudadZonaEmpleado.Text = dgvEmpleado.CurrentRow.Cells[13].Value.ToString() + " / " + dgvEmpleado.CurrentRow.Cells[12].Value.ToString();
                FEmple.Visible = true;
                FEmple.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            }
            else
            {
                MessageBox.Show("Por favor dar Clic derecho a la fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCerrarListaEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaEmpleado()
        {
            Negocio.RNLista.RNEmpleado objRNEmpleado = new Negocio.RNLista.RNEmpleado();
            long id = 0;

            if (long.TryParse(this.txbBuscarEmpleado.Text, out id))
            {
                this.dgvEmpleado.DataSource = objRNEmpleado.TraerEmpleadoActivoPorCedula(long.Parse(this.txbBuscarEmpleado.Text.Trim()));

            }
            else
            {
                this.dgvEmpleado.DataSource = objRNEmpleado.TraerEmpleadoActivoPorNombre(this.txbBuscarEmpleado.Text.Trim());

            }

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvEmpleado.Visible == true && dgvEmpleado.RowCount > 0)
            {
                this.CargarGrillaEmpleado();
            }
        }
        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleado.Rows.Count > 0)
            {
                dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Selected = true;
                pbcListaEmpleado.Visible = true;
                pbcListaEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;//Acomoda la imagen al tamaño del picture
                byte[] datos = new byte[0];
                datos = (byte[])dgvEmpleado.CurrentRow.Cells["FotoEmple"].Value; //Extrae la imagen
                if (datos != null)//validacion si no tiene foto
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pbcListaEmpleado.Image = Image.FromStream(ms);
                }
                else { pbcListaEmpleado.Image = Properties.Resources.user; }
            }
        }
        
        private void dgvEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                contextMenuEmpleado.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dgvEmpleado_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvEmpleado.CurrentCell = dgvEmpleado.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvEmpleado.Rows[e.RowIndex].Selected = true;
                    dgvEmpleado.Focus();

                    //selectedBiodataId = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[1].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.Visible==false)
            {
                dgvEmpleado.Visible = true;
            }
            CargarGrillaEmpleado();
        }
        private void txbBuscarEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarEmpleado.PerformClick();
            }
        }
    }
}
