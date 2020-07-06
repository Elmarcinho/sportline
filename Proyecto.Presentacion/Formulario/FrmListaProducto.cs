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
    public partial class FrmListaProducto : Form
    {
        RNProducto objRNProducto = new RNProducto();
        public FrmListaProducto()
        {
            InitializeComponent();
        }
        private void FrmListaProductoServicio_Load(object sender, EventArgs e)
        {
            this.CargarGrillaProducto();
        }
        private void CargarGrillaProducto()
        {
            dgvListaProducto.DataSource = objRNProducto.TraerListaProducto(0);

            DataGridViewButtonColumn ColumnaButton = new DataGridViewButtonColumn();
            ColumnaButton.HeaderText = "";
            ColumnaButton.Name = "btnAñadirProducto";
            //ColumnaButton.SortMode= DataGridViewColumnSortMode.Automatic;
            ColumnaButton.DefaultCellStyle.BackColor = Color.White;
            dgvListaProducto.Columns.Insert(0, ColumnaButton);

            dgvListaProducto.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaProducto.Columns[1].Visible = false;
            dgvListaProducto.Columns[4].Visible = false;
            if (Utilitarios.Utilitarios.EventoVer == 0)
            {
                dgvListaProducto.Columns[5].Visible = false;
            }
            else
            {
                dgvListaProducto.Columns[6].Visible = false;
            }
            dgvListaProducto.Columns[8].Visible = false;
            dgvListaProducto.Columns[10].Visible = false;
            dgvListaProducto.Columns[2].Width = 130;
            dgvListaProducto.Columns[3].Width = 165;
            dgvListaProducto.Columns[6].Width = 80;
            dgvListaProducto.Columns[7].Width = 80;
            dgvListaProducto.Columns[9].Width = 140;
            dgvListaProducto.Columns[2].ReadOnly = true;
            dgvListaProducto.Columns[3].ReadOnly = true;
            dgvListaProducto.Columns[6].ReadOnly = true;
            dgvListaProducto.Columns[7].ReadOnly = true;
            dgvListaProducto.Columns[9].ReadOnly = true;
        }

        private void dgvListaProductoServicio_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvListaProducto.Rows[e.RowIndex].Cells["btnAñadirProducto"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.Agregar1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvListaProducto.Rows[e.RowIndex].Height = Properties.Resources.Agregar1.Height + 9;
                this.dgvListaProducto.Columns[e.ColumnIndex].Width = Properties.Resources.Agregar1.Width + 9;

                e.Handled = true;
            }
        }
    
        private void dgvListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Utilitarios.Utilitarios.EventoVer == 0)
            {
                if (this.dgvListaProducto.Columns[e.ColumnIndex].Name == "btnAñadirProducto" && e.RowIndex > -1)
                {
                    int auxpro = 1;
                    string A = this.dgvListaProducto.CurrentRow.Cells[1].Value.ToString();
                    string B = this.dgvListaProducto.CurrentRow.Cells[2].Value.ToString();
                    string C = this.dgvListaProducto.CurrentRow.Cells[3].Value.ToString();
                    string D = this.dgvListaProducto.CurrentRow.Cells[4].Value.ToString();
                    string E = this.dgvListaProducto.CurrentRow.Cells[6].Value.ToString();
                    string F = this.dgvListaProducto.CurrentRow.Cells[7].Value.ToString();

                    FrmVentaProducto frm;

                    if (Application.OpenForms["FrmVentaProducto"] != null)
                    {
                        frm = (FrmVentaProducto)Application.OpenForms["FrmVentaProducto"];

                        if (Convert.ToInt32(dgvListaProducto.CurrentRow.Cells[7].Value) != 0)
                        {
                            if (frm.dgvDetallePedidoProducto.RowCount == 0)
                            {
                                frm.dgvDetallePedidoProducto.Rows.Add(A, B, C, D, E, F, 1);
                                frm.dgvDetallePedidoProducto.CellValueChanged -= frm.dgvDetallePedidoProducto_CellValueChanged;
                                frm.ActualizarTotalesGrilla();
                                frm.dgvDetallePedidoProducto.CellValueChanged += frm.dgvDetallePedidoProducto_CellValueChanged;
                            }
                            else
                            {
                                for (int i = 0; i < frm.dgvDetallePedidoProducto.RowCount; i++)
                                {

                                    if (frm.dgvDetallePedidoProducto.Rows[i].Cells["IdProducto"].Value.ToString() == A)
                                    {
                                        auxpro++;
                                        break;
                                    }

                                }
                                if (auxpro == 1)
                                {
                                    frm.dgvDetallePedidoProducto.Rows.Add(A, B, C, D, E, F, auxpro, 0);
                                    frm.dgvDetallePedidoProducto.CellValueChanged -= frm.dgvDetallePedidoProducto_CellValueChanged;
                                    frm.ActualizarTotalesGrilla();
                                    frm.dgvDetallePedidoProducto.CellValueChanged += frm.dgvDetallePedidoProducto_CellValueChanged;


                                }
                                else
                                {
                                    for (int i = 0; i < frm.dgvDetallePedidoProducto.RowCount; i++)
                                    {

                                        if ((Convert.ToInt32(frm.dgvDetallePedidoProducto.Rows[i].Cells["IdProducto"].Value) == Convert.ToInt32(A))
                                            && (Convert.ToInt32(frm.dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value) <= Convert.ToInt32(F)))
                                        {
                                            frm.dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value = float.Parse(frm.dgvDetallePedidoProducto.Rows[i].Cells["Cantidad"].Value.ToString()) + 1;
                                            frm.dgvDetallePedidoProducto.CellValueChanged -= frm.dgvDetallePedidoProducto_CellValueChanged;
                                            frm.ActualizarTotalesGrilla();
                                            frm.dgvDetallePedidoProducto.CellValueChanged += frm.dgvDetallePedidoProducto_CellValueChanged;
                                            break;
                                        }

                                    }
                                }
                            }
                        }
                        else { MessageBox.Show("Stock en Cero, no se puede agregar al carrito de compra.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                }
            }
            else
            {
                if (this.dgvListaProducto.Columns[e.ColumnIndex].Name == "btnAñadirProducto" && e.RowIndex > -1)
                {
                    int auxpro = 1;
                    string A = this.dgvListaProducto.CurrentRow.Cells[1].Value.ToString();
                    string B = this.dgvListaProducto.CurrentRow.Cells[2].Value.ToString();
                    string C = this.dgvListaProducto.CurrentRow.Cells[3].Value.ToString();
                    string D = this.dgvListaProducto.CurrentRow.Cells[4].Value.ToString();
                    string E = this.dgvListaProducto.CurrentRow.Cells[5].Value.ToString();

                    FrmCompraProducto frm;

                    if (Application.OpenForms["FrmCompraProducto"] != null)
                    {
                        frm = (FrmCompraProducto)Application.OpenForms["FrmCompraProducto"];

                        if (frm.dgvDetalleCompraProducto.RowCount == 0)
                        {

                            frm.dgvDetalleCompraProducto.Rows.Add(A, B, C, D, E, 1);
                            frm.dgvDetalleCompraProducto.CellValueChanged -= frm.dgvDetalleCompraProducto_CellValueChanged;
                            frm.ActualizarTotalesGrillaCompra();
                            frm.dgvDetalleCompraProducto.CellValueChanged += frm.dgvDetalleCompraProducto_CellValueChanged;

                        }
                        else
                        {
                            for (int i = 0; i < frm.dgvDetalleCompraProducto.RowCount; i++)
                            {

                                if (frm.dgvDetalleCompraProducto.Rows[i].Cells["IdProducto"].Value.ToString() == A)
                                {
                                    auxpro++;
                                    break;
                                }

                            }
                            if (auxpro == 1)
                            {

                                frm.dgvDetalleCompraProducto.Rows.Add(A, B, C, D, E, auxpro);
                                frm.dgvDetalleCompraProducto.CellValueChanged -= frm.dgvDetalleCompraProducto_CellValueChanged;
                                frm.ActualizarTotalesGrillaCompra();
                                frm.dgvDetalleCompraProducto.CellValueChanged += frm.dgvDetalleCompraProducto_CellValueChanged;
                            }
                            else
                            {
                                for (int i = 0; i < frm.dgvDetalleCompraProducto.RowCount; i++)
                                {

                                    if (Convert.ToInt32(frm.dgvDetalleCompraProducto.Rows[i].Cells["IdProducto"].Value) == Convert.ToInt32(A))
                                    {
                                        frm.dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value = float.Parse(frm.dgvDetalleCompraProducto.Rows[i].Cells["Cantidad"].Value.ToString()) + 1;
                                        break;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        private void dgvListaProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListaProducto.Columns[e.ColumnIndex].Name == "Stock")
            {
                try
                {
                    if(Convert.ToInt32(e.Value) > 0 && Convert.ToInt32(e.Value)<=5)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt32(e.Value) == 0)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
        private void dgvListaProducto_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0 && e.RowIndex > -1)
            {
                dgvListaProducto.Cursor = Cursors.Hand;
                DataGridViewCell cell = dgvListaProducto.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Clic para agregar";
            }
            else
            {
                dgvListaProducto.Cursor = Cursors.Default;
            }
        }
        private void dgvListaProducto_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaProducto.Cursor = Cursors.Default;
        }

        private void txbBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dgvListaProducto.DataSource = objRNProducto.TraerProductoPorNombre(this.txbBuscarProducto.Text.Trim());
            }
        }
    }
}
