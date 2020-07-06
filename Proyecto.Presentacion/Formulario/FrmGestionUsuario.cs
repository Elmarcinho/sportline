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
    public partial class FrmListaUsuarioRol : Form
    {
        CtrlUsuario objCtrUsuario = new CtrlUsuario();
        Utilitarios.EncryptKey objEncrypt = new Utilitarios.EncryptKey();

        public FrmListaUsuarioRol()
        {
            InitializeComponent();
        }
        private void FrmListaUsuarioRol_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        public void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 18
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoUsuario.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 19
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        ModificarToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
            Utilitarios.Utilitarios.IdEmpleado = 0;
            Utilitarios.Utilitarios.NombreEmpleado = null;

            if (Application.OpenForms["FrmUsuario"] != null)
            {
                Application.OpenForms["FrmUsuario"].BringToFront();
                return;
            }
            FrmUsuario FUsu = new FrmUsuario();
            FUsu.Show();
            FUsu.FormClosed += new FormClosedEventHandler(form2_FormClosed);//Para actualizar Grilla al cerrar un formulario
        }
        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                //if (dgvUsuarios.CurrentRow.Cells[6].Value.ToString() == "Activo")
                //{
                Utilitarios.Utilitarios.Evento = 1;
                if (Application.OpenForms["FrmUsuario"] != null)
                {
                    Application.OpenForms["FrmUsuario"].BringToFront();
                    return;
                }
                FrmUsuario FUsu = new FrmUsuario();
                FUsu.Visible = false;
                FUsu.Show();
                FUsu.txtEmpleado.Enabled = false;
                FUsu.btnBuscarEmpleado.Enabled = false;
                FUsu.txtEmpleado.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                Utilitarios.Utilitarios.IdUsuario = long.Parse(dgvUsuarios.CurrentRow.Cells[2].Value.ToString());
                FUsu.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                FUsu.txtContraseña.Text = Utilitarios.Utilitarios.PasswordTemp;
                FUsu.txtRContraseña.Text = Utilitarios.Utilitarios.PasswordTemp;
                Utilitarios.Utilitarios.Pass = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                FUsu.cbRol.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                FUsu.Visible = true;
                FUsu.FormClosed += new FormClosedEventHandler(form2_FormClosed);//Para actualizar Grilla
            }
            ////else
            ////{
            //FrmUsuario FUsuario = new FrmUsuario();
            //        FUsuario.txtEmpleado.Enabled = false;
            //        FUsuario.btnBuscarEmpleado.Enabled = false;
            //        FUsuario.lblEstadoUsuario.Visible = true;
            //        FUsuario.cbEstadoUsuario.Visible = true;
            //        FUsuario.txtEmpleado.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            //        Utilitarios.Utilitarios.IdUsuario = long.Parse(dgvUsuarios.CurrentRow.Cells[2].Value.ToString());
            //        FUsuario.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            //        FUsuario.txtContraseña.Text = objEncrypt.DesEncriptarKey(dgvUsuarios.CurrentRow.Cells[4].Value.ToString());
            //        FUsuario.txtRContraseña.Text = objEncrypt.DesEncriptarKey(dgvUsuarios.CurrentRow.Cells[4].Value.ToString());
            //        FUsuario.cbRol.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            //        FUsuario.cbEstadoUsuario.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            //        FUsuario.Show();
            //        if (dgvUsuarios.SelectedRows.Count > 0)
            //        { Utilitarios.Utilitarios.Evento = 1; }
            //        else
            //        {
            //            Utilitarios.Utilitarios.Evento = 0;
            //            dgvUsuarios.ClearSelection();
            //        }
            //        }
            //    //}
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (dgvUsuarios.SelectedRows.Count > 0)
        //    {
        //        Utilitarios.Utilitarios.Evento = 1;

        //        Usuario objUsuario = new Usuario();
        //        objUsuario.IdUsuario = long.Parse(dgvUsuarios.CurrentRow.Cells[2].Value.ToString());
        //        objUsuario.EstadoUsuario = 0;

        //        if (MessageBox.Show("Elimininar Usuario?", "Sistema de Ventas",
        //         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        //        {
        //            if (objCtrUsuario.EliminarUsuario(objUsuario))
        //            {
        //                MessageBox.Show("Usuario Eliminado con éxito!","Sistema de Ventas");
        //                CargarGrillaUsuario();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error al Eliminar Usuario","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //            }
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("Por Favor Seleccione la Fila a Eliminar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        private void btnMostrarListaUsuario_Click(object sender, EventArgs e)
        {
            CargarGrillaUsuario();
            dgvUsuarios.Visible = true;
        }
        private void btnCerrarListaUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaUsuario()
        {
            Negocio.RNLista.RNUsuario objUsuario = new Negocio.RNLista.RNUsuario();
            dgvUsuarios.DataSource = objUsuario.TraerUsuarioActivo();
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[2].Visible = false;
            dgvUsuarios.Columns[1].Width =210;
            dgvUsuarios.Columns[3].Width = 140;
            dgvUsuarios.Columns[5].Width = 140;
            dgvUsuarios.Columns[6].Width = 120;
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvUsuarios.Visible == true && dgvUsuarios.RowCount > 0)
            {
                this.CargarGrillaUsuario();
            }
        }
        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Selected = true;
            }
        }
        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuUsuario.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dgvUsuarios_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvUsuarios.CurrentCell = dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvUsuarios.Rows[e.RowIndex].Selected = true;
                    dgvUsuarios.Focus();

                    //selectedBiodataId = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[1].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
