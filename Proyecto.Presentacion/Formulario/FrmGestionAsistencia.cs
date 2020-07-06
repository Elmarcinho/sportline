using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocio;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmGestionAsistencia : Form
    {
        RNValidar objRNValidar = new RNValidar();
        public FrmGestionAsistencia()
        {
            InitializeComponent();
        }
        private void FrmGestionAsistencia_Load(object sender, EventArgs e)
        {
            this.Permiso();
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void Permiso()
        {
            if (Utilitarios.Utilitarios.IdRol > 0)
            {

                for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length / 2; x++)
                {

                    if (Utilitarios.Utilitarios.IdPermiso[x, 0] == 24
                        && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)
                    {
                        btnNuevaAsistencia.Enabled = true;
                        break;
                    }
                }
            }
        }
        private void btnNuevaAsistencia_Click(object sender, EventArgs e)
        {
            Utilitarios.Utilitarios.Evento = 0;

            if (Application.OpenForms["FrmAsistencia"] != null)
            {
                Application.OpenForms["FrmAsistencia"].BringToFront();
                return;
            }
            FrmAsistencia FAsistencia = new FrmAsistencia();
            FAsistencia.Show();
            FAsistencia.FormClosed += new FormClosedEventHandler(form2_FormClosed);
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (dgvAsistencia.Visible == false)
            {
                dgvAsistencia.Visible = true;
            }
            CargarGrillaAsistencia();
        }
        private void btnCerrarAsistencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvAsistencia.Visible == true && dgvAsistencia.RowCount > 0)
            {
                this.CargarGrillaAsistencia();
            }
        }
        private void DgvAsistencia_NumeroFilas(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvAsistencia.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void CargarGrillaAsistencia()
        {
            Negocio.RNLista.RNAsistencia objRNAsistencia = new Negocio.RNLista.RNAsistencia();

            if (txbBuscarCliente.Text == "Nombre del Cliente")
            {
                dgvAsistencia.AutoGenerateColumns = false;
                dgvAsistencia.DataSource = objRNAsistencia.TraerClienteAsistenciaRangoFecha(this.dtpFechaInicio.Value, this.dtpFechaFin.Value.AddMinutes(30));
            }
            else
            {
                dgvAsistencia.AutoGenerateColumns = false;
                dgvAsistencia.DataSource = objRNAsistencia.TraerClienteAsistenciaPorNombre(this.txbBuscarCliente.Text, this.dtpFechaInicio.Value, this.dtpFechaFin.Value.AddMinutes(30));
            }
            dgvAsistencia.RowPostPaint += new DataGridViewRowPostPaintEventHandler(DgvAsistencia_NumeroFilas);
            lbNombreDias.ForeColor = Color.White;
            lbDias.ForeColor = Color.White;
        }

        private void txbBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (txbBuscarCliente.Text == "Nombre del Cliente")
            {
                txbBuscarCliente.Text = "";
                txbBuscarCliente.ForeColor = Color.Black;
            }
        }

        private void txbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (txbBuscarCliente.Text == "")
            {
                txbBuscarCliente.Text = "Nombre del Cliente";
                txbBuscarCliente.ForeColor = Color.DarkGray;
            }
        }

        private void txbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarCliente.PerformClick();
            }
            else
            {
                objRNValidar.Letras(e,txbBuscarCliente);
            }
        }

        private void dgvAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsistencia.Rows.Count > 0 && e.RowIndex > -1)
            {
                Negocio.RNLista.RNAsistencia objRNAsistencia = new Negocio.RNLista.RNAsistencia();
                dgvAsistencia.Rows[dgvAsistencia.CurrentRow.Index].Selected = true;

                var ClienteAsistencia = objRNAsistencia.TraerClienteAsistenciaPorCedula(long.Parse(dgvAsistencia.CurrentRow.Cells["Cedula"].Value.ToString()));
                lbNombreDias.ForeColor = Color.Black;
                lbDias.ForeColor = Color.Black;
                lbDias.Text = ClienteAsistencia.LongCount().ToString();
            }
        }
    }
}
