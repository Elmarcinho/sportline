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
    public partial class FrmListaDisciplina : Form
    {
        RNServicio objRNServicio = new RNServicio();
        public FrmListaDisciplina()
        {
            InitializeComponent();
        }

        private void FrmListaServicio_Load(object sender, EventArgs e)
        {
            this.CargarGrillaServicio();
        }
        private void CargarGrillaServicio()
        {
            dgvListaServicio.DataSource = objRNServicio.TraerListaDisciplina(Utilitarios.Utilitarios.IdPlazo);

            DataGridViewButtonColumn ColumnaButton = new DataGridViewButtonColumn();
            ColumnaButton.HeaderText = "";
            ColumnaButton.Name = "btnAñadirServicio";
            ColumnaButton.DefaultCellStyle.BackColor = Color.White;
            dgvListaServicio.Columns.Insert(0, ColumnaButton);
            dgvListaServicio.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaServicio.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaServicio.Columns[1].Visible = false;
            dgvListaServicio.Columns[4].Visible = false;
            dgvListaServicio.Columns[5].Visible = false;
            dgvListaServicio.Columns[6].Visible = false;
            dgvListaServicio.Columns[8].Visible = false;
            dgvListaServicio.Columns[2].Width = 150;
            dgvListaServicio.Columns[3].Width = 350;
            dgvListaServicio.Columns[7].Width = 100;
           
        }

        private void dgvListaServicio_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                dgvListaServicio.Cursor = Cursors.Hand;
                DataGridViewCell cell = dgvListaServicio.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Clic para agregar";
            }
            else
            {
                dgvListaServicio.Cursor = Cursors.Default;
            }
        }

        private void dgvListaServicio_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaServicio.Cursor = Cursors.Default;
        }

        private void dgvListaServicio_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvListaServicio.Rows[e.RowIndex].Cells["btnAñadirServicio"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.Agregar1, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvListaServicio.Rows[e.RowIndex].Height = Properties.Resources.Agregar1.Height + 9;
                this.dgvListaServicio.Columns[e.ColumnIndex].Width = Properties.Resources.Agregar1.Width + 9;

                e.Handled = true;
            }
        }

        private void dgvListaServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListaServicio.Columns[e.ColumnIndex].Name == "btnAñadirServicio" && e.RowIndex > -1)
            {
                int auxpro = 1;
                string A = this.dgvListaServicio.CurrentRow.Cells[1].Value.ToString();
                string B = this.dgvListaServicio.CurrentRow.Cells[2].Value.ToString();
                string C = this.dgvListaServicio.CurrentRow.Cells[3].Value.ToString();
                string D = this.dgvListaServicio.CurrentRow.Cells[5].Value.ToString();
                string E = this.dgvListaServicio.CurrentRow.Cells[7].Value.ToString();
             

                FrmVentaServicio frm;

                if (Application.OpenForms["FrmVentaServicio"] != null)
                {
                    frm = (FrmVentaServicio)Application.OpenForms["FrmVentaServicio"];
                    if (frm.dgvDetallePedidoServicio.RowCount == 0)
                    {
                        frm.dgvDetallePedidoServicio.Rows.Add(A, B, C, D, E, 1);
                        frm.dgvDetallePedidoServicio.CellValueChanged -= frm.dgvDetallePedidoServicio_CellValueChanged;
                        frm.ActualizarTotalesGrillaServicio();
                        frm.dgvDetallePedidoServicio.CellValueChanged += frm.dgvDetallePedidoServicio_CellValueChanged;
                    }
                    else
                    {
                        for (int i = 0; i < frm.dgvDetallePedidoServicio.RowCount; i++)
                        {

                            if (frm.dgvDetallePedidoServicio.Rows[i].Cells["IdProducto"].Value.ToString() == A)
                            {
                                auxpro++;
                                break;
                            }

                        }
                        if (auxpro == 1)
                        {
                            frm.dgvDetallePedidoServicio.Rows.Add(A, B, C, D, E, auxpro);
                            frm.dgvDetallePedidoServicio.CellValueChanged -= frm.dgvDetallePedidoServicio_CellValueChanged;
                            frm.ActualizarTotalesGrillaServicio();
                            frm.dgvDetallePedidoServicio.CellValueChanged += frm.dgvDetallePedidoServicio_CellValueChanged;
                        }
                        else
                        {
                            for (int i = 0; i < frm.dgvDetallePedidoServicio.RowCount; i++)
                            {

                                if (Convert.ToInt32(frm.dgvDetallePedidoServicio.Rows[i].Cells["IdProducto"].Value) == Convert.ToInt32(A))
                                {
                                    frm.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value = float.Parse(frm.dgvDetallePedidoServicio.Rows[i].Cells["Cantidad"].Value.ToString()) + 1;
                                    break;

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
