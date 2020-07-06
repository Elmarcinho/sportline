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
    public partial class FrmGestionProducto : Form
    {
        CtrlProducto objCtrlProducto = new CtrlProducto();
        CtrlPrecio objCtrlPrecio = new CtrlPrecio();
    
        public FrmGestionProducto()
        {
            InitializeComponent();
        }
        private void FrmListaProducto_Load(object sender, EventArgs e)
        {
            this.Permiso();
        }
        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 7
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevoProducto.Enabled = true;
                       
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 8
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        ModificarProductoToolStripMenuItem.Enabled = true;
                       
                    }
                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 9
                       && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        EliminarProductoToolStripMenuItem.Enabled = true;
                       
                    }
                }
            }
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;
         
            if (Application.OpenForms["FrmProducto"] != null)
            {
                Application.OpenForms["FrmProducto"].BringToFront();
                return;
            }
            FrmProducto FProducto = new FrmProducto();
            FProducto.Show();
            FProducto.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void ModificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.Evento = 1;

                if (Application.OpenForms["FrmProducto"] != null)
                {
                    Application.OpenForms["FrmProducto"].BringToFront();
                    return;
                }
                FrmProducto FProducto = new FrmProducto();
                FProducto.Show();
                FProducto.label16.Text = "Edición del Producto";
                Utilitarios.Utilitarios.IdProducto = long.Parse(dgvProducto.CurrentRow.Cells[0].Value.ToString());
                FProducto.txtNombreProducto.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
                FProducto.txtDescripcionProducto.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
                Utilitarios.Utilitarios.IdPrecio = long.Parse(dgvProducto.CurrentRow.Cells[3].Value.ToString());
                Utilitarios.Utilitarios.PrecioCompra = Convert.ToDouble(dgvProducto.CurrentRow.Cells["PrecioC"].Value.ToString());
                FProducto.txtPrecioCompraProducto.Text = dgvProducto.CurrentRow.Cells["PrecioC"].Value.ToString();
                FProducto.txtPrecioVentaProducto.Text = dgvProducto.CurrentRow.Cells["PrecioV"].Value.ToString();
                Utilitarios.Utilitarios.PrecioVenta = Convert.ToDouble(dgvProducto.CurrentRow.Cells["PrecioV"].Value.ToString());
                FProducto.txtStockProducto.Text = dgvProducto.CurrentRow.Cells["StockProducto"].Value.ToString();
                FProducto.txtStockProducto.BorderStyle=BorderStyle.FixedSingle;
                FProducto.txtStockProducto.ReadOnly = true;
                FProducto.cbCategoriaProducto.Text = dgvProducto.CurrentRow.Cells["Categoria"].Value.ToString();

                FProducto.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            }
            else
            {
                MessageBox.Show("Por favor dar Clic derecho a la fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 1;

            Producto objProducto = new Producto();
            //Precio objPrecio = new Precio();
            objProducto.IdProducto = long.Parse(dgvProducto.CurrentRow.Cells[0].Value.ToString());

            if (dgvProducto.CurrentRow.Cells["EstadoProducto"].Value.ToString() == "Activo")
            {
                objProducto.EstadoProducto = 0;

                if (MessageBox.Show("Baja del Producto?", "Sistema de Ventas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if ((objCtrlProducto.EliminarProducto(objProducto)))
                    {
                        CargarGrillaProducto();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Alta/Baja del Producto.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                objProducto.EstadoProducto = 1;

                if (MessageBox.Show("Alta del Producto?", "Sistema de Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if ((objCtrlProducto.EliminarProducto(objProducto)))
                    {
                        CargarGrillaProducto();
                    }
                    else
                    {
                        MessageBox.Show("Error en la Alta/Baja del Producto.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnCerrarListaProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrillaProducto()
        {
            Negocio.RNLista.RNProducto objRNProducto = new Negocio.RNLista.RNProducto();
            long id = 0;

            if (long.TryParse(this.txbBuscarProducto.Text, out id))
            {
                this.dgvProducto.DataSource = objRNProducto.TraerListaProducto(long.Parse(this.txbBuscarProducto.Text.Trim()));

            }
            else
            {
                this.dgvProducto.DataSource = objRNProducto.TraerProductoPorNombre(this.txbBuscarProducto.Text.Trim());

            }

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvProducto.Visible == true && dgvProducto.RowCount > 0)
            {
                this.CargarGrillaProducto();
            }
        }
        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.Rows.Count > 0)
            {
                dgvProducto.Rows[dgvProducto.CurrentRow.Index].Selected = true;
            }
        }
        private void dgvProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                contextMenuProducto.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void dgvProducto_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                try
                {
                    dgvProducto.CurrentCell = dgvProducto.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    dgvProducto.Rows[e.RowIndex].Selected = true;
                    dgvProducto.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Visible==false)
            {
                dgvProducto.Visible = true;
            }
            this.CargarGrillaProducto();
        }

        private void txbBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarProducto.PerformClick();
            }
        }
    }
}
