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
    public partial class FrmGestionRolPermiso : Form
    {
        CtrlRol objCtrlRol = new CtrlRol();
        CtrlRolPermiso objCtrlRolPermiso = new CtrlRolPermiso();
        int contador = 0;
        int contarvacio = 0;
        public FrmGestionRolPermiso()
        {
            InitializeComponent();
        }
        private void FrmListaRolPermiso_Load(object sender, EventArgs e)
        {
            this.CargarComboRolAsignar();
            this.CargarComboRolDetalle();
            this.Permiso();
        }
        public void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 20
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoRol.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 21
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        ModificarToolStripMenuItem.Enabled = true;
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 22
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        EliminarToolStripMenuItem.Enabled = true;
                    }
                
                        cbListaRolAsignar.Visible = true;
                        btnAsignarPermiso.Visible = true;
                        btnAsignarPermiso.Enabled = true;
               
                        cbListaRolDetalle.Visible = true;
                        btnModificarRolPermiso.Visible = true;
                        btnModificarRolPermiso.Enabled = true;
                    
                }
            }
        }
        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;

            if (Application.OpenForms["FrmRol"] != null)
            {
                Application.OpenForms["FrmRol"].BringToFront();
                return;
            }
            FrmRol FRol = new FrmRol();
            FRol.Show();
            FRol.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;

                if (Application.OpenForms["FrmRol"] != null)
                {
                    Application.OpenForms["FrmRol"].BringToFront();
                    return;
                }
                FrmRol FRol = new FrmRol();
                Utilitarios.Utilitarios.IdRol = long.Parse(dgvRoles.CurrentRow.Cells[0].Value.ToString());
                FRol.txtRol.Text = dgvRoles.CurrentRow.Cells[1].Value.ToString();
                FRol.txtDescripRol.Text = dgvRoles.CurrentRow.Cells[2].Value.ToString();
                FRol.Show();
                FRol.FormClosed += new FormClosedEventHandler(form2_FormClosed);//Para actualizar Grilla                                                                         
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;
                if (Utilitarios.Utilitarios.Evento == 1)
                {
                    Rol objRol = new Rol();
                    objRol.IdRol = long.Parse(dgvRoles.CurrentRow.Cells[0].Value.ToString());
                    objRol.EstadoRol = 0;

                    if (MessageBox.Show("Eliminar Rol?", "Sistema de Ventas",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (objCtrlRol.EliminarRol(objRol))
                        {
                            MessageBox.Show("Rol Eliminado con exito!","Sistema de Ventas");
                            CargarGrillaRol();
                        }
                        else
                        {
                            MessageBox.Show("Error en el registro de Rol","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione la Fila a Eliminar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbListaRolAsignar.SelectedValue) != 0)
                {

                    List<RolPermiso> ListaRolPermiso = new List<RolPermiso>();

                    foreach (DataGridViewRow fila in dgvPermisos.Rows)
                    {

                        if ((string)fila.Cells["CheckPermiso"].Value=="T")
                        {
                            RolPermiso objAuxRolPermiso = new RolPermiso();
                            objAuxRolPermiso.IdRol = Int64.Parse(this.cbListaRolAsignar.SelectedValue.ToString());
                            objAuxRolPermiso.IdPermiso = long.Parse(fila.Cells["IdPermiso"].Value.ToString());
                            objAuxRolPermiso.EstadoRolPermiso = 1;
                            ListaRolPermiso.Add(objAuxRolPermiso);
                        }
                        else { contarvacio++; }

                    }
                    if (contarvacio != Convert.ToInt32(dgvPermisos.RowCount))
                    {
                        contarvacio = 0;
                        foreach (var item in ListaRolPermiso)
                        {
                            RolPermiso objRolPermiso = new RolPermiso();
                            objRolPermiso.IdRol = item.IdRol;
                            objRolPermiso.IdPermiso = item.IdPermiso;
                            objRolPermiso.EstadoRolPermiso = item.EstadoRolPermiso;
                            if (objCtrlRolPermiso.InsertarRolPermiso(objRolPermiso))
                            { contador++; }
                        }

                        if (contador > 0)
                        {
                            dgvPermisos.DataSource = null;
                            //dgvPermisos.Columns.RemoveAt(0);
                            MessageBox.Show("Permiso asignado con exito!","Sistema de Ventas");
                        }
                        else
                        {
                            MessageBox.Show("Error en el registro de Permiso","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        contarvacio = 0;
                        MessageBox.Show("Por favor seleccione al menos un permiso.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor seleccione un Rol","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnModificarRolPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbListaRolDetalle.SelectedValue) != 0)
                {
                    List<RolPermiso> ListaRolPermiso = new List<RolPermiso>();
                    foreach (DataGridViewRow fila in dgvRolPermisos.Rows)
                    {
                        RolPermiso objAuxRolPermiso = new RolPermiso();
                        objAuxRolPermiso.IdRol = Int64.Parse(this.cbListaRolDetalle.SelectedValue.ToString());
                        objAuxRolPermiso.IdPermiso = long.Parse(fila.Cells["CodigoPermiso"].Value.ToString());
                        if ((string)fila.Cells["CheckRolPermiso"].Value=="T")
                        {
                            objAuxRolPermiso.EstadoRolPermiso = 1;

                        }
                        else { objAuxRolPermiso.EstadoRolPermiso = 0; }
                        ListaRolPermiso.Add(objAuxRolPermiso);

                    }
                    foreach (var item in ListaRolPermiso)
                    {
                        RolPermiso objRolPermiso = new RolPermiso();
                        objRolPermiso.IdRol = item.IdRol;
                        objRolPermiso.IdPermiso = item.IdPermiso;
                        objRolPermiso.EstadoRolPermiso = item.EstadoRolPermiso;
                        if (objCtrlRolPermiso.ModificarRolPermiso(objRolPermiso))
                        { contador++; }
                    }
                    if (contador > 0)
                    {
                        MessageBox.Show("Permisos actualizado con éxito!","Sistema de Ventas");
                    }
                    else
                    {
                        MessageBox.Show("Error en la actualizacion de los permiso","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor seleccione un Rol","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void btnMostrarListaRol_Click(object sender, EventArgs e)
        {
            this.CargarGrillaRol();
            dgvRoles.Visible = true;
        }
        private void btnCerrarListaRolPermiso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarComboRolAsignar()
        {
            //ComboRol 1
            Negocio.RNLista.RNRol objRNRol = new Negocio.RNLista.RNRol();
            var ObjRol = objRNRol.TraerRol(0);

            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("IdRol"));
            dta.Columns.Add(new DataColumn("NombreRol"));

            DataRow dr = dta.NewRow();
            dr["IdRol"] = 0;
            dr["NombreRol"] = "--- Seleccionar ---";
            dta.Rows.Add(dr);

            foreach (var item in ObjRol)
            {
                DataRow drColomn = dta.NewRow();
                drColomn["IdRol"] = item.IdRol;
                drColomn["NombreRol"] = item.NombreRol;
                dta.Rows.Add(drColomn);
            }

            this.cbListaRolAsignar.DataSource = dta;
            this.cbListaRolAsignar.DisplayMember = "NombreRol";
            this.cbListaRolAsignar.ValueMember = "IdRol";
        }
        private void CargarComboRolDetalle()
        {
            //ComboRol 2
            Negocio.RNLista.RNRol objRNRol = new Negocio.RNLista.RNRol();
            var ObjRol = objRNRol.TraerRol(0);

            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("IdRol"));
            dta.Columns.Add(new DataColumn("NombreRol"));

            DataRow dr = dta.NewRow();
            dr["IdRol"] = 0;
            dr["NombreRol"] = "--- Seleccionar ---";
            dta.Rows.Add(dr);

            foreach (var item in ObjRol)
            {
                DataRow drColomn = dta.NewRow();
                drColomn["IdRol"] = item.IdRol;
                drColomn["NombreRol"] = item.NombreRol;
                dta.Rows.Add(drColomn);
            }

            this.cbListaRolDetalle.DataSource = dta;
            this.cbListaRolDetalle.DisplayMember = "NombreRol";
            this.cbListaRolDetalle.ValueMember = "IdRol";
        }
        private void CargarGrillaRol()
        {
            Negocio.RNLista.RNRol objRol = new Negocio.RNLista.RNRol();
            dgvRoles.DataSource = objRol.TraerListaRol();
            dgvRoles.Columns[0].Visible = false;
            dgvRoles.Columns[3].Visible = false;
            dgvRoles.Columns[1].Width = 180;
            dgvRoles.Columns[2].Width = 615;
        }
        private void cbListaRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListaRolDetalle.SelectedIndex != 0)
            {
                CargarGrillaDetalleRolPermiso(cbListaRolDetalle.SelectedIndex);
            }
            else
            {
                dgvRolPermisos.DataSource = null;
            }
        }
        private void cbListaRolAsignar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListaRolAsignar.SelectedIndex != 0)
            {
                CargarGrillaPermiso(cbListaRolAsignar.SelectedIndex);
            }
            else
            {
                dgvPermisos.DataSource = null;
            }
        }
        private void CargarGrillaDetalleRolPermiso(int x)
        {
            Negocio.RNLista.RNPermiso objPermiso = new Negocio.RNLista.RNPermiso();
            dgvRolPermisos.DataSource = objPermiso.TraerListaRolPermiso(x);

            dgvRolPermisos.AutoGenerateColumns = false;

            foreach (DataGridViewRow row in dgvRolPermisos.Rows)
            {

                if (Convert.ToInt32(row.Cells["CodigoRol"].Value) == x && Convert.ToInt32(row.Cells["EstadoRolPermiso"].Value) == 1)
                {
                    row.Cells["CheckRolPermiso"].Value = "T";
                }
                else
                {
                    row.Cells["CheckRolPermiso"].Value = "F";
                }
            }
        }
        private void CargarGrillaPermiso(int x)
        {

            Negocio.RNLista.RNPermiso objPermiso = new Negocio.RNLista.RNPermiso();
            var RolPermiso = objPermiso.TraerListaRolPermiso(x);
            List<VPermiso> Permiso = objPermiso.TraerListaPermiso(0);

            dgvPermisos.AutoGenerateColumns = false;

            if (RolPermiso.LongCount() != 0)
            {
                for (int i = 0; i < Permiso.Count; i++)
                {
                    foreach (var item2 in RolPermiso)
                    {

                        if (Permiso[i].IdPermiso==item2.IdPermiso)
                        {
                            Permiso.RemoveAt(i);
                        }
                    }
                }

                dgvPermisos.DataSource = Permiso;
            }
            else
            {
                dgvPermisos.DataSource = objPermiso.TraerListaPermiso(0);
            }

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            if (dgvRoles.Visible == true && dgvRoles.RowCount > 0)
            {
                this.CargarGrillaRol();
            }
            this.CargarComboRolAsignar();
            this.CargarComboRolDetalle();

        }
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoles.Rows.Count > 0)
            {
                dgvRoles.Rows[dgvRoles.CurrentRow.Index].Selected = true;
            }
        }
        private void dgvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPermisos.Rows.Count > 0)
            {
                dgvPermisos.Rows[dgvPermisos.CurrentRow.Index].Selected = true;
            }
        }
        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlPrincipal.SelectedTab==tabPageListaRol)
            {
                //MessageBox.Show("No tiene los permisos asignados para ver la informacion");
                //dgvRoles.Visible = false;
            }
        }
        //Metodo para posicion del ContexMenu
        private void dgvRoles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuRol.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void dgvRoles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvRoles.CurrentCell = dgvRoles.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvRoles.Rows[e.RowIndex].Selected = true;
                    dgvRoles.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
