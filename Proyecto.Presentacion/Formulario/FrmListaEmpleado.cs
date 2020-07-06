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
    public partial class FrmListaEmpleado : Form
    {
        public FrmListaEmpleado()
        {
            InitializeComponent();
        }
        private void FrmListaAsignarEmpleado_Load(object sender, EventArgs e)
        {
            this.CargarGrillaEmpleado();
        }
        private void CargarGrillaEmpleado()
        {
            Negocio.RNLista.RNEmpleado objEmpleado = new Negocio.RNLista.RNEmpleado();
            dgvListaEmpleado.DataSource = objEmpleado.TraerEmpleadoSinUser();
            dgvListaEmpleado.Columns[0].Width = 50;
            dgvListaEmpleado.Columns[1].Width = 150;
        }

        private void dgvEmpleadoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dgvListaEmpleado.Rows.Count > 0)
                {
                    dgvListaEmpleado.Rows[dgvListaEmpleado.CurrentRow.Index].Selected = true;
                }
        }
        private void dgvEmpleadoUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvListaEmpleado.SelectedRows.Count > 0)
            {
                Utilitarios.Utilitarios.IdEmpleado = Convert.ToInt64(dgvListaEmpleado.CurrentRow.Cells[0].Value.ToString());
                Utilitarios.Utilitarios.NombreEmpleado = dgvListaEmpleado.CurrentRow.Cells[1].Value.ToString();
            }

            this.Close();
        }
    }
}
