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
    public partial class FrmGestionCliente : Form
    {
        CtrlCliente objCtrCliente = new CtrlCliente();
        CtrlBitacora objCtrlBitacora = new CtrlBitacora();
        private FrmCliente frmCli = null;

        public FrmGestionCliente()
        {
            InitializeComponent();
        }
        private void FrmListaCliente_Load(object sender, EventArgs e)
        {
            Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x=0 ; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 1
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoCliente.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 2
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        ModificarClienteToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
            FrmCliente FCli = FormInstance;
            FCli.lbRegistroCliente.Visible = true;
            FCli.Show();
            FCli.FormClosed += new FormClosedEventHandler(form2_FormClosed);//Para actualizar Grilla al cerrar un formulario
        }
        private void ModificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0 )
            {
                Utilitarios.Utilitarios.Evento = 1;
                FrmCliente FCli = FormInstance;
                FCli.Visible = false;
                FCli.lbModificarCliente.Visible = true;
                FCli.Show();
                Utilitarios.Utilitarios.IdCliente = long.Parse(dgvCliente.CurrentRow.Cells[0].Value.ToString());
                FCli.txtNombreCliente.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                FCli.txtApp.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
                FCli.txtApm.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
                Utilitarios.Utilitarios.CedulaIdendidad = long.Parse(dgvCliente.CurrentRow.Cells[5].Value.ToString());
                FCli.txtCiNit.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
                FCli.txtEmail.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
                FCli.pbcCliente.SizeMode = PictureBoxSizeMode.StretchImage;//Acomoda la imagen al tamaño del picture
                byte[] datos = new byte[0];
                datos = (byte[])dgvCliente.CurrentRow.Cells[10].Value;//Extrae la imagen
                if (datos != null)//validacion si no tiene foto
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    FCli.pbcCliente.Image = Bitmap.FromStream(ms);
                }
                else { FCli.pbcCliente.Image = Properties.Resources.user; }

                if (dgvCliente.CurrentRow.Cells[8].Value != null)
                { FCli.dtFechaNacimiento.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString(); }
                else { FCli.dtFechaNacimiento.Text = "01/01/1900"; }
                if (dgvCliente.CurrentRow.Cells[7].Value.ToString() == "M")
                {
                    FCli.rbMasculino.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
                    FCli.rbMasculino.Checked = true;
                }
                else
                {
                    FCli.rbFemenino.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
                    FCli.rbFemenino.Checked = true;
                }
                FCli.txtTelefono.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
                FCli.txtDireccion.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();
                if (dgvCliente.CurrentRow.Cells[11].Value == null)
                { FCli.txtPeso.Text = null; }
                else { FCli.txtPeso.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString(); }
                if (dgvCliente.CurrentRow.Cells[12].Value == null)
                { FCli.txtAltura.Text = null; }
                else { FCli.txtAltura.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString(); }
                FCli.cbCiudadZonaCli.DropDownStyle = ComboBoxStyle.DropDown;//propiedad para podes editar combo
                FCli.cbCiudadZonaCli.Text = dgvCliente.CurrentRow.Cells[15].Value.ToString() + " / " + dgvCliente.CurrentRow.Cells[14].Value.ToString();
                FCli.Visible = true;
                FCli.FormClosed += new FormClosedEventHandler(form2_FormClosed);

            }
            else
            {
                MessageBox.Show("Por favor dar Clic derecho a la fila a Editar.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCerrarListaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaCliente()
        {
            Negocio.RNLista.RNCliente objRNCliente = new Negocio.RNLista.RNCliente();
            long id = 0;

            if (long.TryParse(this.txbBuscarCliente.Text, out id))
            {
                this.dgvCliente.DataSource = objRNCliente.TraerClienteActivoPorCedula(long.Parse(this.txbBuscarCliente.Text.Trim()));

            }
            else
            {
                this.dgvCliente.DataSource = objRNCliente.TraerClienteActivoPorNombre(this.txbBuscarCliente.Text.Trim());

            }

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCliente FCli = FormInstance;
            FCli.TerminarFuenteDeVideo();
            if (dgvCliente.Visible==true && dgvCliente.RowCount>0)
            {
                this.CargarGrillaCliente();
            }
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.Rows.Count > 0 && e.RowIndex > -1)
            {
                dgvCliente.Rows[dgvCliente.CurrentRow.Index].Selected = true;
                pbcListaCliente.Visible = true;
                pbcListaCliente.SizeMode = PictureBoxSizeMode.StretchImage;   //Acomoda la imagen al tamaño del picture
                byte[] datos = new byte[0];
                datos = (byte[])dgvCliente.CurrentRow.Cells["FotoCli"].Value; //Extrae la imagen
                if (datos != null)//validacion si no tiene foto
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                    pbcListaCliente.Image = Image.FromStream(ms);
                }
                else { pbcListaCliente.Image = Properties.Resources.user; }


                Negocio.RNLista.RNAsistencia objRNAsistencia = new Negocio.RNLista.RNAsistencia();
                var ClienteAsistencia = objRNAsistencia.TraerClienteAsistenciaPorCedula(long.Parse(dgvCliente.CurrentRow.Cells["Cedula"].Value.ToString()));
                lbNombreDias.ForeColor = Color.Black;
                lbDias.ForeColor = Color.Black;
                lbDias.Text = ClienteAsistencia.LongCount().ToString();

            }
        }
        private void form_Dispuesto(object sender, EventArgs e)
        {
            frmCli = null;
        }
        private FrmCliente FormInstance
        {
            get
            {
                if (frmCli == null)
                {
                    frmCli = new FrmCliente();
                    frmCli.Disposed += new EventHandler(form_Dispuesto);
                }
                else { frmCli.BringToFront(); }
                return frmCli;
            }
        }
        private void dgvCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuCliente.Show(Cursor.Position.X, Cursor.Position.Y);
                
                if (Convert.ToInt32(dgvCliente.CurrentRow.Cells["IdCliente"].Value) == 2)
                {
                    ModificarClienteToolStripMenuItem.Enabled = false;
                }
                else { ModificarClienteToolStripMenuItem.Enabled = true; }
            }

        }
        private void dgvCliente_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvCliente.CurrentCell = dgvCliente.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    
                    dgvCliente.Rows[e.RowIndex].Selected = true;
                    dgvCliente.Focus();
                    //selectedBiodataId = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[1].Value);
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.Visible==false)
            {
                dgvCliente.Visible = true;
            }
            CargarGrillaCliente();
        }

        private void txbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarCliente.PerformClick();
            }
        }
    }
}