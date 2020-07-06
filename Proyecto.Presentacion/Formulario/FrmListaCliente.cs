using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocio.RNLista;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmListaCliente : Form
    {
        RNCliente objRNCliente = new RNCliente();
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void FrmListaCliente_Load(object sender, EventArgs e)
        {
            this.CargarGrillaCliente();
        }
        private void CargarGrillaCliente()
        {
            RNCliente objCliente = new RNCliente();
            dgvListaCliente.DataSource = objCliente.TraerClienteGeneral();

            DataGridViewButtonColumn ColumnaButton = new DataGridViewButtonColumn();
            ColumnaButton.HeaderText = "";
            ColumnaButton.Name = "btnAñadirCliente";
            dgvListaCliente.Columns.Insert(0, ColumnaButton);

            dgvListaCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaCliente.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaCliente.Columns[1].Width = 56;
            dgvListaCliente.Columns[2].Width = 239;
            dgvListaCliente.Columns[6].Width = 115;
            dgvListaCliente.Columns[7].Width = 80;
            dgvListaCliente.Columns[3].Visible = false;
            dgvListaCliente.Columns[4].Visible = false;
            dgvListaCliente.Columns[5].Visible = false;
            dgvListaCliente.Columns[8].Visible = false;
            dgvListaCliente.Columns[9].Visible = false;
            dgvListaCliente.Columns[10].Visible = false;
            dgvListaCliente.Columns[11].Visible = false;
            dgvListaCliente.Columns[12].Visible = false;
            dgvListaCliente.Columns[1].ReadOnly = true;
            dgvListaCliente.Columns[2].ReadOnly = true;
            dgvListaCliente.Columns[6].ReadOnly = true;
            dgvListaCliente.Columns[7].ReadOnly = true;
            dgvListaCliente.Columns[13].ReadOnly = true;

        }
        private void dgvListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Utilitarios.Utilitarios.EventoVer == 0)
            {
                if (this.dgvListaCliente.Columns[e.ColumnIndex].Name == "btnAñadirCliente" && e.RowIndex > -1)
                {
                    FrmVentaProducto frm;

                    if (Application.OpenForms["FrmVentaProducto"] != null)
                    {
                        frm = (FrmVentaProducto)Application.OpenForms["FrmVentaProducto"];
                        Utilitarios.Utilitarios.IdCliente = Convert.ToInt64(dgvListaCliente.CurrentRow.Cells[1].Value.ToString());
                        frm.txtNombreCliente.Text = dgvListaCliente.CurrentRow.Cells[2].Value.ToString();
                        frm.txtCedulaNit.Text = dgvListaCliente.CurrentRow.Cells[6].Value.ToString();
                    }
                    this.Close();
                }
            }
            else if (Utilitarios.Utilitarios.EventoVer==1)
            {
                if (this.dgvListaCliente.Columns[e.ColumnIndex].Name == "btnAñadirCliente" && e.RowIndex > -1)
                {
                    Utilitarios.Utilitarios.EventoClic = 1;
                    FrmVentaServicio frm;

                    if (Application.OpenForms["FrmVentaServicio"] != null)
                    {
                        frm = (FrmVentaServicio)Application.OpenForms["FrmVentaServicio"];
                        Utilitarios.Utilitarios.IdCliente = Convert.ToInt64(dgvListaCliente.CurrentRow.Cells[1].Value.ToString());
                        frm.txtNombreCliente.Text = dgvListaCliente.CurrentRow.Cells[2].Value.ToString();
                        frm.txtCedulaNit.Text = dgvListaCliente.CurrentRow.Cells[6].Value.ToString();
                    }
                    this.Close();
                }
            }
            else
            {
                if (this.dgvListaCliente.Columns[e.ColumnIndex].Name == "btnAñadirCliente" && e.RowIndex > -1)
                {
                    FrmPagoServicio FPagoServicio;

                    if (Application.OpenForms["FrmPagoServicio"] != null)
                    {
                        FPagoServicio = (FrmPagoServicio)Application.OpenForms["FrmPagoServicio"];
                        Utilitarios.Utilitarios.IdCliente = Convert.ToInt64(dgvListaCliente.CurrentRow.Cells[1].Value.ToString());
                        FPagoServicio.txtNombreCliente.Text = dgvListaCliente.CurrentRow.Cells[2].Value.ToString();
                        FPagoServicio.txtCedulaNit.Text = dgvListaCliente.CurrentRow.Cells[6].Value.ToString();
                    }
                    this.Close();
                }
            }
        }

        private void dgvListaCliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvListaCliente.Rows[e.RowIndex].Cells["btnAñadirCliente"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.AgregarCli, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

                this.dgvListaCliente.Rows[e.RowIndex].Height = Properties.Resources.AgregarCli.Height + 9;
                this.dgvListaCliente.Columns[e.ColumnIndex].Width = Properties.Resources.AgregarCli.Width + 9;

                e.Handled = true;
            }
        }

        private void dgvListaCliente_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                dgvListaCliente.Cursor = Cursors.Hand;
                DataGridViewCell cell = dgvListaCliente.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Clic para agregar";
            }
            else
            {
                dgvListaCliente.Cursor = Cursors.Default;
            }
        }

        private void dgvListaCliente_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaCliente.Cursor = Cursors.Default;
        }

        private void txbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                long id = 0;

                if (long.TryParse(this.txbBuscarCliente.Text, out id))
                {
                    this.dgvListaCliente.DataSource = objRNCliente.TraerClienteGeneralPorCedula(long.Parse(this.txbBuscarCliente.Text.Trim()));
                }
                else
                {
                    this.dgvListaCliente.DataSource = objRNCliente.TraerClienteGeneralPorNombre(this.txbBuscarCliente.Text.Trim());

                }
            }
        }
    }
}
